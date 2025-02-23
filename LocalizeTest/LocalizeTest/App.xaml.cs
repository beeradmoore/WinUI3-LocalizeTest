using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace LocalizeTest
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "fr-FR";
            //Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US";
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            var resourceManager = new Microsoft.Windows.ApplicationModel.Resources.ResourceManager();

            var test1Text = resourceManager.MainResourceMap.TryGetValue("Resources/Test1/Text", resourceManager.CreateResourceContext());
            var test2Text = resourceManager.MainResourceMap.TryGetValue("Resources/Test2/Text", resourceManager.CreateResourceContext());
            var test3Text = resourceManager.MainResourceMap.TryGetValue("Resources/Test3/Text", resourceManager.CreateResourceContext());

            Debug.WriteLine($"test1Text: {test1Text.ValueAsString}");
            Debug.WriteLine($"test2Text: {test2Text.ValueAsString}");
            Debug.WriteLine($"test3Text: {test3Text.ValueAsString}");

            m_window = new MainWindow();
            m_window.Activate();
        }

        private Window? m_window;
    }
}
