using System;
using System.Diagnostics;
using Gtk;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;


public partial class MainWindow: Gtk.Window
{
	string lastfilename="nope";
	bool recording = false;
	System.Timers.Timer keepalive = new System.Timers.Timer(2500);
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


	protected void recordClick (object sender, EventArgs e)
	{
		TaskFactory t = new TaskFactory ();
		t.StartNew (() => {
			label1.Text = "Förbereder Kameran...";
			progressbar1.Fraction = 0;
			WebRequest req = HttpWebRequest.Create ("http://10.5.5.9/gp/gpControl/command/mode?p=1");
			req.Method = "GET";
			req.GetResponse ();
			req.GetResponse ().Close ();

			label1.Text = "Tar bild...";
			System.Threading.Thread.Sleep (100);
			progressbar1.Fraction = 0.1;
			req = HttpWebRequest.Create ("http://10.5.5.9/gp/gpControl/command/shutter?p=1");
			req.Method = "GET";
			req.GetResponse ();
			req.GetResponse ().Close ();
			System.Threading.Thread.Sleep (300);
			progressbar1.Fraction = 0.3;
			System.Threading.Thread.Sleep (300);
			progressbar1.Fraction = 0.6;
			label1.Text = "Sparar bilden...";
			System.Threading.Thread.Sleep (400);
			progressbar1.Fraction = 0.8;
			req = HttpWebRequest.Create ("http://10.5.5.9:8080/gp/gpMediaList");
			req.Method = "GET";
			WebResponse filelist = req.GetResponse ();
			System.IO.StreamReader sr = new System.IO.StreamReader (filelist.GetResponseStream ());
			string fileliststring = sr.ReadToEnd ();
			int lastimage = fileliststring.LastIndexOf ('J');
			lastfilename = fileliststring.Substring (lastimage - 9, 12);
			req.GetResponse ().Close ();
			progressbar1.Fraction = 0.9;
			label1.Text = "Laddar hem bilden...";


			WebClient client = new WebClient ();
			client.DownloadFile ("http://10.5.5.9:8080/videos/DCIM/100GOPRO/" + lastfilename, "lastimg.jpg");
			int wwidth; int wheight;
			this.GetSize (out wwidth,out wheight);
			Gdk.Pixbuf pixbuff = new Gdk.Pixbuf ("lastimg.jpg",wwidth,wwidth*3/4);
			image1.Pixbuf = pixbuff;
			progressbar1.Fraction = 1;
			label1.Text = lastfilename.ToString ();
		});


	}

	protected void filethere(){

	}

	protected void stopstream(object sender, EventArgs e){
		keepalive.Stop();
		WebRequest req = HttpWebRequest.Create("http://10.5.5.9/gp/gpControl/execute?p1=gpStream&c1=stop");
		req.Method = "GET";
		req.GetResponse ();
		req.GetResponse ().Close();
	}

	protected void streamclick (object sender, EventArgs e)
	{
		WebRequest req = HttpWebRequest.Create("http://10.5.5.9/gp/gpControl/execute?p1=gpStream&c1=restart");
		req.Method = "GET";
		req.GetResponse ();
		req.GetResponse ().Close();
		keepalive.Elapsed += Keepalive_Elapsed;

		Process p = new Process ();
		p.StartInfo.FileName = "ffplay";
		p.StartInfo.Arguments= "-window_title \"Lajvström från Kamera!\" -fflags nobuffer udp://:8554";
		p.Start ();
		p.EnableRaisingEvents = true;
		p.Exited+= stopstream;

		keepalive.Start();
	}

	protected void stopthing(object sender, EventArgs e){
		label1.Text = "Success!";
	}


	void Keepalive_Elapsed (object sender, System.Timers.ElapsedEventArgs e)
	{
		UdpClient udpClient = new UdpClient("10.5.5.9", 8554);
		Byte[] sendBytes = System.Text.Encoding.ASCII.GetBytes("_GPHD_:0:0:2:0.000000\n");
		udpClient.Send(sendBytes, sendBytes.Length);
	}

	protected void OnButton8Clicked (object sender, EventArgs e)
	{
		System.IO.File.Copy ("lastimg.jpg", lastfilename);
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		Window settings = new goprogtk.SettingsWindow ();
		settings.Show ();
	}
}
