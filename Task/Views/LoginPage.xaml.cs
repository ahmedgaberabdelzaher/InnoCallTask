using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            // List<string> Langauge = new List<string>() { "English", "Arabic", "American" };

            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            //LangugeList.ItemsSource = Langauge;
            base.OnAppearing();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           // LangugeList.ItemsSource = Langauge;
            if (LangugeList.IsVisible)
            {
                LangugeList.IsVisible = false;
            }
            else
            {
                LangugeList.IsVisible = true;
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            LangugeList.IsVisible = false;
        }

        private void LangugeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            SelectedLangauge.Text =e.SelectedItem.ToString();
            LangugeList.IsVisible = false;
        }
    }
}