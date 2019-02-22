using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace App2
{
    [Activity(Label = "Buttons", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public static int number;
        Button button1;
        EditText EditText1;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            button1 = FindViewById<Button>(Resource.Id.submit);
            EditText1 = FindViewById<EditText>(Resource.Id.GetText);


            button1.Click += submit_click;

            
        }
        void submit_click(object sernder, EventArgs e)
        {


            Intent intent = new Intent(this, typeof(Buttons));

            StartActivity(intent);

            number = Convert.ToInt32(EditText1.Text);





        }
    }
}