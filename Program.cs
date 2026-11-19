
using Microsoft.EntityFrameworkCore;
using SistemaEstoque.Data;
using SistemaEstoque.Components;

var builder = WebApplication.CreateBuilder(args);

var conexao = builder.Configuration.GetConnectionString("ConexaoMySQL")
    ?? throw new InvalidOperationException("String de conexão não encontrada.");

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseMySQL(conexao));

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
