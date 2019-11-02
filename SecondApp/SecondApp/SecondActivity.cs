using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Essentials;
using System;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace SecondApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class SecondActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);
            var text = Intent.GetStringExtra("editextvalue");

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = text;

            // XAMARIN osa

            var appName = AppInfo.Name;
            var packageName = AppInfo.PackageName;
            var version = AppInfo.VersionString;
            var build = AppInfo.BuildString;

            AppInfo.ShowSettingsUI();

            //var duration = TimeSpan.FromSeconds(10);
            //Vibration.Vibrate();
            //await NavigateToBuilding();

            //var vibrator = (Vibrator)this.GetSystemService(Context.VibrationService);
            //vibrator.Vibrate(VibrationEffect);
        }

        //public async Task NavigateToBuilding()
        //{
        //    var location = new Location(47.625253, -122.123455);
        //    var options = new MapLaunchOptions();
        //    await Map.OpenAsync(location, options);


        //}
    }
}