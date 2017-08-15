using System.Windows.Input;
using STM.Framework;
using Xamarin.Forms;

namespace STM.Resources
{
	public static class GlobalCommands
	{
		private static ICommand _toggleDrawerCommand;
        public static ICommand ToggleDrawerCommand
		{
			get { return _toggleDrawerCommand ?? (_toggleDrawerCommand = new Command(ToggleDrawerExecute)); }
		}

		private static void ToggleDrawerExecute()
		{
			var drawerVm = Application.Current.MainPage.BindingContext as IDrawerViewModel;
			if (drawerVm != null)
			{
				drawerVm.ToggleDrawerExecute();
			}
		}
	}
}
