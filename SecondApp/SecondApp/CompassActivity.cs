using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SecondApp
{
    [Activity(Label = "CompassActivity")]
    public class CompassActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.compass_layout);

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            var compButton = FindViewById<Button>(Resource.Id.button1);

            compButton.Click += delegate
            {
                Compass.ReadingChanged += Compass_ReadingChanged;
                Compass.Start(SensorSpeed.UI);
                compButton.Text = "Stop compass";

            };


            void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
            {

                var data = e.Reading;

                textView.Text = data.HeadingMagneticNorth.ToString();
          
            }
           
        }

    }
}
           
