using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App229
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //If you don't trigger the event by click button, you can call the method here
            //the method will be called after the page's initialization

            //TimerButton_Clicked(this,new EventArgs());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //also you can call it here
            //the method will be called after the page appeared

            //TimerButton_Clicked(this, new EventArgs());

        }

        private void TimerButton_Clicked(object sender, EventArgs e)
        {
            //use this variable to count the second
            int time = 0;

            Device.StartTimer(new TimeSpan(0, 0, 0,0,200), () =>
            {
                time += 200;

                // do something every 200 milliseconds
                Device.BeginInvokeOnMainThread(() =>
                {
                    // interact with UI elements
                    TimerLabel.Text = time.ToString() + "milliseconds";

                });

                if (time >= 3000)
                {
                    return false;
                }

                return true; // runs again, or false to stop
            });
        }
    }
}
