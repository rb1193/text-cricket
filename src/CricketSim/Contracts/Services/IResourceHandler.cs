public interface IResourceHandler
{
    string Locale { get; set; }

    string Root { get; set; }
    
    string Get(string key);
}