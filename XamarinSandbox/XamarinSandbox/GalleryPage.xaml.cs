using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class GalleryPage : ContentPage
    {
        private int imageId = 1;
        private const string imageUrl = "http://lorempixel.com/1920/1080/sports/";
        public GalleryPage()
        {
            InitializeComponent();

            var imageSource = new UriImageSource { Uri = new Uri(imageUrl + imageId.ToString()) };
            image.Source = imageSource;
        }

        void Left_Clicked(object sender, System.EventArgs e)
        {
            if (this.imageId != 1)
            {
                this.imageId -= 1;
            }
            image.Source = new UriImageSource { Uri = new Uri(imageUrl + imageId.ToString()) };
        }

        void Right_Clicked(object sender, System.EventArgs e)
        {
            if (this.imageId != 10)
            {
                this.imageId += 1;
            }
            image.Source = new UriImageSource { Uri = new Uri(imageUrl + imageId.ToString()) };
        }
    }
}
