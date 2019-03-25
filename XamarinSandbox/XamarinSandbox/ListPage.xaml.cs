using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using XamarinSandbox.Models;

namespace XamarinSandbox
{
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<ContactGroup> groups;

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert(contact.Name + "was tapped!", contact.Number, "Cancel");
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert(contact.Name + "was selected!", contact.Number, "Cancel");

            // To disable selection
            // listView.SelectedItem = null;
        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert(contact.Name, contact.Number, "Ok");
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert(contact.Name, contact.Number, "Cancel");
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContactGroups(e.NewTextValue);
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContactGroups();

            listView.IsRefreshing = false;
        }

        ObservableCollection<ContactGroup> GetContactGroups(string searchText = null)
        {
            var groups = new ObservableCollection<ContactGroup>
            {
                new ContactGroup("j", "j") {
                    new Contact { Name="jake", ImageUrl="http://lorempixel.com/100/100/people/1", Number="999" },
                },
                new ContactGroup("s", "s") {
                    new Contact { Name="sadie", ImageUrl="http://lorempixel.com/100/100/people/2", Number="999" },
                },
            };

            return groups;
        }

        public ListPage()
        {
            InitializeComponent();

            groups = GetContactGroups();

            //var names = new List<Contact>
            //{
            //    new Contact { Name="sade", ImageUrl="http://lorempixel.com/100/100/people/2", Number="991239" },
            //    new Contact { Name="asdf", ImageUrl="http://lorempixel.com/100/100/people/3", Number="123457" },
            //};

            listView.ItemsSource = groups;
        }
    }
}
