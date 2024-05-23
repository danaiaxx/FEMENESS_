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
            string defaultTitle = "Why Sexual Health Matters?";
            NavigateToContent(defaultTitle, "According to the 2022 Philippine National Demographic and Health Survey (PNDHS), the country's family size has steadily decreased over time, with an average of 1.9 children per woman. However, 42% of surveyed married women and 59% of sexually active unmarried women continue to use no contraceptive method, highlighting a major unmet need for family planning services and education in this community.\r\n", "Sexual health is a critical component of overall well-being, comprising the physical, emotional, mental, and social components of sexual activity. Understanding the importance of sexual health is essential for promoting healthy behaviors, preventing STIs, reducing unplanned births, and fostering happy relationships for individuals, communities, and society. Here, we explore important data and insights to emphasize the importance of sexual health.\r\n", "https://psa.gov.ph/statistics/national-demographic-health-survey", defaultContent, button1);
        }

        private void NavigateToContent(string title, string text1, string text2, string link, UserControl content, Button activeButton)
        {
            if (insightContent != null)
            {
                Controls.Remove(insightContent);
                insightContent.Dispose();
            }

            insightContent = content as InsightContent;
            insightContent.Dock = DockStyle.Right;
            ((InsightContent)insightContent).LabelText = title;
            ((InsightContent)insightContent).TextboxText = text1;
            ((InsightContent)insightContent).TextboxText1 = text2;
            ((InsightContent)insightContent).LinkText = link; // Assuming you have a property in InsightContent for the link

            Controls.Add(insightContent);

            UpdateButtonColors(activeButton);
        }

          private void CloseInsightPanel()
        {
            if (insightContent != null)
            {
                Controls.Remove(insightContent);
                insightContent.Dispose();
                insightContent = null; // Set to null to indicate no active content
            }
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
            NavigateToContent("Why Sexual Health Matters?", "According to the 2022 Philippine National Demographic and Health Survey (PNDHS), the country's family size has steadily decreased over time, with an average of 1.9 children per woman. However, 42% of surveyed married women and 59% of sexually active unmarried women continue to use no contraceptive method, highlighting a major unmet need for family planning services and education in this community.\r\n", "Sexual health is a critical component of overall well-being, comprising the physical, emotional, mental, and social components of sexual activity. Understanding the importance of sexual health is essential for promoting healthy behaviors, preventing STIs, reducing unplanned births, and fostering happy relationships for individuals, communities, and society. Here, we explore important data and insights to emphasize the importance of sexual health.\r\n", "https://psa.gov.ph/statistics/national-demographic-health-survey", content1, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl content2 = new InsightContent();
            string title = buttonContentMap[button2];
            string text1 = "Sexually transmitted infections (STIs) are diseases caused by bacteria, viruses, or other microorganisms that can be transmitted through unprotected sexual contact, pregnancy, childbirth, breastfeeding, or infected blood or blood product. STIs have severe health impacts, including neurological and cardiovascular disease, infertility, ectopic pregnancy, stillbirths, and increased risk of HIV. They are associated with stigma, domestic violence, and affect quality of life. ";
            string text2 = "The most common and curable STIs are trichomonas, chlamydia, gonorrhoea, and syphilis. However, viral STIs like HIV, genital herpes simplex virus, viral hepatitis B, human papillomavirus, and human T-lymphotropic virus type 1 have limited treatment options. Condoms are effective methods to protect against STIs and HIV, and early diagnosis and screening can prevent complications and further transmission.\r\n";
            string link = "https://www.cancer.gov/publications/dictionaries/cancer-terms/def/sexually-transmitted-infection\r\n";
            NavigateToContent(title, text1, text2, link, content2, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl content3 = new InsightContent();
            string title = buttonContentMap[button3];
            string text1 = "Nearly half of all pregnancies, totalling 121 million each year throughout the world, are unintended. For the women and girls affected, the most life-altering reproductive choice—whether or not to become pregnant—is no choice at all, explains the State of World Population 2022 report, released today by UNFPA, the United Nations sexual and reproductive health agency.\r\n";
            string text2 = "The groundbreaking report, “Seeing the Unseen: The case for action in the neglected crisis of unintended pregnancy,” warns that this human rights crisis has profound consequences for societies, women and girls and global health. Over 60 per cent of unintended pregnancies end in abortion and an estimated 45 per cent of all abortions are unsafe, causing 5 – 13 per cent of all maternal deaths, thereby having a major impact on the world’s ability to reach the Sustainable Development Goals.\r\n";
            string link = "https://www.unfpa.org/press/nearly-half-all-pregnancies-are-unintended-global-crisis-says-new-unfpa-report#:~:text=Press%20Release-,Nearly%20half%20of%20all%20pregnancies%20are%20unintended%E2%80%94a%20global%20crisis,altering%20reproductive%20choice%E2%80%94...\r\n";
            NavigateToContent(title, text1, text2, link, content3, button3);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            UserControl content4 = new InsightContent();
            string title = buttonContentMap[button4];
            string text1 = "Sexual pleasure is a complex concept with varying cultural and historical interpretations. It is defined as the positive feelings induced by sexual stimuli, encompassing a wide range of sexual pleasures from soothing sensations of sensual massage to the intense feelings associated with orgasm. This vague definition is essential for future discussions and provides a foundation for understanding sexual pleasure.";
            string text2 = "Sexual pleasure is a complex experience that begins with stimulation of skin receptors in erogenous zones, such as the genitals or breasts, and ends with a positive evaluation within the brain that the sensations are both pleasurable and sexual. The brain's interpretive function is crucial in recognizing these sensations as sexually pleasurable. The sensory signals received after stimulation are not inherently pleasurable or sexual, but rather require interpretation for them to be recognized as such. This process acknowledges the profound influences of culture and context on the experience of sexual pleasure. ";
            string link = "https://blog.oup.com/2008/07/sexual_pleasure/";
            NavigateToContent(title, text1, text2, link, content4, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControl content5 = new InsightContent();
            string title = buttonContentMap[button5];
            string text1 = "Masturbation is the self-stimulation of your genitals or other sensitive areas of your body for sexual arousal or pleasure. It’s a common behavior among people of all sexes, genders and ages. Masturbation plays an important role in healthy sexual development. It’s a normal, natural way to explore your body, feel pleasure and reach the point of sexual release (orgasm).";
            string text2 = "Masturbation may involve the use of your hands, fingers, sex toys or other objects. You may touch, press, rub or massage your genitals. You may insert your fingers or a sex toy such as a vibrator into your vagina or anus. You may also use a sex toy or another object such as a pillow to stimulate your penis, vulva or clitoris.\r\n";
            string link = "https://my.clevelandclinic.org/health/articles/24332-masturbation";
            NavigateToContent(title, text1, text2, link, content5, button5);
        }

    }
}
