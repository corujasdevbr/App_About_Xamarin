
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_About_Xamarin.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Layout : MasterDetailPage
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs args)
        {
            string page = ((Button)sender).Text;

            switch (page)
            {
                case "Miguel de Icaza":
                case "Joseph Hill":
                case "Nat Friedman":
                    Detail = new NavigationPage(new Pages.Perfil1() { Title = page });
                    IsPresented = false;
                    break;
                case "Sobre o Xamarin":
                    Detail = new NavigationPage(new Pages.About() { Title = "Sobre" });
                    IsPresented = false;
                    break;
            }
        }
    }
}