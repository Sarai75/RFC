/* 
 * Created by SharpDevelop.
 * User: CC2_PC30
 * Date: 23/10/2024
 * Time: 07:17 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace csharp
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
            //añadiremos los semestres al comboBox
            comboBoxsemes.Items.AddRange(new string[]
            {
                 "1er Semestre",
                 "2do Semestre",
                 "3ro Semestre",
                 "4to Semestre",
                 "5to Semestre",
                 "6to Semestre"
            });
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        
        //Aqui se limpiaran los datos que estan en los txt, comboBox.
        void BtnLimpiarClick(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido1.Clear();
            txtapellido2.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            comboBoxsemes.Text="";    
            dtpfnacimiento.Format = DateTimePickerFormat.Custom;
            dtpfnacimiento.CustomFormat = " ";            
        }
        
        
        void BtncalcularClick(object sender, EventArgs e)
        {
        	// Obtiene el nombre y verifica que no esté vacío.
            string nombre = txtnombre.Text.Trim().ToUpper();            
            if (nombre == null || nombre.Trim() == "") 
	            {
	                MessageBox.Show("Debes llenar el campo de Nombre");
	            }
            else
            {
            	 // Obtiene el primer apellido y verifica que no esté vacío.
            	string apellido1 = txtapellido1.Text.Trim().ToUpper();
            if (apellido1 == null || apellido1.Trim() == "") 
            	{
                	MessageBox.Show("Debes llenar el campo de Primer apellido");
            	}
            else
            	{
            		// Crea el RFC a partir de los datos ingresados.
            		string apellido2 = txtapellido2.Text.Trim().ToUpper();
            		if (apellido2 == null || apellido2.Trim() == "") 
	            	{
	                	MessageBox.Show("Debes llenar el campo de Segundo apellido");
	            	}
            
			            // Obtiene otros datos ingresados.
			            string telefono=txttelefono.Text;
			            string direccion=txtdireccion.Text;
			            string semestre=comboBoxsemes.SelectedItem.ToString();
			            DateTime fechaNacimiento=dtpfnacimiento.Value;
			            
			            // Genera un número aleatorio para el RFC
			            Random random = new Random();
			            string h =random.Next(100000, 999999).ToString("D6");
		             	
			            // Crea el RFC a partir de los datos ingresados
			            string rfc = apellido1.Substring(0, 2) + apellido2.Substring(0, 1) + nombre.Substring(0, 1) +
			            fechaNacimiento.ToString("yyMMdd")+h.Substring(0,3);
		            	
			            // Muestra el RFC en el label
		            	lblRFC.Text = "RFC: " + rfc;
            	}
            } 
        }
    }
}      
