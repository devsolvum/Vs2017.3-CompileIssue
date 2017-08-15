using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Caliburn.Micro;
using LightInject;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using NLog;
using NLog.Common;
using NLog.Config;
using NLog.LayoutRenderers;
using NLog.Targets;
using SQLite.Extensions;
using STM.Resources;
using Xamarin;
using Xamarin.Forms;
using LogManager = NLog.LogManager;

namespace STM
{
	public partial class App : Application, IDisposable
	{
		private static readonly NLog.ILogger Logger = LogManager.GetCurrentClassLogger();
		
		public void Dispose()
		{
			EventAggregator = null;
			ServiceContainer.Dispose();
			ServiceContainer = null;
		}

		public static IEventAggregator EventAggregator = new EventAggregator();

		public static ServiceContainer ServiceContainer = new ServiceContainer();

		protected override async void OnStart()
		{
		}

		protected override async void OnSleep()
		{
		}

		protected override async void OnResume()
		{
		}

		public App()
		{
			InitializeComponent();

			SetRootPage();
		}

		internal async void SetRootPage()
		{
			this.MainPage = new MainPage();
		}
	}
}
