var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "",
    defaults: new {controller = "Welcome", action = "WelcomeDefault" }
);
app.MapControllerRoute(
    name: "User",
    pattern: "{controller}/{action}/{prenom?}/{nom?}"
);

app.Run();
