using Elsa.Persistence.EntityFramework.Core.Extensions;
using Elsa.Persistence.EntityFramework.PostgreSql;
using Elsa.Persistence.YesSql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//ELSA
//builder.Services.AddElsa(options =>
//options.AddHttpActivities()).AddElsaApiEndpoints();
//   // Run migrations automatically:
builder.Services.AddElsa(
                        options =>
                        {
                            options.AddHttpActivities();
                            options.UseEntityFrameworkPersistence(ef => ef.UsePostgreSql("Server=127.0.0.1;Port=5432;Database=elsa;User Id=postgres;Password=admin;"), true);
                            //options.UseYesSqlPersistence(a => a.UsePostgreSql("Server=127.0.0.1;Port=5432;Database=elsa;User Id=postgres;Password=admin;"));
                        }
                        ).AddElsaApiEndpoints();

var app = builder.Build();

//    services.AddElsa(options => options.UseYesSqlPersistence(config => config.UsePostgreSql("Server=127.0.0.1;Port=5432;Database=elsa;User Id=postgres;Password=password;")));


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//ELSA
app.UseHttpActivities();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
