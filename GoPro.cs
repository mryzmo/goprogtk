using System;
using System.Net;

namespace goprogtk
{
	public static class GoPro
	{
		public static void ExecuteURL(string url){
			WebRequest req = HttpWebRequest.Create("http://10.5.5.9/gp/"+url);
			req.Method = "GET";
			req.GetResponse ();
			req.GetResponse ().Close();
		}
		public static int[] getState(){
			int[] state = new int[31];
			WebRequest req = HttpWebRequest.Create("http://10.5.5.9/camera/se");
			req.Method = "GET";
			WebResponse res = req.GetResponse ();
			for (int i = 0; i < 31; i++) {
				state [i] = res.GetResponseStream ().ReadByte ();
			}
			return state;
			//http://10.5.5.9/gp/gpControl/status
		}
	}
}
