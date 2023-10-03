using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace Pract_5.Pages
{
    public partial class ValidationInputPage : Page
    {
        public ValidationInputPage()
        {
            InitializeComponent();
        }

       private void Name_txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsLetter(symbol)))
            {
                e.Handled = true;
            }
        }

        private void ID_txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
        }

        private void ID_txt_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void ID_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ID_txt.Text.StartsWith("0"))
            {
                ID_txt.Text = ID_txt.Text.TrimStart('0');
            }
        }

        private void Age_txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
            try
            {
                int number = Convert.ToInt16(Age_txt.Text);
                if (number > 10)
                {
                    e.Handled = true;
                }
            }
            catch { }

        }

        private void Age_txt_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Age_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Age_txt.Text.StartsWith("0"))
            {
                Age_txt.Text = Age_txt.Text.TrimStart('0');
            }
        }

        private void Phone_txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
        }

        private void Phone_txt_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            string text = Phone_txt.Text;
            
            if (e.Key != Key.D8 && text.Length == 0 || e.Key == Key.Space || text.Length > 10 )
            {
                if (e.Key != Key.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void Phone_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}