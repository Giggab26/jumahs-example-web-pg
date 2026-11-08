var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Temporarily enable Developer Exception Page in Production to catch the 500 error
app.UseDeveloperExceptionPage();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<jumahs_example_web_pg.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
