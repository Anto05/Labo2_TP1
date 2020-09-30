﻿using System;
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

        static (string, float, float)[] mochila;
        //int--->queso, float--->cantidad en kg, float--->valor

        //todo chequear los valores de entrada
        public FormTP1(FormPrincipal c)
        {
            InitializeComponent();
            caller = c;

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
                MessageBox.Show("Formato de peso no valido. Por favor, ingrese un numero no decimal >= 0!.",
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
                MessageBox.Show("Formato de peso no valido. Por favor, ingrese un numero no decimal >= 0!.",
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
            mochila = new (string, float, float)[contador];
            //queso-valor/peso-peso
            (string, float, float)[] ordenado = new (string, float, float)[contador];
            int j;
            for (j = 0; j < contador; j++)
            {
                ordenado[j] = (quesos[j].codigo, (float)quesos[j].precio / (float)quesos[j].peso, quesos[j].peso);
            }
            // to array devuelve un struct KeyValuePair iterable, en este caso una tupla de 3 ele
            ordenado = ordenado.OrderByDescending(s => s.Item2).ToArray();


            //   Ordenar por relacion valor/peso en manera descendente
            //     Ir agregando a la mochila hasta que la fraccion del
            //      elemento supere la capacidad de la mochila.


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
                if (mochila[k].Item2 == 0) break;
                texto += mochila[k].Item1.ToString() + "     " + Math.Round(mochila[k].Item2, 2).ToString() + "     " + Math.Round(mochila[k].Item3, 2).ToString() + "\n";
            }


            lblQuesos.Text = texto;
            lblPrecio.Text = "\nPRECIO TOTAL: $" + Math.Round(sum,2) + "\n Capacidad a completar: " +(W - peso_actual) + "kg";

        }

        private void Programacion_dinamica(uint W)
        {
            int n = quesos.Count();
            mochila = new (string, float, float)[n];

            int i;
            uint w;
            float[,] K = new float[n, W + 1];

            for (i = 0; i < n; i++)
            {
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

            i = n - 1;
            w = W;
            while (i > 0 && w >= 0)
            {
                
                if (K[i, w] != K[i - 1, w])
                {
                    mochila[i] = (quesos[i].codigo, quesos[i].peso, quesos[i].precio);
                    w = (uint)(w - quesos[i].peso);
                }
                i = i - 1;
                if (i == 0 && K[i, w] != 0)
                {
                    mochila[i] = (quesos[i].codigo, quesos[i].peso, quesos[i].precio);
                    w = (uint)(w - quesos[i].peso);
                }

            }


            string texto = "cod.  KG  Precio\n";
            float sum = mochila.Sum(s => s.Item3 * s.Item2);
            for (i = 0; i < n; i++)
            {
                if (mochila[i].Item2 != 0)
                    texto += mochila[i].Item1.ToString() + "     " + Math.Round(mochila[i].Item2, 2).ToString() + "     " + Math.Round(mochila[i].Item3, 2).ToString() + "\n";
            }


            lblQuesos.Text = texto;
            lblPrecio.Text = "PRECIO TOTAL: " + K[n - 1, W] + " \n Falta " + w + "kg para completar.";

            Console.WriteLine(K[n - 1, W]);
        }
    }
}

     



