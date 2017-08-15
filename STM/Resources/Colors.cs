using Xamarin.Forms;

namespace STM.Resources
{
	public static class Colors
	{
		/**
		 * code -> app.xaml conversion in IDE
		 * search public static Color (\w+) = Color\.FromHex\("(#\w+)"\);
		 * replace <Color x:Key="$1">$2</Color>
		 * 
		 * app.xaml -> code
		 * search <Color x:Key="([^"]+)">([^<]+)</Color>
		 * replace public static Color $1 = Color.FromHex("$2");
		 */

		public static Color PrimaryColor = Color.FromHex("#DD525B");
		public static Color PrimaryDarkColor = Color.FromHex("#DF111C");
		public static Color PrimaryLightColor = Color.FromHex("#F0AAAC");
		public static Color CommentColor = Color.FromHex("#228B22");
		public static Color SecondaryColor = Color.FromHex("#A6A6A6");
		public static Color PrimaryTextColor = Color.FromHex("#212121");
		public static Color SecondaryTextColor = Color.FromHex("#757575");
		public static Color IconColor = Color.FromHex("#FFFFFF");
		public static Color InactiveIconColor = Color.FromHex("#aaaaaa");
		public static Color DividerColor = Color.FromHex("#BDBDBD");
		public static Color WarningColor = Color.FromHex("#ff0000");
		public static Color PageBackgroundColor = Color.FromHex("#E5E5E5");

		public static Color ControlBackgroundColor = Color.FromHex(Device.OnPlatform("#ffffff", "#ff000000", "#ffffff"));
	}
}