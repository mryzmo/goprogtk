using System;

namespace goprogtk
{
	public partial class SettingsWindow : Gtk.Window
	{
		public SettingsWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

