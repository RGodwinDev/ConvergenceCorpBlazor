using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using ConvergenceCorpBlazor.Components;
using ConvergenceCorpBlazor.Components.Pages;
using Microsoft.Data.SqlClient;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var keyVaultName = String.Empty;
var dbUser = String.Empty;
var dbPass = String.Empty;
if (builder.Environment.IsDevelopment())
{
    Console.WriteLine("DEV ENVIRONMENT!!!!!!!!!!!!!");

    //USE DEV CONFIG FILE
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
}
else if (builder.Environment.IsProduction())
{
    Console.WriteLine("PRODUCTION!!!!!!!!!!");
    
    //USE PRODUCTION CONFIG FILE
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Production.json");
}
else
{
    Console.WriteLine("NOT DEV OR PRODUCTION, PROBABLY STAGING");
}

keyVaultName = builder.Configuration.GetValue<string>("KEY_VAULT_NAME");
var vaultUri = "https://" + keyVaultName + ".vault.azure.net";
Console.WriteLine("Getting Secrets");
//SecretClient can access azure key vault at uri address with provided credentials
var client = new SecretClient(new Uri(vaultUri), new DefaultAzureCredential());

//get the db username
var x = await client.GetSecretAsync("CVRG-DBUSER");
while (x == null)
{
    x = await client.GetSecretAsync("CVRG-DBUSER");
}
dbUser = x.Value.Value;

//get the db password
var y = await client.GetSecretAsync("CVRG-DBPASS");
while (y == null)
{
    y = await client.GetSecretAsync("CVRG-DBPASS");
}
dbPass = y.Value.Value;
Console.WriteLine("Secrets Achieved");

/*
builder.Services.AddAuthentication(
    CertificateAuthenticationDefaults.AuthenticationScheme
).AddCertificate();
*/

//redirects traffic to https
/*
builder.Services.AddHttpsRedirection(options =>{
    options.RedirectStatusCode = Status308PermanentRedirect;
    options.HttpsPort = 443;
});
*/

//Localization service
builder.Services.AddLocalization();
string[] supportedCultures = new[] { "en-US" }; //add more localization options here
RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);


/**
 * CREATE THE APP
 */
WebApplication app = builder.Build();

app.UseRequestLocalization(localizationOptions);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts(); //HTTP Strict Transport Security Protocol
}

//app.UseAuthentication();  //should be after UseRouting and before UseEndpoints
//app.UseHttpsRedirection(); //redirects traffic to https if possible EDIT: REMOVED so cloudflare can redirect, not origin server

/** these are called explicitly by the WebApplicationBuilder, do not need to call them unless you want to control WHEN they're called.
 * app.Use                  Registers custom middleware that runs at the start of the pipelin
 * app.UseRouting();        runs after custom middleware
 * app.UseEndpoints();      runs at the end of the pipeline
 */


app.UseAntiforgery();
//prevents cross-site request forgery attacks (XSRF/CSRF)
//antiforgery services added automatically when AddRazorComponents is called
//called after UseHttpsRedirection
//must be after UseAuthentication and UseAuthorization
//FOR MORE:
//https://learn.microsoft.com/en-us/aspnet/core/blazor/security/?view=aspnetcore-10.0&tabs=visual-studio#antiforgery-support


app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

/*
 * Build the Connection String
 */
Console.WriteLine("building connection");
SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
sqlConnectionStringBuilder.Authentication = (SqlAuthenticationMethod)1;
sqlConnectionStringBuilder.UserID = dbUser;
sqlConnectionStringBuilder.Password = dbPass;
sqlConnectionStringBuilder.InitialCatalog = "CVRGFREEDB";
sqlConnectionStringBuilder.Encrypt = true;
sqlConnectionStringBuilder.TrustServerCertificate = false;
sqlConnectionStringBuilder.ConnectTimeout = 30;
sqlConnectionStringBuilder["Server"] = "tcp:cvrg.database.windows.net,1433";


SqlConnection sqlConnection = new SqlConnection(
        sqlConnectionStringBuilder.ConnectionString
    );

//init the groups
Console.WriteLine("Creating Groups");
Groups.StartGroup2(sqlConnection);

SqlConnection runConnection = new SqlConnection(
        sqlConnectionStringBuilder.ConnectionString
    );
//add runs to the groups
Console.WriteLine("Running the Runs");
Groups.InitializeRuns(runConnection);
Console.WriteLine("Group initialization Finished");
app.Run();
Console.WriteLine("Server Shutting Down!");