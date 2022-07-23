using System.Configuration;

namespace TissueViewer
{
    internal static class ConfigurationHelper
    {
        private static Configuration _Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        /// <summary>
        /// Gets app settings
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetAppSetting(string name)
        {
            return _Configuration.AppSettings.Settings[name].Value;
        }

        /// <summary>
        /// Sets app settings
        /// </summary>
        /// <param name="name"></param>
        /// <param name="val"></param>
        public static void SetAppSetting(string name, string val)
        {
            _Configuration.AppSettings.Settings[name].Value = val;
            _Configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
