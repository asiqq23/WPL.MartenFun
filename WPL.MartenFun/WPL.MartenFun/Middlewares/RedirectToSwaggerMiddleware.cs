namespace WPL.MartenFun.Middlewares
{
    using Microsoft.AspNetCore.Builder;

    public static class RedirectToSwaggerMiddleware
    {
        public static IApplicationBuilder UseRedirectToSwagger(this IApplicationBuilder appBuilder)
        {
            return appBuilder.Use(async (context, next) =>
            {
                if (context.Request.Path.Value == "/" && context.Request.Method.ToUpper() == "GET")
                {
                    context.Response.Redirect("/swagger/");
                    return;
                }

                await next();
            });
        }
    }
}
