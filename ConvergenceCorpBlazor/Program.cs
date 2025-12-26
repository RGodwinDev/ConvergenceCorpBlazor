using ConvergenceCorpBlazor.Components;
using ConvergenceCorpBlazor.Classes.DBControllers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

if (builder.Environment.IsDevelopment())
{
    Console.WriteLine("DEV ENVIRONMENT!!!!!!!!!!!!!");
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
}
else if (builder.Environment.IsProduction())
{
    Console.WriteLine("PRODUCTION!!!!!!!!!!");
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Production.json");
}
else
{
    Console.WriteLine("NOT DEV OR PRODUCTION, PROBABLY STAGING");
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Production.json");
}


/*
builder.Services.AddAuthentication(
    CertificateAuthenticationDefaults.AuthenticationScheme
).AddCertificate();
*/

//redirects traffic to https //this is removed because cloudflare. redirecting ourselves messes with the connection.
/*
builder.Services.AddHttpsRedirection(options =>{
    options.RedirectStatusCode = StatusCodes.Status308PermanentRedirect;
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
//makes stuff in wwwroot useable.

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

/*
 * Build the Connection String
 */
//init the groups
Console.WriteLine("Creating Groups");
DBGroup.GetAll();
//add runs to the groups
Console.WriteLine("Running the Runs");
DBGroupRun.GetAll();
Console.WriteLine("Group initialization Finished");

app.Run();
Console.WriteLine("Server Shutting Down!");