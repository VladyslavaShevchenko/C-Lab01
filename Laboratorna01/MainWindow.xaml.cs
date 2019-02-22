using System.Windows;
namespace Laboratorna01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var infoPanelViewModel = new InfoOfBirthDate();
            DataContext = new ViewsOfMainWindow(infoPanelViewModel);
            InfoShowGrid.DataContext = infoPanelViewModel;
        }
    }
}