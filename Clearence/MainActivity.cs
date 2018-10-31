using Android.App;
using Android.OS;
using Android.Widget;
using System;

namespace Clearence
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Spinner SpinnerEngineType;
        Spinner SpinnerModelYear;

        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            SpinnerEngineType = FindViewById<Spinner>(Resource.Id.SpinnerEngineType);
            SpinnerEngineType.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(SpinnerEngineTypeItemSelected);

            SpinnerModelYear = FindViewById<Spinner>(Resource.Id.SpinnerModelYear);
            SpinnerModelYear.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(SpinnerModelYearItemSelected);

            var AdapterForSpinnerEngineType = ArrayAdapter.CreateFromResource(this, Resource.Array.ArrayEngineType, Android.Resource.Layout.SimpleSpinnerItem);
            AdapterForSpinnerEngineType.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            SpinnerEngineType.Adapter = AdapterForSpinnerEngineType;
            //SpinnerEngineType.Prompt = "Choose engine type:";

            var AdapterForSpinnerModelYear = ArrayAdapter.CreateFromResource(this, Resource.Array.ArrayModelYear, Android.Resource.Layout.SimpleSpinnerItem);
            AdapterForSpinnerModelYear.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            SpinnerModelYear.Adapter = AdapterForSpinnerModelYear;
            //SpinnerModelYear.Prompt = "Choose model year:";
        }
        private void SpinnerEngineTypeItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            Enum.GetName(typeof(EngineType), spinner.GetItemAtPosition(e.Position));
            //EngineType type = Enum.Parse(spinner.GetItemAtPosition(e.Position), Enum.GetName(typeof(EngineType), spinner.GetItemAtPosition(e.Position)));

            string toast = string.Format("SpinnerEngine{0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
        private void SpinnerModelYearItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("Selected car is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
    }
}