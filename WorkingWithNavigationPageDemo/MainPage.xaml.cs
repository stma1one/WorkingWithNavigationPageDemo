using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithNavigationPageDemo
{
    /// <summary>
    /// MainPage is called from the App class within a NavigationPage (see App.cs)
    /// MainPage has a button when pressed uses the Navigation property to Push the the stack a SubPage which displays.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubPage(), true);
            
                      
        }
        protected override void OnDisappearing()
        {
           
        }


    }
}
