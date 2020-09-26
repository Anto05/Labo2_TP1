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
        //todo OBJETO CLASE QUESO

        List<cQueso> quesos = new List<cQueso>();


        static int contador = 10;
        //static int[] lista_quesos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //static float[] lista_valores = { 505, 352, 458, 220, 354, 414, 498, 545, 473, 543 };
        //static float[] lista_pesos = { 23, 26, 20, 18, 32, 27, 29, 26, 30, 27 };
        static (int, float, float)[] mochila = new (int, float, float)[contador];
        //int--->queso, float--->cantidad en kg, float--->valor

        public FormTP1(FormPrincipal c)
        {
            InitializeComponent();
            caller = c;

            cQuesoBindingSource.DataSource = quesos;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        private void btnGreedy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contador; i++)
            {
                mochila[i] = (0, 0, 0);
            }
            Algoritmo_voraz(float.Parse(txtPesoMaximo.Text));        
        }

        private void btnPD_Click(object sender, EventArgs e)
        {

        }


        private void Algoritmo_voraz(float W)
        {
            contador = quesos.Count();
            //queso-valor/peso-peso
            (int, float, float)[] ordenado = new (int, float, float)[contador];
            for (int j = 0; j < contador; j++)
            {
                ordenado[j] = (quesos[j].codigo, quesos[j].precio / quesos[j].peso, quesos[j].peso);
            }
            // to array devuelve un struct KeyValuePair iterable, en este caso una tupla de 3 ele
            ordenado = ordenado.OrderByDescending(s => s.Item2).ToArray();


            /*   Ordenar por relacion valor/peso en manera descendente
                 Ir agregando a la mochila hasta que la fraccion del
                  elemento supere la capacidad de la mochila.
                 Tambien voy chequeando que la fraccion del elemento que voy agregando tenga
                 mayor benefecio con respecto al siguiente entero de menor beneficio
            */

            for (int j = 0; j < contador - 1; j++)
            {
                if (ordenado[j].Item2 == ordenado[j + 1].Item2 && ordenado[j].Item3 > ordenado[j + 1].Item3)
                {
                    var p = ordenado[j + 1];
                    ordenado[j + 1] = ordenado[j];
                    ordenado[j] = p;
                }

            }
            float peso_actual = 0;
            float fraccion;
            int i = 0;
            float f_aux = 0;

            while (peso_actual < W && i < contador)
            {
                fraccion = 0;
                if (peso_actual + ordenado[i].Item3 <= W)
                {
                    fraccion++;
                    peso_actual += ordenado[i].Item3;
                }
                else
                {
                    f_aux = (W - peso_actual) / ordenado[i].Item3;
                    peso_actual += f_aux * ordenado[i].Item3;
                    fraccion += f_aux;
                }
                mochila[i] = (ordenado[i].Item1, fraccion, ordenado[i].Item2 * ordenado[i].Item3 * fraccion);

                i++;
            }

            string texto = "";
            
            float sum = mochila.Sum(s => s.Item3 * s.Item2);
            //Console.WriteLine("Mochila con valor total: {0} y peso actual: {1}", sum, peso_actual);
            texto = "cod.  Cantidad  Precio\n";
            for (int k = 0; k < contador; k++)
            {
                texto += mochila[k].Item1.ToString() + "      " + Math.Round(mochila[k].Item2, 2).ToString() + "   " + Math.Round(mochila[k].Item3,2).ToString() + "\n";
            }
          

            lblQuesos.Text = texto;

        }

    }
}
