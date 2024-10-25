/*
 * Created by SharpDevelop.
 * User: CC1_PC11
 * Date: 24/10/2024
 * Time: 12:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace csharp
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public string name;
		public Form1()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			lblname.Text=name;
		}
	}
}
