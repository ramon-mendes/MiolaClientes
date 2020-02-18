using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiolaClientes
{
	public partial class Form2 : Form
	{
		private BindingSource bindingSource1 = new BindingSource();

		public Form2()
		{
			InitializeComponent();

			var r = dataGridView1.DataSource;

			for(int i = 0; i < 40; i++)
			{
				bindingSource1.Add(new Frango());
			}

			dataGridView1.DataSource = bindingSource1;
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

		private class Frango
		{
			public string Nro { get; set; };
			public string Cliente { get; set; }
			public string Telefone { get; set; }
			public string Obs { get; set; }
		}
	}
}