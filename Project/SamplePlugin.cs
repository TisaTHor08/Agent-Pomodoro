using PluginContracts;
using System.Windows;
using System.Windows.Controls;

namespace SamplePlugin
{
    public class MyPlugin : IPlugin
    {
        public string TargetView => "MainView";

        public UIElement GetUIElement()
        {
            return new Button
            {
                Content = "Bouton ajouté par le plugin",
                Margin = new Thickness(10)
            };
        }
    }
}
