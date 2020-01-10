using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppComic.Models;
using AppComic.ViewModels;

namespace AppComic.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        async void ButtonBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void PreviousButton(object sender, EventArgs e)
        {
            var item = new Item
            {
                Text = "Item 1",
                Description = "chap 1 ne"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private void NextButton(object sender, EventArgs e)
        {
            var item = new Item
            {
                Text = "Item 2",
                Description = "chap 2 ne"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}