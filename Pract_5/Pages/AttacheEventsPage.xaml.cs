using System.Windows;
using System.Windows.Controls;

namespace Pract_5.Pages
{
    public partial class AttacheEventsPage : Page
    {
        public AttacheEventsPage()
        {
            InitializeComponent();
        }
        
        private void TextComboBox_SelectionChanged(object sender, 
            SelectionChangedEventArgs e)
        {
            var Item = TextComboBox.SelectedItem as ComboBoxItem;
            TextBlockBottom.Text += Item?.Content.ToString() + "\n";
        }
        
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var Selected = e.Source as RadioButton;
            TextBlockTop.Text += Selected.Content.ToString() + "\n";
        }

    }
}