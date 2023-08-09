using Life_The_Game.Views.Controls;
using System.Windows;
using System.Windows.Input;


namespace Life_The_Game.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (WindowState == WindowState.Maximized
                    || SystemParameters.WorkArea.Height - 1 - this.ActualHeight < 1 
                    || SystemParameters.WorkArea.Width - this.ActualWidth < 1)
                {
                    WindowState = WindowState.Normal;
                    Height = 800;
                    Width = 1000;
                }
                else
                {
                    Left = 0;
                    Top = 0;
                    Height = SystemParameters.WorkArea.Height - 1;
                    Width = SystemParameters.WorkArea.Width;
                }
            }

            if (e.ChangedButton == MouseButton.Left)
            {
                try
                {
                    this.DragMove();
                }
                catch { }
            }
        }
    }
}
