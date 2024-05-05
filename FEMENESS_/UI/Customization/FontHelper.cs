using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEMENESS_.UI.Customization
{
    public  class FontHelper
    {
        public  void ApplyCustomFont(Control control, string fontFolderPath, string fontFileName, float fontSize)
        {
            try
            {
                // Combine the font folder path and font file name to create the full font path
                string fontPath = Path.Combine(fontFolderPath, fontFileName);

                // Load the font file
                PrivateFontCollection privateFonts = new PrivateFontCollection();
                privateFonts.AddFontFile(fontPath);

                // Create a font from the loaded font file
                Font customFont = new Font(privateFonts.Families[0], fontSize);

                // Set the custom font for the control
                control.Font = customFont;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading custom font: " + ex.Message);
                // You can choose to throw the exception here or handle it based on your application's requirements
            }
        }
    }
}