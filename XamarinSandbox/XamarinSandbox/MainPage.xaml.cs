using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            //if (Device.RuntimePlatform == Device.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //} else if (Device.RuntimePlatform == Device.Android)
            //{
            //    Padding = new Thickness(0, 10, 0, 0);
            //}

            
        }
    }
}
