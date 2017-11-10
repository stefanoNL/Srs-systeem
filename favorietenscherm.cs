using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Srs_systeem
{
    [Activity(Label = "favorietenscherm")]
    public class favorietenscherm : Activity
    {
        private Button button4;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout6);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button4.Click += delegate
            {
                StartActivity(typeof(Activity2));
            };

            // Create your application here
        }
    }
}