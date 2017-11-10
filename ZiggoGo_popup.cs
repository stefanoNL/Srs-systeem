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
    [Activity(Label = "ZiggoGo_popup")]
    public class ZiggoGo_popup : Activity
    {
        private Button button55;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout5);
            button55 = FindViewById<Button>(Resource.Id.button55);
            button55.Click += delegate
            {
                StartActivity(typeof(Activity2));
            };

            // Create your application here
        }
    }
}