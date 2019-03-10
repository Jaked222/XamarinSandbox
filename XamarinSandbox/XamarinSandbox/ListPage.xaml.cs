using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinSandbox.Models;

namespace XamarinSandbox
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            var names = new List<Contact>
            {
                new Contact { Name="jake", ImageUrl="http://lorempixel.com/100/100/people/1", Number="999" },
                new Contact { Name="sade", ImageUrl="http://lorempixel.com/100/100/people/2", Number="991239" },
                new Contact { Name="asdf", ImageUrl="http://lorempixel.com/100/100/people/3", Number="123457" },
            };

            listView.ItemsSource = names;
        }
    }
}
