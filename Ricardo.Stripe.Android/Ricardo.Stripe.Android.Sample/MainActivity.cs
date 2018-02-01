using Android.App;
using Android.OS;

namespace Ricardo.Stripe.Android.Sample
{
    [Activity(Label = "Ricardo.Stripe.Android.Sample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

