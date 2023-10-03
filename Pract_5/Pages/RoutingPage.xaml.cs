using System.Windows.Controls;
using System.Windows.Input;

namespace Pract_5.Pages
{
    public partial class RoutingPage : Page
    {
        public RoutingPage()
        {
            InitializeComponent();
        }
        
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlockTop.Text += "Вызвано элементом: " + sender.ToString() + "\n";
            TextBlockTop.Text += "Источник события: " + e.Source.ToString() + "\n\n";
        }
        
        private void Control_MouseDownPreview(object sender, MouseButtonEventArgs e)
        {
            TextBlockBottom.Text += "Вызвано элементом: " + sender.ToString() + "\n";
            TextBlockBottom.Text += "Источник события: " + e.Source.ToString() + "\n\n";
        }
    }
}