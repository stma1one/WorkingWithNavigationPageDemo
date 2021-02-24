using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithNavigationPageDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubPage : ContentPage
    {
        public SubPage()
        {
            InitializeComponent();
            Title = "Sub Page";
        }

       

        protected override void OnAppearing()
        {
            LblTxt.Text += $"\n entered Screen on {DateTime.Now.ToString()}";

        }
    }
}