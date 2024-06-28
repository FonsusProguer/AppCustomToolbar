using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCustomToolbarProguer.Views.CustomViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomToolbalView : ContentView
    {
        public CustomToolbalView()
        {
            InitializeComponent();
        }

        private void MenuClick(object sender, EventArgs e) 
        {
            App.Current.MainPage.DisplayAlert("Mensaje", "Menu clickeado", "Ok");
        }
        private async void NavigateToBack(object sender, EventArgs e) 
        {
            await Navigation.PopAsync();
        }

        public string ToolbarTitle
        {
            get => (string)GetValue(ToolbarTitleProperty);
            set => SetValue(ToolbarTitleProperty, value);
        }

        public static readonly BindableProperty ToolbarTitleProperty = BindableProperty.Create(
            nameof(ToolbarTitle),
            typeof(string),
            typeof(CustomToolbalView),
            default(string),
            defaultBindingMode: BindingMode.OneWay);


        public bool BackButtonIsVisible
        {
            get => (bool)GetValue(BackButtonIsVisibleProperty);
            set => SetValue(BackButtonIsVisibleProperty, value);
        }

        public static readonly BindableProperty BackButtonIsVisibleProperty = BindableProperty.Create(
            nameof(BackButtonIsVisible),
            typeof(bool),
            typeof(CustomToolbalView), 
            default(bool),
            defaultBindingMode: BindingMode.OneWay);

    }



}