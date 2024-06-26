using Microsoft.Extensions.Configuration;

namespace ExtensionMethod.Library
{
    public static class ConfigurationExtension
    {
        public static bool IsLoaded(this IConfiguration config)
        {
            return config != null && config.AsEnumerable().Any();
        }
    }
}
