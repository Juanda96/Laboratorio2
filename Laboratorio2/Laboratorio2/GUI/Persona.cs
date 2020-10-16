using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2
{
    public partial class Persona : Form
    {
        LinkedList<Cliente> linkCl = new LinkedList<Cliente>();
        Servicio srv = new Servicio();

        public Persona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            foreach (String prov in srv.consultarProvincias())
            {
                cmbProvincias.Items.Add(prov);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in srv.consultarCantones(cmbProvincias.Text))
                {
                    cmbCantones.Items.Add(item);
                } 
            }
            catch (Exception ex)
            {

                throw new Exception("Archivo no encontrado");
            }
        }

        private void cmbCantones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in srv.consultarDistritos(cmbProvincias.Text,cmbCantones.Text))
                {
                    cmbDistritos.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Archivo no encontrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<int> numeros = new LinkedList<int>();
            foreach (string item in listTelefono.Items)
            {
                numeros.AddLast(int.Parse(item));
            }
            if (!(txtNombre.Text.Equals("")||txtApellido1.Text.Equals("")||txtApellido2.Text.Equals("")||listTelefono.Items.Count==0))
            {
                Cliente cl = new Cliente(linkCl.Count,txtNombre.Text,txtApellido1.Text,txtApellido2.Text,cmbProvincias.Text+"-"+cmbCantones.Text+"-"+cmbDistritos.Text,dtpFecha.Value,numeros,cmbEstado.Text);
                linkCl.AddLast(cl);
                dgvClientes.DataSource = linkCl.ToArray();
                
            }
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Digite un numero de telefono");
            }
            else 
            {
                listTelefono.Items.Add(txtTelefono.Text);
            }
        }
    }
}
