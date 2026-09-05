using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Pointstar.Site
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();

			builder.Services.Configure<RazorViewEngineOptions>(options =>
			{
				options.PageViewLocationFormats.Add("/Pages/Shared/Partials/{0}" + RazorViewEngine.ViewExtension);
				options.PageViewLocationFormats.Add("/Pages/Shared/Partials/m/{0}" + RazorViewEngine.ViewExtension);
				options.PageViewLocationFormats.Add("/Pages/Shared/Partials/Admin/{0}" + RazorViewEngine.ViewExtension);
			});

			WebApplication app = builder.Build();

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

			app.UseAuthorization();

			app.MapStaticAssets();
			app.MapRazorPages()
			   .WithStaticAssets();

			// required to get IP Address from request
			// https://stackoverflow.com/questions/28664686/how-do-i-get-client-ip-address-in-asp-net-core
			app.UseForwardedHeaders(new ForwardedHeadersOptions
			{
				ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
			});

			IConfiguration configuration = builder.Configuration;
			// AppSettings.Initialize(configuration);

			IServiceProvider appServices = app.Services;

			var webHostEnvironment = appServices.GetRequiredService<IWebHostEnvironment>();
			// ArtworkMemoryCache.WebSiteRootFilePath = webHostEnvironment.WebRootPath;


			app.Run();
		}
	}
}
