/*
 * Created by SharpDevelop.
 * User: CC2_PC30
 * Date: 23/10/2024
 * Time: 07:17 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace csharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.txtapellido1 = new System.Windows.Forms.TextBox();
			this.txtapellido2 = new System.Windows.Forms.TextBox();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.comboBoxsemes = new System.Windows.Forms.ComboBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpfnacimiento = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblRFC = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(90, 12);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(199, 20);
			this.txtnombre.TabIndex = 0;
			// 
			// txtapellido1
			// 
			this.txtapellido1.Location = new System.Drawing.Point(90, 38);
			this.txtapellido1.Name = "txtapellido1";
			this.txtapellido1.Size = new System.Drawing.Size(199, 20);
			this.txtapellido1.TabIndex = 1;
			// 
			// txtapellido2
			// 
			this.txtapellido2.Location = new System.Drawing.Point(90, 64);
			this.txtapellido2.Name = "txtapellido2";
			this.txtapellido2.Size = new System.Drawing.Size(199, 20);
			this.txtapellido2.TabIndex = 2;
			// 
			// txttelefono
			// 
			this.txttelefono.Location = new System.Drawing.Point(90, 90);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(199, 20);
			this.txttelefono.TabIndex = 3;
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(90, 120);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(199, 20);
			this.txtdireccion.TabIndex = 4;
			// 
			// comboBoxsemes
			// 
			this.comboBoxsemes.FormattingEnabled = true;
			this.comboBoxsemes.Items.AddRange(new object[] {
									""});
			this.comboBoxsemes.Location = new System.Drawing.Point(90, 146);
			this.comboBoxsemes.Name = "comboBoxsemes";
			this.comboBoxsemes.Size = new System.Drawing.Size(199, 21);
			this.comboBoxsemes.TabIndex = 5;
			// 
			// btncalcular
			// 
			this.btncalcular.Location = new System.Drawing.Point(214, 278);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(75, 23);
			this.btncalcular.TabIndex = 7;
			this.btncalcular.Text = "CALCULAR";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Apellido1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Apellido2";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Telefono";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 117);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Dirección";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Semestre";
			// 
			// dtpfnacimiento
			// 
			this.dtpfnacimiento.Location = new System.Drawing.Point(89, 182);
			this.dtpfnacimiento.Name = "dtpfnacimiento";
			this.dtpfnacimiento.Size = new System.Drawing.Size(200, 20);
			this.dtpfnacimiento.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 170);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 32);
			this.label8.TabIndex = 15;
			this.label8.Text = "Fecha Nacimiento";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(129, 278);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 16;
			this.btnLimpiar.Text = "LIMPIAR\r\n\r\n";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(119, 205);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Aqui se mostrata el RFC";
			// 
			// lblRFC
			// 
			this.lblRFC.Location = new System.Drawing.Point(90, 228);
			this.lblRFC.Name = "lblRFC";
			this.lblRFC.Size = new System.Drawing.Size(199, 23);
			this.lblRFC.TabIndex = 18;
			this.lblRFC.Text = "*****";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(301, 325);
			this.Controls.Add(this.lblRFC);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dtpfnacimiento);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.comboBoxsemes);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.txtapellido2);
			this.Controls.Add(this.txtapellido1);
			this.Controls.Add(this.txtnombre);
			this.Name = "MainForm";
			this.Text = "csharp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblRFC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpfnacimiento;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.ComboBox comboBoxsemes;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.TextBox txtapellido2;
		private System.Windows.Forms.TextBox txtapellido1;
		private System.Windows.Forms.TextBox txtnombre;
	}
}
