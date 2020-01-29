using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Essentials;

namespace SecondApp
{
    [Activity(Label = "acceleormeter_activity")]
    public partial class accelerometerActivity : Activity
    {
      
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.accelerometer_layout);
           

            var textViewX = FindViewById<TextView>(Resource.Id.textViewx);
            var textViewY = FindViewById<TextView>(Resource.Id.textViewy);
            var textViewC = FindViewById<TextView>(Resource.Id.textViewz);
            var accelerButton = FindViewById<TextView>(Resource.Id.button1);


            if (!Accelerometer.IsMonitoring)
            {
                accelerButton.Click += delegate
                {
                    Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
                    Accelerometer.Start(SensorSpeed.UI);
                    accelerButton.Text = "Stop Accelerometer";
                };
                return;
            }
            if (Accelerometer.IsMonitoring)
            {
                accelerButton.Click += delegate
                {
                    Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
                    Accelerometer.Stop();
                    accelerButton.Text = "Start Accelerometer";
                };
                return;
            }


            void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
            {
                var data = e.Reading;
                textViewX.Text = data.Acceleration.X.ToString();
                textViewY.Text = data.Acceleration.Y.ToString();
                textViewC.Text = data.Acceleration.Z.ToString();
                
            }
            

        }


    }
    
}


