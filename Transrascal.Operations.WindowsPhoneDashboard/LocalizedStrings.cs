using Transrascal.Operations.WindowsPhoneDashboard.Resources;

namespace Transrascal.Operations.WindowsPhoneDashboard
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}