using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Second_App.Resources;

namespace Second_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var toSecondActivityButton = FindViewById<Button>(Resource.Id.button1);
         //   var editText = FindViewById<EditText>(Resource.Id.editText1);
            toSecondActivityButton.Click += delegate
            {
         //        var text = editText.Text;
          //      Intent.PutExtra("edittextvalu", text);
                var intent = new Intent(this, typeof(SecondActivity));
                StartActivity(intent);
            };
        }
    }
}