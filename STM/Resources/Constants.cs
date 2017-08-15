using System;

namespace STM.Resources
{
	public static class Constants
	{
		public static readonly DateTime MinDate = new DateTime(1900, 1, 1, 0, 0, 0);
		public static readonly DateTime MaxDate = new DateTime(2079, 6, 6, 23, 59, 0);

		public static double IntMax = int.MaxValue;
		public static double IntMin = int.MinValue;

		public static string RegexPatternFloat => @"^-?[\d]*?[,.]{0,1}[\d]*?$";

		public static string RegexPatternInt => @"^-?[\d]*?$";

		public const string ResolutionGroupName = "SOlvum.SiteTracker.Mobile.XamarinForms";

		public static class ApplicationPropertyKeys
		{
			public const string TracingEnabled = "TracingEnabled";
			public const string FailedRestoreAttempts = "FailedRestoreAttempts";
		}

		public static class Effects
		{
		}
	}
}
