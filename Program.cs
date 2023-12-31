var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default1",
    pattern:"Produit Accueil" ,
    defaults:new { Controller = "Produit", Action = "Accueil" });

app.MapControllerRoute(
    name: "default2",
    pattern: "Produit Edit",
    defaults: new { Controller = "Produit", Action = "Edit" });

app.MapControllerRoute(
    name: "default3",
    pattern: "Produit Update",
    defaults: new { Controller = "Produit", Action = "Update" });

app.MapControllerRoute(
    name: "default3",
    pattern: "Produit Lister",
    defaults: new { Controller = "Produit", Action = "Lister" });

app.Run();
