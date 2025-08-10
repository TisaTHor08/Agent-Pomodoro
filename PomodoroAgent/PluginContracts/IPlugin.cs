
using System.Windows; // pour UIElement et Thickness

namespace PluginContracts
{

    public interface IPlugin
    {
        string TargetView { get; } // Nom de la vue cible
        UIElement GetUIElement(); // Élement à afficher dans la vue
    }
}
