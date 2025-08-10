using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace AgentPomodoro
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
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
    }
}
