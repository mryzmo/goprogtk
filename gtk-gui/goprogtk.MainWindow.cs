
// This file has been generated by the GUI designer. Do not modify.
namespace goprogtk
{
	public partial class MainWindow
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Image image1;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.ProgressBar progressbar1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Button recbutton;
		
		private global::Gtk.Button button8;
		
		private global::Gtk.Button button2;
		
		private global::Gtk.Button button1;
		
		private global::Gtk.Button button7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget goprogtk.MainWindow
			this.Name = "goprogtk.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Pfaffs Kamerakonrollprogram");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "camera", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			// Container child goprogtk.MainWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			this.vbox2.Add (this.hbox5);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox5]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.vbox2.Add (this.image1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.image1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
			w3.Position = 2;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.progressbar1 = new global::Gtk.ProgressBar ();
			this.progressbar1.Name = "progressbar1";
			this.vbox3.Add (this.progressbar1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.progressbar1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.vbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.recbutton = new global::Gtk.Button ();
			this.recbutton.CanFocus = true;
			this.recbutton.Name = "recbutton";
			this.recbutton.UseUnderline = true;
			this.recbutton.Label = global::Mono.Unix.Catalog.GetString ("Ta _bild");
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "camera", global::Gtk.IconSize.Button);
			this.recbutton.Image = w6;
			this.hbox3.Add (this.recbutton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.recbutton]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button8 = new global::Gtk.Button ();
			this.button8.CanFocus = true;
			this.button8.Name = "button8";
			this.button8.UseUnderline = true;
			this.button8.Label = global::Mono.Unix.Catalog.GetString ("_Spara bilden");
			global::Gtk.Image w8 = new global::Gtk.Image ();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.button8.Image = w8;
			this.hbox3.Add (this.button8);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button8]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.hbox3.Add (this.button2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button2]));
			w10.Position = 8;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("Inställningar");
			global::Gtk.Image w11 = new global::Gtk.Image ();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Menu);
			this.button1.Image = w11;
			this.hbox3.Add (this.button1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button1]));
			w12.Position = 9;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button7 = new global::Gtk.Button ();
			this.button7.CanFocus = true;
			this.button7.Name = "button7";
			this.button7.UseUnderline = true;
			this.button7.Label = global::Mono.Unix.Catalog.GetString ("_Lajvström");
			global::Gtk.Image w13 = new global::Gtk.Image ();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_video-conferencing", global::Gtk.IconSize.Menu);
			this.button7.Image = w13;
			this.hbox3.Add (this.button7);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button7]));
			w14.PackType = ((global::Gtk.PackType)(1));
			w14.Position = 10;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox3]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 569;
			this.DefaultHeight = 508;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.recbutton.Clicked += new global::System.EventHandler (this.recordClick);
			this.button8.Clicked += new global::System.EventHandler (this.OnButton8Clicked);
			this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
			this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
			this.button7.Clicked += new global::System.EventHandler (this.streamclick);
		}
	}
}
