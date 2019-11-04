using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtocolComparationDotNet.Domain.Repositorios;

namespace ProtocolComparationDotNet.GraphQL
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ProdutoRepository>();
            services.AddSingleton<VendaRepository>();
            services.AddSingleton<VendaProdutoRepository>();
            services.AddCors(options =>
            {
                options.AddPolicy("Teste",
                builder =>
                {
                    builder.WithOrigins("*")
                    .WithHeaders("*")
                    .WithMethods("*");
                });
            });
            services.AddControllers();
                //.AddNewtonsoftJson(options =>
                //       options.SerializerSettings.ContractResolver =
                //          new DefaultContractResolver());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            
            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors("Teste");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
