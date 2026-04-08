using Microsoft.EntityFrameworkCore;
using prova.Data; // Nome da sua pasta Data

var builder = WebApplication.CreateBuilder(args);

// 1. Configuração do Banco de Dados (DbContext)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Adicionar suporte ao padrão MVC (Controllers e Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3. Configuração do pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 4. Rota Padrão - Ajustada para abrir no Personal/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Personal}/{action=Index}/{id?}");

app.Run();