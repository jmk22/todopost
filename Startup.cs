namespace ToDoList
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
    using Nancy;
    using System.IO;

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
