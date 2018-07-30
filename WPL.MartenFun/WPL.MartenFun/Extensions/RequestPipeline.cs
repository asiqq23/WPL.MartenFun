namespace WPL.MartenFun.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Middlewares;

    public static class RequestPipeline
    {
        public static void UseErrorHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
        }

        public static void UseSwaggerWithUi(this IApplicationBuilder app)
        {
            app.UseSwagger().UseSwaggerUI(
                p =>
                {
                    p.SwaggerEndpoint("/swagger/v1/swagger.json", "Komplett.MenuAdmin.Api V1");
                    p.DocExpansion(DocExpansion.List);
                    p.EnableValidator(null);
                }).UseRedirectToSwagger();
        }

        public static void UseExceptionHandling(this IApplicationBuilder app, IHostingEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseErrorHandler();
            }
        }
    }
}