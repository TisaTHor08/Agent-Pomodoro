using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using PluginContracts;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AgentPomodoro
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string pluginsFolder;

        private bool isReduced = false;
        public bool IsReduced
        {
            get => isReduced;
            set
            {
                if (isReduced != value)
                {
                    isReduced = value;
                    OnPropertyChanged(nameof(IsReduced));
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            // Ancrage en haut à gauche de l'écran
            Left = 0;
            Top = 0;
            IsReduced = false;
            Topmost = true;

            pluginsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            if (!Directory.Exists(pluginsFolder))
                Directory.CreateDirectory(pluginsFolder);
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            IsReduced = true;
            Width = 600;
            Height = 600;
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            IsReduced = false;
            Width = 100;
            Height = 100;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void ImportPlugin_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "DLL Files (*.dll)|*.dll"
            };

            if (ofd.ShowDialog() == true)
            {
                LoadPlugin(ofd.FileName);
            }
        }

        private void LoadPlugin(string path)
        {
            try
            {
                var assembly = Assembly.LoadFrom(path);

                // Trouver les classes qui implémentent IPlugin
                var pluginTypes = assembly.GetTypes()
                    .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                foreach (var type in pluginTypes)
                {
                    var plugin = (IPlugin)Activator.CreateInstance(type);

                    // Vérifier la vue ciblée
                    if (plugin.TargetView == "MainView")
                    {
                        MainView.Children.Add(plugin.GetUIElement());
                    }
                    else
                    {
                        MessageBox.Show($"Vue '{plugin.TargetView}' introuvable pour ce plugin.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}");
            }
        }

        private void BtnImportPlugin_Click(object sender, RoutedEventArgs e)
        {
            // Sélecteur de fichier
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Fichiers DLL (*.dll)|*.dll",
                Title = "Sélectionnez un plugin"
            };

            if (ofd.ShowDialog() == true)
            {
                try
                {
                    // Copie du plugin dans le dossier Plugins
                    string destPath = Path.Combine(pluginsFolder, Path.GetFileName(ofd.FileName));
                    File.Copy(ofd.FileName, destPath, true);

                    MessageBox.Show("Plugin importé avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Charger le plugin immédiatement
                    LoadPlugin(destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'import du plugin : " + ex.Message,
                                    "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

    }
}
