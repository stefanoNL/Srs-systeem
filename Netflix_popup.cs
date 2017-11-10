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
    [Activity(Label = "Netflix_popup")]
    public class Netflix_popup : Activity
    {
        private Button terugknop2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout4);
            terugknop2 = FindViewById<Button>(Resource.Id.terugknop2);
            terugknop2.Click += delegate
            {
                StartActivity(typeof(Activity2));
            };

            // Create your application here
        }
    }
}