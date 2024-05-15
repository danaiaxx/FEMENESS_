using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FEMENESS_.UI.Main.Features
{
    public partial class InsightPanel : UserControl
    {
        private UserControl insightContent;
        private Dictionary<Button, string> buttonContentMap;
        private Button activeButton;

        public InsightPanel()
        {
            InitializeComponent();
            InitializeButtonContentMap();
            SetDefaultContent();
        }

        private void InitializeButtonContentMap()
        {
            buttonContentMap = new Dictionary<Button, string>
            {
                { button1, "Why Sexual Health Matters?" },
                { button2, "Sexually Transmitted Infections (STI)" },
                { button3, "Unintended Pregnancies" },
                { button4, "Mental and Emotional Well-Being" },
                { button5, "Social and Economic Concerns" }
            };

            foreach (var button in buttonContentMap.Keys)
            {
                button.MouseEnter += Button_MouseEnter;
                button.MouseLeave += Button_MouseLeave;
            }
        }

        private void SetDefaultContent()
        {
            UserControl defaultContent = new InsightContent();
            string defaultTitle = "Default Title";
            NavigateToContent(defaultTitle, defaultContent, button1);
        }

        private void NavigateToContent(string title, UserControl content, Button activeButton)
        {
            if (insightContent != null)
            {
                Controls.Remove(insightContent);
                insightContent.Dispose();
            }

            insightContent = content as InsightContent;
            insightContent.Dock = DockStyle.Right;
            ((InsightContent)insightContent).LabelText = title;
            Controls.Add(insightContent);

            UpdateButtonColors(activeButton);
        }

        private void UpdateButtonColors(Button activeButton)
        {
            foreach (var button in buttonContentMap.Keys)
            {
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.FromArgb(245, 245, 245);
            }

            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(241, 223, 211);
                activeButton.ForeColor = Color.FromArgb(81, 80, 80);
                this.activeButton = activeButton;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.FromArgb(241, 223, 211); // Change to desired hover color
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != activeButton)
            {
                button.BackColor = Color.Transparent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl content1 = new InsightContent();
            NavigateToContent(buttonContentMap[button1], content1, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl content2 = new InsightContent();
            NavigateToContent(buttonContentMap[button2], content2, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl content3 = new InsightContent();
            NavigateToContent(buttonContentMap[button3], content3, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl content4 = new InsightContent();
            NavigateToContent(buttonContentMap[button4], content4, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControl content5 = new InsightContent();
            NavigateToContent(buttonContentMap[button5], content5, button5);
        }
    }
}
