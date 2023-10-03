using System.Windows.Controls;
using System.Windows.Input;

namespace Pract_5.Pages
{
    public partial class TextBoxPage : Page
    {
        public TextBoxPage()
        {
            InitializeComponent();
        }
        
        private void EventsTextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            OutputTextBlock.Text += "TextInput\n";
        }

        private void EventsTextBox_PreviewTextInput(object sender,
            TextCompositionEventArgs e)
        {
            OutputTextBlock.Text += "PreviewTextInput\n";
            
            if (ShowPropertiesCheckBox.IsChecked == true)
            {
                OutputTextBlock.Text += $"Text: {e.Text}\n";
                OutputTextBlock.Text += $"Device: {e.Device}\n";
                OutputTextBlock.Text += $"Handled: {e.Handled}\n";
            }
        }
        
        private void EventsTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            OutputTextBlock.Text += "PreviewKeyDown\n";
        }

        private void EventsTextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            OutputTextBlock.Text += "PreviewKeyUp\n";
        }
        
    }
}