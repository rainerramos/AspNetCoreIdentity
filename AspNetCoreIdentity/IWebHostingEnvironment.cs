namespace AspNetCoreIdentity
{
    public interface IWebHostingEnvironment
    {
        string ContentRootPath { get; }
        object EnvironmentName { get; }
    }
}