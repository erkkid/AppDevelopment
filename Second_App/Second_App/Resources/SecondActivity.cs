﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Second_App.Resources
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //var text = Intent.GetStringExtra("editextvalue");

            //var textView = FindViewById<TextView>(Resource.Id.textView1);
   //         textView.Text = text;
            // Create your application here
        }
    }
}