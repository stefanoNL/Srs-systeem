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
    [Activity(Label = "Youtube_popup")]
    public class Youtube_popup : Activity
    {
        private Button terugknop;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout3);
            terugknop = FindViewById<Button>(Resource.Id.terugknop);
            terugknop.Click += delegate
            {
                StartActivity(typeof(Activity2));
            };

            // Create your application here
        }
    }
}