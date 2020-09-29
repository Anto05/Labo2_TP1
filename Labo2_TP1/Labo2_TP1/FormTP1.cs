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

        static (int, float, float)[] mochila;
        //int--->queso, float--->cantidad en kg, float--->valor

        public FormTP1(FormPrincipal c)
        {
            InitializeComponent();
            caller = c;


            quesos.Add(new cQueso { codigo = 1, peso = 6, precio = 80 });
            quesos.Add(new cQueso { codigo = 2, peso = 2, precio = 30 });
            quesos.Add(new cQueso { codigo = 3, peso = 5, precio = 20 });
            quesos.Add(new cQueso { codigo = 4, peso = 10, precio = 20 });
            quesos.Add(new cQueso { codigo = 5, peso = 1, precio = 50 });
            quesos.Add(new cQueso { codigo = 6, peso = 7, precio = 40 });
            quesos.Add(new cQueso { codigo = 7, peso = 3, precio = 30 });
            quesos.Add(new cQueso { codigo = 8, peso = 4, precio = 10 });
            quesos.Add(new cQueso { codigo = 9, peso = 10, precio = 30 });
            quesos.Add(new cQueso { codigo = 10, peso = 7, precio = 20 });


            cQuesoBindingSource.DataSource = quesos;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Close();
        }

        private void btnGreedy_Click(object sender, EventArgs e)
        {
            //todo corregir que pasa si no hay nada ingresado en el label o si es letras 
            Algoritmo_voraz(float.Parse(txtPesoMaximo.Text));        
        }

        private void btnPD_Click(object sender, EventArgs e)
        {
            //todo imprimir mochila
            int W = int.Parse(txtPesoMaximo.Text);
            int n = quesos.Count();
            mochila =  new (int, float, float)[n];

            int i, w, j = 0;
            float[,] K = new float[n, W + 1];
            bool flag = false;

            for (i = 0; i < n; i++)
            {
                flag = false;
                for (w = 0; w <= W; w++)
                {
                    
                    if (w == 0)
                        K[i, w] = 0;
                    else if (quesos[i].peso <= w)
                    {
                        if (i == 0) 
                            K[i, w] = quesos[i].precio;
                        else
                            K[i, w] = Math.Max(K[i - 1, w], quesos[i].precio + K[i - 1, w - quesos[i].peso]);
                        if (!flag)
                        {
                            flag = true;
                            if(K[i-1, w] < quesos[i].precio + K[i-1, w - quesos[i].peso])
                            {

                                mochila[j] = (quesos[i].codigo, quesos[i].precio, quesos[i].peso);
                                j++;
                            }
                        }
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
                Console.WriteLine("\n");
            }


            string texto = "";

            float sum = mochila.Sum(s => s.Item3 * s.Item2);
            //Console.WriteLine("Mochila con valor total: {0} y peso actual: {1}", sum, peso_actual);
            texto = "cod.  Cant  Precio\n";
            for (int k = 0; k < n; k++)
            {
                texto += mochila[k].Item1.ToString() + "     " + Math.Round(mochila[k].Item2, 2).ToString() + "     " + Math.Round(mochila[k].Item3, 2).ToString() + "\n";
            }


            lblQuesos.Text = texto;

            Console.WriteLine(K[n - 1, W]);
 
        }

        private void Algoritmo_voraz(float W)
        {
            int contador = quesos.Count();
            mochila = new (int, float, float)[contador];
            //queso-valor/peso-peso
            (int, float, float)[] ordenado = new (int, float, float)[contador];
            for (int j = 0; j < contador; j++)
            {
                ordenado[j] = (quesos[j].codigo, quesos[j].precio / quesos[j].peso, quesos[j].peso);
            }
            // to array devuelve un struct KeyValuePair iterable, en este caso una tupla de 3 ele
            ordenado = ordenado.OrderByDescending(s => s.Item2).ToArray();


            //   Ordenar por relacion valor/peso en manera descendente
            //     Ir agregando a la mochila hasta que la fraccion del
            //      elemento supere la capacidad de la mochila.
            //     Tambien voy chequeando que la fraccion del elemento que voy agregando tenga
            //     mayor benefecio con respecto al siguiente entero de menor beneficio


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
            texto = "cod.  Cant  Precio\n";
            for (int k = 0; k < contador; k++)
            {
                texto += mochila[k].Item1.ToString() + "     " + Math.Round(mochila[k].Item2, 2).ToString() + "     " + Math.Round(mochila[k].Item3, 2).ToString() + "\n";
            }


            lblQuesos.Text = texto;

            //todo imprimir total value


        }
 

    }
}

     



