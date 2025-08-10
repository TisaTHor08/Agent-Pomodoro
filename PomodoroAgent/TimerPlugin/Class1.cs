using PluginContracts;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TimerPlugin
{
    public class TimerPlugin : IPlugin
    {
        public string TargetView => "MainView";

        public UIElement GetUIElement()
        {
            StackPanel root = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Margin = new Thickness(10),
                HorizontalAlignment = HorizontalAlignment.Center
            };

            // --- Entrées temps ---
            StackPanel timeInputs = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            TextBox hoursBox = CreateNumberBox("0");
            TextBox minutesBox = CreateNumberBox("0");
            TextBox secondsBox = CreateNumberBox("0");

            timeInputs.Children.Add(hoursBox);
            timeInputs.Children.Add(new TextBlock { Text = " h ", VerticalAlignment = VerticalAlignment.Center });
            timeInputs.Children.Add(minutesBox);
            timeInputs.Children.Add(new TextBlock { Text = " m ", VerticalAlignment = VerticalAlignment.Center });
            timeInputs.Children.Add(secondsBox);
            timeInputs.Children.Add(new TextBlock { Text = " s ", VerticalAlignment = VerticalAlignment.Center });

            // --- Canvas pour le cercle ---
            Canvas circleCanvas = new Canvas
            {
                Width = 150,
                Height = 150
            };

            Path arcPath = new Path
            {
                Stroke = Brushes.Blue,
                StrokeThickness = 5
            };

            circleCanvas.Children.Add(arcPath);

            // --- Label du timer ---
            TextBlock countdownLabel = new TextBlock
            {
                Text = "00:00:00",
                FontSize = 18,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5)
            };

            // --- Bouton démarrer ---
            Button startButton = new Button
            {
                Content = "Démarrer",
                Margin = new Thickness(5)
            };

            // --- Timer logique ---
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            double totalSeconds = 0;
            double remainingSeconds = 0;

            startButton.Click += (s, e) =>
            {
                int h = int.TryParse(hoursBox.Text, out int hh) ? hh : 0;
                int m = int.TryParse(minutesBox.Text, out int mm) ? mm : 0;
                int sec = int.TryParse(secondsBox.Text, out int ss) ? ss : 0;

                totalSeconds = h * 3600 + m * 60 + sec;
                if (totalSeconds > 0)
                {
                    remainingSeconds = totalSeconds;
                    timer.Start();
                    UpdateCountdown();
                    DrawArc(arcPath, remainingSeconds / totalSeconds);
                }
            };

            timer.Tick += (s, e) =>
            {
                remainingSeconds--;
                if (remainingSeconds > 0)
                {
                    UpdateCountdown();
                    DrawArc(arcPath, remainingSeconds / totalSeconds);
                }
                else
                {
                    timer.Stop();
                    countdownLabel.Text = "Terminé !";
                    arcPath.Data = null; // Supprime le cercle
                }
            };

            void UpdateCountdown()
            {
                TimeSpan ts = TimeSpan.FromSeconds(remainingSeconds);
                countdownLabel.Text = ts.ToString(@"hh\:mm\:ss");
            }

            root.Children.Add(timeInputs);
            root.Children.Add(startButton);
            root.Children.Add(circleCanvas);
            root.Children.Add(countdownLabel);

            return root;
        }

        private TextBox CreateNumberBox(string defaultText)
        {
            return new TextBox
            {
                Text = defaultText,
                Width = 40,
                Margin = new Thickness(2),
                TextAlignment = TextAlignment.Center
            };
        }

        private void DrawArc(Path path, double progress)
        {
            double angle = 360 * progress;
            double radius = 70;
            double centerX = 75;
            double centerY = 75;

            double radians = (Math.PI / 180) * angle;
            double x = centerX + radius * Math.Sin(radians);
            double y = centerY - radius * Math.Cos(radians);

            bool isLargeArc = angle > 180;

            PathFigure figure = new PathFigure
            {
                StartPoint = new Point(centerX, centerY - radius)
            };

            ArcSegment arc = new ArcSegment
            {
                Point = new Point(x, y),
                Size = new Size(radius, radius),
                IsLargeArc = isLargeArc,
                SweepDirection = SweepDirection.Clockwise
            };

            figure.Segments.Add(arc);
            PathGeometry geometry = new PathGeometry();
            geometry.Figures.Add(figure);

            path.Data = geometry;
        }
    }
}
