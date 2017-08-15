using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STM.Resources
{
	public enum ImageType
	{
		Delete,
		Login,
		Logout,
		Settings,
		Save,
		User,
		UserAdd,
		UserDelete,
		UserMinus,
		Edit,
		Site,
		Wbs,
		Download,
		Upload,
		Filter,
		Attachments,
		Refresh,
		Undo,
		Redo,
		ContextMenu,
		Search,
		ChevronLeft,
		ChevronRight,
		ChevronDown,
		ChevronUp,
		PopupHorizontal,
		PopupVertical,
		ClearReflectHorizontal,
		MoreHorizontal,
		MoreVertical,
		Comment,
		Collapse,
		Expand,
		Copy,
		KeyboardHide,
		Close,
		OpenInBrowser
	}

	[ContentProperty(nameof(ImageType))]
	public class Image : IMarkupExtension
	{
		public ImageType ImageType { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			switch (ImageType)
			{
				case ImageType.Delete:
					return (FileImageSource) ImageSource.FromFile("appbar_delete.png");

				case ImageType.Login:
					return (FileImageSource) ImageSource.FromFile("appbar_door_enter.png");

				case ImageType.Logout:
					return (FileImageSource) ImageSource.FromFile("appbar_door_leave.png");

				case ImageType.Settings:
					return (FileImageSource) ImageSource.FromFile("appbar_settings.png");

				case ImageType.Save:
					return (FileImageSource) ImageSource.FromFile("appbar_save.png");

				case ImageType.User:
					return (FileImageSource) ImageSource.FromFile("appbar_user.png");

				case ImageType.UserAdd:
					return (FileImageSource) ImageSource.FromFile("appbar_user_add.png");

				case ImageType.UserDelete:
					return (FileImageSource) ImageSource.FromFile("appbar_user_delete.png");

				case ImageType.UserMinus:
					return (FileImageSource) ImageSource.FromFile("appbar_user_minus.png");

				case ImageType.Edit:
					return (FileImageSource) ImageSource.FromFile("appbar_page_edit.png");

				case ImageType.Site:
					return (FileImageSource) ImageSource.FromFile("appbar_debug_stop.png");

				case ImageType.Wbs:
					return (FileImageSource) ImageSource.FromFile("appbar_diagram.png");

				case ImageType.Download:
					return (FileImageSource) ImageSource.FromFile("appbar_download.png");

				case ImageType.Upload:
					return (FileImageSource) ImageSource.FromFile("appbar_upload.png");

				case ImageType.Filter:
					return (FileImageSource) ImageSource.FromFile("appbar_filter.png");

				case ImageType.Attachments:
					return (FileImageSource) ImageSource.FromFile("appbar_paperclip.png");

				case ImageType.Refresh:
					return (FileImageSource) ImageSource.FromFile("appbar_refresh.png");

				case ImageType.Undo:
					return (FileImageSource) ImageSource.FromFile("appbar_undo.png");

				case ImageType.Redo:
					return (FileImageSource) ImageSource.FromFile("appbar_diagram.png");

				case ImageType.ContextMenu:
					return (FileImageSource) ImageSource.FromFile("appbar_lines_horizontal_4.png");

				case ImageType.Search:
					return (FileImageSource) ImageSource.FromFile("appbar_magnify.png");

				case ImageType.ChevronLeft:
					return (FileImageSource) ImageSource.FromFile("appbar_chevron_left.png");

				case ImageType.ChevronRight:
					return (FileImageSource) ImageSource.FromFile("appbar_chevron_right.png");

				case ImageType.ChevronDown:
					return (FileImageSource) ImageSource.FromFile("appbar_chevron_down.png");

				case ImageType.ChevronUp:
					return (FileImageSource) ImageSource.FromFile("appbar_chevron_up.png");

				case ImageType.PopupHorizontal:
					return (FileImageSource) ImageSource.FromFile("appbar_PopupMenu_Horizontal.png");

				case ImageType.PopupVertical:
					return (FileImageSource) ImageSource.FromFile("appbar_PopupMenu_Vertical.png");

				case ImageType.ClearReflectHorizontal:
					return (FileImageSource) ImageSource.FromFile("appbar_clear_reflect_horizontal.png");

				case ImageType.MoreHorizontal:
					return (FileImageSource) ImageSource.FromFile("ic_more_horiz_white_36pt.png");

				case ImageType.MoreVertical:
					return (FileImageSource) ImageSource.FromFile("ic_more_vert_white_36pt.png");

				case ImageType.Comment:
					return (FileImageSource) ImageSource.FromFile("ic_insert_comment_white.png");

				case ImageType.Collapse:
					return (FileImageSource) ImageSource.FromFile("ic_expand_less_white.png");

				case ImageType.Expand:
					return (FileImageSource) ImageSource.FromFile("ic_expand_more_white.png");

				case ImageType.Copy:
					return (FileImageSource)ImageSource.FromFile("appbar.page.copy.png");

				case ImageType.KeyboardHide:
					return (FileImageSource)ImageSource.FromFile("ic_keyboard_hide_white.png");

				case ImageType.Close:
					return (FileImageSource)ImageSource.FromFile("ic_close_white.png");

				case ImageType.OpenInBrowser:
					return (FileImageSource)ImageSource.FromFile("ic_open_in_browser.png");
			}

			return null;
		}
	}

	/**
	    Nützliche Docs:
	        http://forums.xamarin.com/discussion/26511/adding-png-to-resources-drawable-hangs-visual-studio
	        https://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/images/
	        https://developer.xamarin.com/guides/ios/user_interface/controls/part_5_-_images/
	    */

	public static class Images
	{
		public static class Theme
		{
			public static class Dark
			{
				public static readonly FileImageSource Delete = (FileImageSource) ImageSource.FromFile("appbar_delete.png");

				public static readonly FileImageSource Login = (FileImageSource) ImageSource.FromFile("appbar_door_enter.png");

				public static readonly FileImageSource Logout = (FileImageSource) ImageSource.FromFile("appbar_door_leave.png");

				public static readonly FileImageSource Settings = (FileImageSource) ImageSource.FromFile("appbar_settings.png");

				public static readonly FileImageSource Save = (FileImageSource) ImageSource.FromFile("appbar_save.png");

				public static readonly FileImageSource User = (FileImageSource) ImageSource.FromFile("appbar_user.png");

				public static readonly FileImageSource UserAdd = (FileImageSource) ImageSource.FromFile("appbar_user_add.png");

				public static readonly FileImageSource UserDelete = (FileImageSource) ImageSource.FromFile("appbar_user_delete.png");

				public static readonly FileImageSource UserMinus = (FileImageSource) ImageSource.FromFile("appbar_user_minus.png");

				public static readonly FileImageSource Edit = (FileImageSource) ImageSource.FromFile("appbar_page_edit.png");

				public static readonly FileImageSource Site = (FileImageSource) ImageSource.FromFile("appbar_debug_stop.png");

				public static readonly FileImageSource Wbs = (FileImageSource) ImageSource.FromFile("appbar_diagram.png");

				public static readonly FileImageSource Download = (FileImageSource) ImageSource.FromFile("appbar_download.png");

				public static readonly FileImageSource Upload = (FileImageSource) ImageSource.FromFile("appbar_upload.png");

				public static readonly FileImageSource Filter = (FileImageSource) ImageSource.FromFile("appbar_filter.png");

				public static readonly FileImageSource Attachments = (FileImageSource) ImageSource.FromFile("appbar_paperclip.png");

				public static readonly FileImageSource Refresh = (FileImageSource) ImageSource.FromFile("appbar_refresh.png");

				public static readonly FileImageSource Undo = (FileImageSource) ImageSource.FromFile("appbar_undo.png");

				public static readonly FileImageSource Redo = (FileImageSource) ImageSource.FromFile("appbar_diagram.png");

				public static readonly FileImageSource ContextMenu = (FileImageSource) ImageSource.FromFile("appbar_lines_horizontal_4.png");

				public static readonly FileImageSource Search = (FileImageSource) ImageSource.FromFile("appbar_magnify.png");

				public static readonly FileImageSource ChevronLeft = (FileImageSource) ImageSource.FromFile("appbar_chevron_left.png");

				public static readonly FileImageSource ChevronRight = (FileImageSource) ImageSource.FromFile("appbar_chevron_right.png");

				public static readonly FileImageSource ChevronDown = (FileImageSource) ImageSource.FromFile("appbar_chevron_down.png");

				public static readonly FileImageSource ChevronUp = (FileImageSource) ImageSource.FromFile("appbar_chevron_up.png");

				public static readonly FileImageSource PopupHorizontal = (FileImageSource) ImageSource.FromFile("appbar_PopupMenu_Horizontal.png");

				public static readonly FileImageSource PopupVertical = (FileImageSource) ImageSource.FromFile("appbar_PopupMenu_Vertical.png");

				public static readonly FileImageSource ClearReflectHorizontal = (FileImageSource) ImageSource.FromFile("appbar_clear_reflect_horizontal.png");

				public static readonly FileImageSource MoreHorizontal = (FileImageSource) ImageSource.FromFile("ic_more_horiz_white_36pt.png");

				public static readonly FileImageSource MoreVertical = (FileImageSource) ImageSource.FromFile("ic_more_vert_white_36pt.png");

				public static readonly FileImageSource Comment = (FileImageSource) ImageSource.FromFile("ic_insert_comment_white.png");

				public static readonly FileImageSource Expand = (FileImageSource) ImageSource.FromFile("ic_expand_more_white.png");

				public static readonly FileImageSource Collapse = (FileImageSource) ImageSource.FromFile("ic_expand_less_white.png");

				public static readonly FileImageSource Copy = (FileImageSource) ImageSource.FromFile("appbar.page.copy.png");

				public static readonly FileImageSource KeyboardHide = (FileImageSource) ImageSource.FromFile("ic_keyboard_hide_white.png");

				public static readonly FileImageSource Close = (FileImageSource) ImageSource.FromFile("ic_close_white.png");

				public static readonly FileImageSource OpenInBrowser = (FileImageSource) ImageSource.FromFile("ic_open_in_browser.png");
			}
		}
	}
}