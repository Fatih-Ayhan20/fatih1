using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews(); // MVC (Model-View-Controller) servisleri projeye dahil edilir.

var app = builder.Build();

// 2. Ortam (Environment) kontrol� ve hata sayfas� g�sterimi
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Hata sayfas� g�sterimi
}

// 3. Statik Dosyalar�n Kullan�m�
app.UseStaticFiles(); // wwwroot i�indeki dosyalar�n (css, js, img) eri�ilebilir olmas�n� sa�lar.

// 4. Routing (Y�nlendirme) Aktifle�tirme
app.UseRouting(); // Gelen HTTP isteklerini uygun controller ve action�a y�nlendirmek i�in routing middleware�i etkinle�tirir.

// 5. Varsay�lan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// E�er taray�c�dan bir istek yap�l�rsa, varsay�lan olarak HomeController'daki Index action'�na y�nlendirilir.

// 6. Uygulaman�n ba�lat�lmas�
app.Run(); // Uygulama ba�lat�l�r ve gelen istekler dinlenir.

