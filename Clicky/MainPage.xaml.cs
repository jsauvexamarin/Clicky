using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clicky
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int _NumberOfClicks;

        private void Button_Clicked(object sender, EventArgs e)
        {
            _NumberOfClicks++;
            MyLabel.Text = String.Format("Clicked {0} times!", _NumberOfClicks);
        }
    }
}
