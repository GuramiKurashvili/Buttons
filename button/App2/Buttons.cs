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

namespace App2
{
    [Activity(Label = "Buttons")]
    class Buttons : Activity
    {

        MainActivity Number = new MainActivity();
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Buttons);


            LinearLayout ll = FindViewById<LinearLayout>(Resource.Id.ll222);

            

            for (int i = 1; i<= MainActivity.number; i++)
            {
                var button1 = new Button(this);
                button1.Text = i.ToString();
                ll.AddView(button1);
                button1.Click += delegate
                {
                    
                    Toast.MakeText(this, button1.Text, ToastLength.Short).Show();
                };
            }

        }
    }
}