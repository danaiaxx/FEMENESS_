using System.Drawing;
using System.Windows.Forms;

namespace FEMENESS_.UI.Customization
{
    public  class CustomStyles
    {
        public  void ApplyButtonStyle(Button button, Color backColor, Color foreColor)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.ForeColor = foreColor;
        }

        // Event handler for TextBox GotFocus event
      

        public void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;
        }


        public bool IsValidUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username);
        }

        public bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password);
        }


        private string GetPlaceholderText(TextBox textBox)
        {
            return (string)textBox.Tag; // Placeholder text is stored in the Tag property of the TextBox
        }

    }
}
