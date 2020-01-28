using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
 
            SetContentView(Resource.Layout.first_layout);

            var textView2 = FindViewById<TextView>(Resource.Id.textView2);

            var button = FindViewById<Button>(Resource.Id.button1);

             var textfield = FindViewById<EditText>(Resource.Id.editText2);
              var textfield2 = FindViewById<EditText>(Resource.Id.editText1);




            var value = textfield.Text;
            var value2 = textfield2.Text;
            
            button.Click += delegate
            {
                var test = int.Parse(textfield.Text) + int.Parse(textfield2.Text);
                textView2.Text = textfield2.Text + " + " + textfield.Text + " = " + test.ToString();
            };

        }
    }
}