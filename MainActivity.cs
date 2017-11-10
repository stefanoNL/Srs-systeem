using Android.App;
using Android.Widget;
using Android.OS;

namespace Srs_systeem
{
    [Activity(Label = "Srs_systeem", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button button1;
    
        
            protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                StartActivity(typeof(Activity1));
            };
        }
    }
}


