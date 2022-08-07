using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSqlServer<MovieDbContext>(builder.Configuration.GetConnectionString("MovieDb"));
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IReviewRepositoryAsync, ReviewRepositoryAsync>();
builder.Services.AddScoped<IReviewServiceAsync, ReviewServiceAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();

var app = builder.Build();
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
    pattern: "{controller=Movies}/{action=Index}");

app.Run();
