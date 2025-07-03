using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews(); // MVC (Model-View-Controller) servisleri projeye dahil edilir.

var app = builder.Build();

// 2. Ortam (Environment) kontrolü ve hata sayfasý gösterimi
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Hata sayfasý gösterimi
}

// 3. Statik Dosyalarýn Kullanýmý
app.UseStaticFiles(); // wwwroot içindeki dosyalarýn (css, js, img) eriþilebilir olmasýný saðlar.

// 4. Routing (Yönlendirme) Aktifleþtirme
app.UseRouting(); // Gelen HTTP isteklerini uygun controller ve action’a yönlendirmek için routing middleware’i etkinleþtirir.

// 5. Varsayýlan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// Eðer tarayýcýdan bir istek yapýlýrsa, varsayýlan olarak HomeController'daki Index action'ýna yönlendirilir.

// 6. Uygulamanýn baþlatýlmasý
app.Run(); // Uygulama baþlatýlýr ve gelen istekler dinlenir.

