using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiolaClientes
{
	static class Program
	{
		public static Form1 Screen1;
		public static Form2 Screen2;

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Screen1 = new Form1();
			Screen2 = new Form2();
			Application.Run(Screen1);
		}
	}
}
