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


    }
}
