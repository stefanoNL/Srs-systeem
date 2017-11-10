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
    [Activity(Label = "Inlogscherm")]
    public class Activity1 : Activity
    {
        private Button button2;
        
        protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);

            // Create your application here 
                SetContentView(Resource.Layout.layout1);
            button2 = FindViewById<Button>(Resource.Id.button1);
            button2.Click += delegate
            {
                StartActivity(typeof(Activity2));
            };
           
        }
        
    
        
    }
}