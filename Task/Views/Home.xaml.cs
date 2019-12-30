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
    public partial class Home : TabbedPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnNumber_Clicked(object sender, EventArgs e)
        {
            var enteredNumber = (sender as Button).Text;
            this.PhoneNumber.Text += enteredNumber;
        }

        private void Btclear_Clicked(object sender, EventArgs e)
        {
            if (PhoneNumber.Text.Length>0)
            {
              PhoneNumber.Text=PhoneNumber.Text.Remove(PhoneNumber.Text.Length-1,1);
            }
          
        }
    }
}