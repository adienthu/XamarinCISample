using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace XamarinCISample.Droid
{
	[Activity(Label = "XamarinCISample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			PackageInfo pinfo = PackageManager.GetPackageInfo(PackageName, 0);
			int versionNumber = pinfo.VersionCode;
			string versionName = pinfo.VersionName;

			TextView versionLabel = FindViewById<TextView>(Resource.Id.version_label);
			versionLabel.Text = versionName + " (" + versionNumber + ") - UAT";
		}
	}
}

