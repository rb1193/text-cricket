public interface IConfigManager
{
    string Get(string key);

    void Set(string key, string value);
}