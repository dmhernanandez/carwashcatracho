﻿using CarWashCatrachoHN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarWashCatrachoHN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        private async void btnCrear_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearUsuario());
          
        }
    }
}