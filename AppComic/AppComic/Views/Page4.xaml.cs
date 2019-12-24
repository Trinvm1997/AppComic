﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppComic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        async void ButtonBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void ButtonChapter1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page5());
        }
    }
}