using Kingmaker.Localization;
using ModMenu.Settings;

namespace TemplateWotRModProject.Base
{
    internal class SettingsModMenu
    {
        private static readonly string RootKey = "TemplateWotRModAuthor.TemplateWotRModProject".ToLower();
        internal void Initialize()
        {
            ModMenu.ModMenu.AddSettings(
              SettingsBuilder
                .New(GetKey("title"), CreateString("title", "TemplateWotRModProject"))
            );
        }

        private static LocalizedString CreateString(string partialKey, string text)
        {
            return CreateStringInner(GetKey(partialKey, "--"), text);
        }

        private static string GetKey(string partialKey, string separator = ".")
        {
            return $"{RootKey}{separator}{partialKey}";
        }

        private static LocalizedString CreateStringInner(string key, string value)
        {
            LocalizedString result = new()
            {
                m_Key = key
            };
            LocalizationManager.CurrentPack.PutString(key, value);
            return result;
        }
    }
}
