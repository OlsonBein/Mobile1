using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileLab1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (header != null)
            {
                header.Text = ((Int32)e.NewValue).ToString();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            fullName.Text = $"{nameEntry.Text} is {header.Text}";
        }
    }
}
