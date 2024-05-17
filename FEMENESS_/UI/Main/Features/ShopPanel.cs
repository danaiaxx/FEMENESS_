using FEMENESS_.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMENESS_.UI.Main.Features
{
    public partial class ShopPanel : UserControl
    {
        private BackendService backendService;
        public ShopPanel(BackendService backendService)
        {
            this.backendService = backendService;  
            InitializeComponent();
        }

        public void initializeProducts() {


            // Product category management example
            backendService.AddProductCategory("Pregnancy Tests");
            backendService.AddProductCategory("Birth Control Pills");
            backendService.AddProductCategory("Condoms");

            backendService.AddProductToCategory("Pregnancy Tests", "First Response Early Result", "Detects pregnancy up to 6 days before missed period", 12.99);
            backendService.AddProductToCategory("Pregnancy Tests", "Clearblue Digital", "Provides digital results, over 99% accurate", 14.99);
            backendService.AddProductToCategory("Pregnancy Tests", "EPT Pregnancy Test", "Provides quick results in just 2 minutes", 9.99);
            backendService.AddProductToCategory("Pregnancy Tests", "Pregnancy Test Strips", "Affordable option for bulk testing", 8.99);
            backendService.AddProductToCategory("Pregnancy Tests", "ClinicalGuard Pregnancy Test Strips", "Highly sensitive strips, ideal for early detection", 13.99);
            backendService.AddProductToCategory("Pregnancy Tests", "Wondfo Pregnancy Test Strips", "Fast and reliable results, suitable for home use", 11.99);

            backendService.AddProductToCategory("Birth Control Pills", "Ortho Tri-Cyclen", "Triphasic birth control pill", 20.99);
            backendService.AddProductToCategory("Birth Control Pills", "Yaz", "Combination pill, reduces acne and bloating", 22.99);
            backendService.AddProductToCategory("Birth Control Pills", "Lo Loestrin Fe", "Low-dose combination pill, reduces menstrual bleeding", 19.99);
            backendService.AddProductToCategory("Birth Control Pills", "NuvaRing", "Vaginal ring, easy to use and highly effective", 21.99);
            backendService.AddProductToCategory("Birth Control Pills", "Depo-Provera", "Injectable birth control, provides long-term protection", 23.99);
            backendService.AddProductToCategory("Birth Control Pills", "Implanon", "Implantable rod, lasts up to 3 years", 24.99);

            backendService.AddProductToCategory("Condoms", "Trojan Magnum", "Large-sized condom", 5.99);
            backendService.AddProductToCategory("Condoms", "Durex Extra Sensitive", "Thin condom for heightened sensation", 6.99);
            backendService.AddProductToCategory("Condoms", "Lifestyles Skyn Elite", "Non-latex condom made from polyisoprene, suitable for latex allergies", 4.99);
            backendService.AddProductToCategory("Condoms", "ONE Pleasure Plus", "Ribbed and contoured for enhanced pleasure", 7.99);
            backendService.AddProductToCategory("Condoms", "Kimono MicroThin", "Ultra-thin condom for a natural feel", 8.99);
            backendService.AddProductToCategory("Condoms", "Beyond Seven", "Japanese condom with a silky, smooth texture", 9.99);


        }

    }
}
