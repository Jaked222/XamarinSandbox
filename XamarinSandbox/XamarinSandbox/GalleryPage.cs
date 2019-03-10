using System;

using Xamarin.Forms;

namespace XamarinSandbox
{
    public class GalleryPage : ContentPage
    {
        public GalleryPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

