/*
 * Created by Limon250
 * User: Limon250
 * Date: 28.12.2020
 * Time: 0:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tabular_trigonometric_values
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//
		// Exit
		//
		private void Button69Click(object Sender, EventArgs e)
		{
			Application.Exit();
		}
		//
		// Clear
		//
		private void Button70Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}
		//
		// Sin
		//
		private void Button1Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + 0;
		}
		private void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/2";
		}
		private void Button3Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√2/2";
		}
		private void Button4Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3/2";
		}
		private void Button5Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1";
		}
		private void Button6Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3/2";
		}
		private void Button7Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√2/2";
		}
		private void Button8Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/2";
		}
		private void Button9Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		private void Button10Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/2";
		}
		private void Button11Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√2/2";
		}
		private void Button12Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3/2";
		}
		private void Button13Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1";
		}
		private void Button14Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3/2";
		}
		private void Button15Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√2/2";
		}
		private void Button16Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/2";
		}
		private void Button17Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		//
		// Cos
		//
		private void Button34Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1";
		}
		private void Button33Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3/2";
		}
		private void Button31Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√2/2";
		}
		private void Button32Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/2";
		}
		private void Button27Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		private void Button28Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/2";
		}
		private void Button29Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√2/2";
		}
		private void Button30Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3/2";
		}
		private void Button19Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1";
		}
		private void Button20Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3/2";
		}
		private void Button21Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√2/2";
		}
		private void Button22Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/2";
		}
		private void Button23Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		private void Button24Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/2";
		}
		private void Button25Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√2/2";
		}
		private void Button26Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3/2";
		}
		private void Button18Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1";
		}
		//
		// tan
		//
		private void Button51Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		private void Button50Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/√3";
		}
		private void Button48Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1";
		}
		private void Button49Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3";
		}
		private void Button44Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "No values!";
		}
		private void Button45Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3";
		}
		private void Button46Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1";
		}
		private void Button47Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/√3";
		}
		private void Button36Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		private void Button37Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/√3";
		}
		private void Button38Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1";
		}
		private void Button39Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3";
		}
		private void Button40Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "No values!";
		}
		private void Button41Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3";
		}
		private void Button42Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1";
		}
		private void Button43Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/√3";
		}
		private void Button35Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		//
		// ctg
		//
		private void Button68Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "No values!";
		}
		private void Button67Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3";
		}
		private void Button65Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1";
		}
		private void Button66Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/√3";
		}
		private void Button61Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		private void Button62Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/√3";
		}
		private void Button63Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1";
		}
		private void Button64Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3";
		}
		private void Button53Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "No values!";
		}
		private void Button54Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "√3";
		}
		private void Button55Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text= textBox1.Text + "1";
		}
		private void Button56Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "1/√3";
		}
		private void Button57Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "0";
		}
		private void Button58Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1/√3";
		}
		private void Button59Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-1";
		}
		private void Button60Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "-√3";
		}
		private void Button52Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Text = textBox1.Text + "No values!";
		}
		//
		// LinkLabel
		//
		private void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/Limon250");
		}
	}
}
