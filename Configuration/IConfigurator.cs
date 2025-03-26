namespace Configuration;

public interface IConfigurator
{
    TValue Get<TValue>(string key);
    void Set<TValue>(string key, TValue value);
}