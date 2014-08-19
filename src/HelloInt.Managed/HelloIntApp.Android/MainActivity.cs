using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloIntApp
{
    [Activity(Label = "HelloIntPInvoke", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 0;
        HelloInt.HelloInt m_helloInt = new HelloInt.HelloInt();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate 
            {
                count++;
                m_helloInt.SetValue(count);
                var i = m_helloInt.GetValue();
                button.Text = string.Format("{0} clicks!", i); 
            };
        }
    }
}

