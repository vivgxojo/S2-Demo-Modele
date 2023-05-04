var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Relier les vues aux controleurs

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Home}/{action=Index}/{numero?}"
);

app.MapControllerRoute(
 name: "default",
 //pattern: structure de l'url : peut contenir le contrôleur,
 //la méthode d'action et les paramètres
 pattern: "/{numero}",
 //defaults : indiquer le contrôler et la méthode d'action par défaut.
 defaults: new { controller = "Home", action = "Chercher" }
);

app.Run();
