using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class WelcomePage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            // Pushing modally causes the page to come up from the bottom. 
            // The user cannot navigate away from this (assuming back button is disabled
            // in android). I believe this essentially acts as a new navigation stack.
            await Navigation.PushModalAsync(new IntroductionPage());
        }

        public WelcomePage()
        {
            InitializeComponent();
        }
    }
}
