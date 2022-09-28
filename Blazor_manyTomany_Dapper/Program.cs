using Blazor_manyTomany_Dapper.Data;
using Blazor_manyTomany_Dapper.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//BookAuthor service  
builder.Services.AddScoped<IBookAuthorService, BookAuthorService>();
//Author service  
builder.Services.AddScoped<IAuthorService, AuthorService>();
//Publisher service  
builder.Services.AddScoped<IPublisherService, PublisherService>();
//Book service  
builder.Services.AddScoped<IBookService, BookService>();
//Register dapper in scope  
builder.Services.AddScoped<IDapperService, DapperService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
