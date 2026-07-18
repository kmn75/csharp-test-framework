using Newtonsoft.Json.Linq;

namespace MyTestFramework.Utils
{
    public static class ConfigReader
    {
        private static readonly JObject _config;

        static ConfigReader()
        {
            var json = File.ReadAllText("appsettings.json");
            _config = JObject.Parse(json);
        }

        public static T GetValue<T>(string key)
        {
            var token = _config[key];
            if (token == null)
            {
                throw new InvalidOperationException($"Key '{key}' not found in appsettings.json");
            }
            return token.Value<T>()!; // Оператор ! подавляет предупреждение о null
        }
    }
}