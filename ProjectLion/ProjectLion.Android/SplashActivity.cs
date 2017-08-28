using Android.App;
using Android.OS;
using Android.Widget;
using Java.Lang;
using System.Threading;

namespace ProjectLion.Droid
{
    [Activity(Theme = "@style/Theme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //System.Threading.Thread.Sleep(30);

            ProgressDialog dialog = new ProgressDialog(this); // this = YourActivity
            dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            dialog.SetMessage("Cargando datos");
            dialog.SetCanceledOnTouchOutside(false);

            dialog.Show();

            Runnable progressRunnable = new Runnable(delegate { StartActivity(typeof(MainActivity)); });

            Handler pdCanceller = new Handler();
            pdCanceller.PostDelayed(progressRunnable, 6000);
                       
        }

    }
}