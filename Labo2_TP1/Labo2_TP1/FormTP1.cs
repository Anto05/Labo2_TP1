using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2_TP1
{
    public partial class FormTP1 : Form
    {
        FormPrincipal caller;

        List<cQueso> quesos = new List<cQueso>();

        static (string, float, float)[] mochila; //int--->queso, float--->cantidad en kg, float--->valor

        public FormTP1(FormPrincipal c)
        {
            InitializeComponent();
            caller = c;

             //Quesos de inicializacion (Descomentar)
            quesos.Add(new cQueso { codigo = "D", peso = 10, precio = 20 });
            quesos.Add(new cQueso { codigo = "E", peso = 1, precio = 50 });
            quesos.Add(new cQueso { codigo = "F", peso = 7, precio = 40 });
            quesos.Add(new cQueso { codigo = "G", peso = 3, precio = 30 });
            quesos.Add(new cQueso { codigo = "A", peso = 6, precio = 80 });
            quesos.Add(new cQueso { codigo = "B", peso = 2, precio = 30 });
            quesos.Add(new cQueso { codigo = "C", peso = 5, precio = 20 });
            quesos.Add(new cQueso { codigo = "H", peso = 4, precio = 10 });
            quesos.Add(new cQueso { codigo = "I", peso = 10, precio = 30 });
            quesos.Add(new cQueso { codigo = "J", peso = 7, precio = 20 });
            
            cQuesoBindingSource.DataSource = quesos;

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        private void btnGreedy_Click(object sender, EventArgs e)
        {
            uint pesoaux = 0;
            if(!uint.TryParse(txtPesoMaximo.Text, out pesoaux))
            {
                MessageBox.Show("Formato de peso no valido. Por favor, ingrese un numero no decimal >= 0.",
                                "Error Formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                Algoritmo_voraz(pesoaux);
            }
        
        }

        private void btnPD_Click(object sender, EventArgs e)
        {
            uint pesoaux = 0;
            if (!uint.TryParse(txtPesoMaximo.Text, out pesoaux))
            {
                MessageBox.Show("Formato de peso no valido. Por favor, ingrese un numero no decimal >= 0.",
                                "Error Formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                Programacion_dinamica(pesoaux);
            }

        }

        private void Algoritmo_voraz(uint W)
        {
            int contador = quesos.Count();
            if (contador == 0) return;
            mochila = new (string, float, float)[contador];
            
            (string, float, float)[] ordenado = new (string, float, float)[contador]; //queso - valor/peso - peso
            int j;
            for (j = 0; j < contador; j++)
            {
                if(quesos[j].peso == 0)
                    ordenado[j] = (quesos[j].codigo, 0, quesos[j].peso); //todo check
                else
                    ordenado[j] = (quesos[j].codigo, (float)quesos[j].precio / (float)quesos[j].peso, quesos[j].peso);
            }
            // to array devuelve un struct KeyValuePair iterable, en este caso una tupla de 3 ele
            ordenado = ordenado.OrderByDescending(s => s.Item2).ToArray();

            for (j = 0; j < contador - 1; j++)
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
                if (peso_actual + ordenado[i].Item3 <= W && ordenado[i].Item3 != 0)
                {
                    fraccion++;
                    peso_actual += ordenado[i].Item3;
                }
                else if( ordenado[i].Item3 != 0)
                {
                    f_aux = (W - peso_actual) / ordenado[i].Item3;
                    peso_actual += f_aux * ordenado[i].Item3;
                    fraccion += f_aux;
                }
                mochila[i] = (ordenado[i].Item1, fraccion, ordenado[i].Item2 * ordenado[i].Item3 * fraccion);

                i++;
            }

            string texto = "cod.  Cant  Precio\n";
            float sum = mochila.Sum(s => s.Item3);
            for (j = 0; j < contador; j++)
            {
                if (mochila[j].Item2 == 0) break;
                texto += mochila[j].Item1.ToString() + "     " + Math.Round(mochila[j].Item2, 2).ToString() + "     " + Math.Round(mochila[j].Item3, 2).ToString() + "\n";
            }

            lblQuesos.Text = texto;
            lblPrecio.Text = "\nPRECIO TOTAL: $" + Math.Round(sum,2) + "\n Capacidad a completar: " +(W - peso_actual) + "kg";
        }

        private void Programacion_dinamica(uint W)
        {
            int n = quesos.Count();
            if (n == 0) return;
            mochila = new (string, float, float)[n];

            int i,j = 0;
            uint w;
            float[,] K = new float[n, W + 1];

            for (i = 0; i < n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (w == 0)
                        K[i, w] = 0;
                    else if (quesos[i].peso <= 0)
                        continue;
                    else if (quesos[i].peso <= w)
                    {
                        if (i == 0)
                            K[i, w] = quesos[i].precio;
                        else
                            K[i, w] = Math.Max(K[i - 1, w], quesos[i].precio + K[i - 1, w - quesos[i].peso]);
                    }
                    else
                    {
                        if (i == 0)
                            K[i, w] = 0;
                        else
                            K[i, w] = K[i - 1, w];
                    }
                    Console.Write(K[i, w] + " ");
                }
                Console.Write("\n");
            }

            if (n == 1 && quesos[0].peso <= W)
            {//todo check
                w = (uint)(W - quesos[0].peso);
                mochila[0] = (quesos[0].codigo, quesos[0].peso, quesos[0].precio);
            }
            else
            {
                i = n - 1;
                w = W;
                while (i > 0 && w >= 0)
                {
                    if (K[i, w] != K[i - 1, w])
                    {
                        mochila[j] = (quesos[i].codigo, quesos[i].peso, quesos[i].precio);
                        w = (uint)(w - quesos[i].peso);
                        j++;
                    }
                    i = i - 1;
                    if (i == 0 && K[i, w] != 0)
                    {
                        mochila[j] = (quesos[i].codigo, quesos[i].peso, quesos[i].precio);
                        w = (uint)(w - quesos[i].peso);
                        j++;
                    }
                }
            }

            string texto = "cod.  KG  Precio\n";
            float sum = mochila.Sum(s => s.Item3);
            for (i = 0; i < j; i++)
            {
                texto += mochila[i].Item1.ToString() + "     " + Math.Round(mochila[i].Item2, 2).ToString() + "     " + Math.Round(mochila[i].Item3, 2).ToString() + "\n";
            }


            lblQuesos.Text = texto;
            lblPrecio.Text = "PRECIO TOTAL: $" + K[n - 1, W] + " \n Falta " + w + "kg para completar.";
        }


        private void precioTextBox_Validating(object sender, CancelEventArgs e)
        {
            string t = precioTextBox.Text;
            int aux = -1;
            if(!int.TryParse(t, out aux))
            {
                e.Cancel = true;
                precioTextBox.Focus();
            }
            else if(aux <= 0)
            {
                e.Cancel = true;
                precioTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
            }

        }
    }
}

     



