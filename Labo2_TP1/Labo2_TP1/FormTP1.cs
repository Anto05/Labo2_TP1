using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2_TP1
{
    public partial class FormTP1 : Form
    {
        FormPrincipal caller;
        DataTable tabla;
        //todo OBJETO CLASE QUESO

        List<cQueso> quesos = new List<cQueso>();
        int i = 0;

        public FormTP1(FormPrincipal c)
        {
            InitializeComponent();
            caller = c;

            Iniciar();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }
        /*
        private void FormTP1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //caller.Close();
            //Application.Exit();

            caller.Show();
            this.Close();
        }
        */

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //todo agregar message box de confirmacion
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Peso");
            tabla.Columns.Add("Edad");

            dGQuesos.DataSource = tabla;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            i++;
            cQueso quesito = new cQueso
            {
                codigo = i,
                peso = float.Parse(txtPeso.Text),
                precio = float.Parse(txtPrecio.Text)
            };
            quesos.Add(quesito);
        }
    }
}
