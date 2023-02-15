using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationIdentity03.Data;
using WebApplicationIdentity03.Models;
using WebApplicationIdentity03.Services;

namespace WebApplicationIdentity03
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(
                options =>
                {
                    // Políticas do Identity

                    // senha
                    options.Password.RequiredLength = 4;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;

                    //// bloqueio
                    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(5000);
                    //options.Lockout.MaxFailedAccessAttempts = 3;
                    //options.Lockout.AllowedForNewUsers = true;

                    //// configurações de login
                    //options.SignIn.RequireConfirmedEmail = true;
                    //options.SignIn.RequireConfirmedPhoneNumber = true;

                    //// configurações de validação do usuário
                    //options.User.RequireUniqueEmail = true;
                    //options.User.AllowedUserNameCharacters = "abcdef";
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.Cookie.Name = "seu nome de cookie";
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.Expiration = TimeSpan.FromMinutes(30);
            //});

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                // appsettings.json
                // facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                // facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];

                // secrets.json (botão direito projeto > Manage User Secrets 
                facebookOptions.AppId = Configuration["Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Facebook:AppSecret"];
            });

            // secrets.json (botão direito projeto > Manage User Secrets 
            var _testeSecreto = Configuration["MeuSegredo"];

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            
            IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //CreateRoles(serviceProvider);
        }

        //private void CreateRoles(IServiceProvider serviceProvider)
        //{
        //    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>> ();
        //    var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        //    Task<IdentityResult> roleResultado;
        //    string email = "admin@admin.net";

        //    // verifique se existe um perfil Administrador e o cria se não existir
        //    Task<bool> hasAdminRole = roleManager.RoleExistsAsync("Administrador");
        //    hasAdminRole.Wait();

        //    if (!hasAdminRole.Result)
        //    {
        //        roleResultado = roleManager.CreateAsync(new IdentityRole("Administrador"));
        //    }

        //    // verifica se o usuário admin existe e o cria se não existir
        //    // e a seguir o incluir no perfil Admin
        //    Task<ApplicationUser> testeUser = userManager.FindByEmailAsync(email);
        //    testeUser.Wait();

        //    if (testeUser.Result == null)
        //    {
        //        ApplicationUser administrador = new ApplicationUser();
        //        administrador.Email = email;
        //        administrador.UserName = email;

        //        // não funcionou (aula 08_Identity_Role_Codigo)
        //        Task<IdentityResult> novoUsuario = userManager.CreateAsync(administrador, "123456");
        //        novoUsuario.Wait();

        //        if (novoUsuario.Result.Succeeded)
        //        {
        //            Task<IdentityResult> novoUsuarioRole = userManager.AddToRoleAsync(administrador, "Administrador");
        //            novoUsuarioRole.Wait();
        //        }
        //    }
        //}
    }
}
