using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class IntroductionPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public IntroductionPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            // Returning true here instead of the base call will prevent default back button
            // navigation on an android device.
            return true;
        }
    }
}
