using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp1
{
    public partial class MainPage : ContentPage
    {
        //sets the URL for the browser in the page at creation
        public MainPage(string URL)
        {
            InitializeComponent();
            Browser.Source = URL;
        }

        public MainPage(){
            
        }
    }
}
