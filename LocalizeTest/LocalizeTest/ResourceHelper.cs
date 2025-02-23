using Windows.ApplicationModel.Resources;

namespace LocalizeTest;

class ResourceHelper
{
    private static ResourceLoader _resourceLoader = ResourceLoader.GetForViewIndependentUse();

    public static string GetString(string key)
    {
        return _resourceLoader.GetString(key);
    }
}
