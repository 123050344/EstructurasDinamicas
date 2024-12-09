using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstructurasDinamicas
{
    public partial class Form1 : Form
    {
        Stack<int> pila = new Stack<int>();
        Queue<int> cola = new Queue<int>();
        LinkedList<int> listaEnlazada = new LinkedList<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPila.Text, out int numero))
            {
                pila.Push(numero);
                txtPila.Clear();
                MostrarPila();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                MostrarPila();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void btnMostrarPila_Click(object sender, EventArgs e)
        {
            MostrarPila();
        }
        private void MostrarPila()
        {
            lstPila.Items.Clear();
            foreach (var item in pila)
            {
                lstPila.Items.Add(item.ToString());
            }
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCola.Text, out int numero))
            {
                cola.Enqueue(numero);
                txtCola.Clear();
                MostrarCola();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            if (cola.Count > 0)
            {
                cola.Dequeue();
                MostrarCola();
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        private void btnMostrarCola_Click(object sender, EventArgs e)
        {
            MostrarCola();
        }
        private void MostrarCola()
        {
            lstCola.Items.Clear();
            foreach (var item in cola)
            {
                lstCola.Items.Add(item.ToString());
            }
        }

        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLista.Text, out int numero))
            {
                listaEnlazada.AddLast(numero);
                txtLista.Clear();
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.Count > 0)
            {
                listaEnlazada.RemoveFirst();
                MostrarLista();
            }
            else
            {
                MessageBox.Show("La lista está vacía.");
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }
        private void MostrarLista()
        {
            lstLista.Items.Clear();
            foreach (var item in listaEnlazada)
            {
                lstLista.Items.Add(item.ToString());
            }
        }
    }
}
