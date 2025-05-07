using ConvergenceCorpBlazor.Components;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
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

WebApplication app = builder.Build(); //initialize the webapp

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts(); //HTTP Strict Transport Security Protocol
}

//app.UseAuthentication();
//app.UseHttpsRedirection(); //redirects traffic to https if possible EDIT: REMOVED so cloudflare can redirect, not origin server

//app.MapStaticAssets(); dotnet 9 feature. using dotnet 8s UseStaticFiles instead
app.UseStaticFiles();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.UseAntiforgery();

app.Run();
