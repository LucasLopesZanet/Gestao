using Gestao.Web.Servico.Interface;
using Gestao.Web.Servico;
using System;
using Gestao.Web.Repositorio;
using Gestao.Web.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ILancamentoService, LancamentoService>();
builder.Services.AddScoped<ILancamentoRepositorio, LancamentoRepositorio>();
builder.Services.AddDbContext<Contexto>(opt => opt.UseInMemoryDatabase("teste"));

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
