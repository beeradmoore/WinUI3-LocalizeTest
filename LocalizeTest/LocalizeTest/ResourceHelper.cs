using Microsoft.Windows.ApplicationModel.Resources;

namespace LocalizeTest;

class ResourceHelper
{
    private static ResourceManager _resourceManager = new ResourceManager();

    public static string GetString(string key)
    {
        var candidate = _resourceManager.MainResourceMap.TryGetValue($"Resources/{key}", _resourceManager.CreateResourceContext());

        return candidate.ValueAsString;
    }
}
