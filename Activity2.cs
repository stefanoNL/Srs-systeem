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
    [Activity(Label = "Home")]
    
    public class Activity2 : Activity
    {
        private Android.Widget.ImageButton openYoutubeButton;
        private Android.Widget.ImageButton openNetflixButton;
        private Android.Widget.ImageButton openZiggoGoButton;
        private Android.Widget.ImageButton openfavorietenButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout2);
            openYoutubeButton = FindViewById<Android.Widget.ImageButton>((Resource.Id.openYoutubeButton));
            openYoutubeButton.Click += delegate
            {
                StartActivity(typeof(Youtube_popup));
            };
            openNetflixButton = FindViewById<Android.Widget.ImageButton>((Resource.Id.openNetflixButton));
            openNetflixButton.Click += delegate
            {
                StartActivity(typeof(Netflix_popup));
            };
            openZiggoGoButton = FindViewById<Android.Widget.ImageButton>((Resource.Id.openZiggogoButton));
            openZiggoGoButton.Click += delegate
            {
                StartActivity(typeof(ZiggoGo_popup));
            };
            openfavorietenButton = FindViewById<Android.Widget.ImageButton>((Resource.Id.openfavorietenButton));
            openfavorietenButton.Click += delegate
            {
                StartActivity(typeof(favorietenscherm));
            };
        }
    }
}