﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarWashCatrachoHN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearUsuario : ContentPage
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private async void btnConfirmar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Validacion());
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {

        }
    }
}