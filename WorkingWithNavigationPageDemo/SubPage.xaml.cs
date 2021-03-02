using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithNavigationPageDemo
{
    /// <summary>
    /// SubPage has 2 buttons - one pushes a new subpage to the stack and displays it.
    /// second button jumps to the root Navigation page of the stack.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubPage : ContentPage
    {
        public SubPage()
        {
            InitializeComponent();
            Title = "this is a Sub Page";
        }

       

        protected override void OnAppearing()
        {
            LblTxt.Text += $"\n entered Screen on {DateTime.Now.ToString()}";

        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubPage());
           
        }

        private async void BtnHome(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}