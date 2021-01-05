using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Press4Color
{
    public partial class MainPage : ContentPage
    {
        private readonly Random rnd = new Random();
        private int color = 2;
        
        public MainPage()
        {
            InitializeComponent();
        }
        private void PressMeButton_Pressed(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int new_color = rnd.Next(1, 8);
            while (new_color == color)
            {
                new_color = rnd.Next(1, 8);
            }
            color = new_color;
            switch (color)
            {
                case 1:
                    button.BackgroundColor = Xamarin.Forms.Color.Aqua;
                    break;
                case 2:
                    button.BackgroundColor = Xamarin.Forms.Color.Red;
                    break;
                case 3:
                    button.BackgroundColor = Xamarin.Forms.Color.Green;
                    break;
                case 4:
                    button.BackgroundColor = Xamarin.Forms.Color.Blue;
                    break;
                case 5:
                    button.BackgroundColor = Xamarin.Forms.Color.Yellow;
                    break;
                case 6:
                    button.BackgroundColor = Xamarin.Forms.Color.Violet;
                    break;
                case 7:
                    button.BackgroundColor = Xamarin.Forms.Color.Cyan;
                    break;
                case 8:
                    button.BackgroundColor = Xamarin.Forms.Color.Brown;
                    break;
                default:
                    color = 0;
                    button.BackgroundColor = Xamarin.Forms.Color.White;
                    break;
            }
        }
    }
}
