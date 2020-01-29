using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace SecondApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main_layout);

            var toCompass = FindViewById<Button>(Resource.Id.button1);
            var toAccelerometer = FindViewById<Button>(Resource.Id.button2);
            var toBattaryInfo = FindViewById<Button>(Resource.Id.button3);

            toCompass.Click += delegate
            {
                var intent = new Intent(this, typeof(CompassActivity));
                StartActivity(intent);
            };

            toAccelerometer.Click += delegate
            {                
                var intent = new Intent(this, typeof(accelerometerActivity));                
                StartActivity(intent);
            };


            toBattaryInfo.Click += delegate
            {
                var intent = new Intent(this, typeof(BatteryInfo));
                StartActivity(intent);
            };
        }
    }
}