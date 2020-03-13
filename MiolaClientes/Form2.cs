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

		public int NroFrangos { get; set; }

		public Form2()
		{
			InitializeComponent();
		}


		private void Form2_Load(object sender, EventArgs e)
		{
			var r = dataGridView1.DataSource;

			for(int i = 0; i < NroFrangos; i++)
			{
				var frango = new Frango()
				{
					Nro = (i+1).ToString()
				};
				bindingSource1.Add(frango);
			}

			dataGridView1.DataSource = bindingSource1;
			dataGridView1.Columns[0].ReadOnly = true;
			dataGridView1.Columns[0].Width = 40;
			dataGridView1.Columns[1].Width = 240;
			dataGridView1.Columns[2].Width = 240;
			dataGridView1.Columns[3].Width = 240;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Program.Screen1.Show();
			Hide();
		}

		private class Frango
		{
			public string Nro { get; set; }
			public string Cliente { get; set; }
			public string Telefone { get; set; }
			public string Obs { get; set; }
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}