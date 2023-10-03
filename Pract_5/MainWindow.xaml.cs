using System;
using System.Windows.Controls;
using Pract_5.Pages;

namespace Pract_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private Page[] pages = new Page[]
        {
            new RoutingPage(),
            new AttacheEventsPage(),
            new TextBoxPage(),
            new ValidationInputPage()
        };
        
        private void PageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = ComboBox1.SelectedIndex;
            ContentFrame.NavigationService.Navigate(pages[index]);
        }

    }
}