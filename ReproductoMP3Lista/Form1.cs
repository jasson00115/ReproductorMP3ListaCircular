using ReproductoMP3Lista.clases;
using ReproductoMP3Lista.listacircularejemplo;
using ReproductoMP3Lista.ListaDoble;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductoMP3Lista
{
    public partial class Form1 : Form
    {
        Nodo1 nuevo;

        OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
        ListaOrdenada addpath = new ListaOrdenada();
        clsListaDoble Listad = new clsListaDoble();
        ListaCircular ListaC = new ListaCircular();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            CajaDeBusquedaDeArchivos.Multiselect = true; //Esto va a permitir seleccionar varios archivos al mismo tiempo

            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                for (int i = 0; i < CajaDeBusquedaDeArchivos.FileNames.Length; i++)
                {
                    Listad.insertarCabezaLista(CajaDeBusquedaDeArchivos.FileNames[i]);
                    ListaC.insertar(CajaDeBusquedaDeArchivos.FileNames[i]);
                    listBox1.Items.Add(CajaDeBusquedaDeArchivos.SafeFileNames[i]);
                }

                axWindowsMediaPlayer1.URL = CajaDeBusquedaDeArchivos.FileNames[0];
                listBox1.SelectedIndex = 0;
                int pausa;
                pausa = 0;

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                axWindowsMediaPlayer1.URL = CajaDeBusquedaDeArchivos.FileNames[listBox1.SelectedIndex];
                int index = listBox1.SelectedIndex;
                nuevo = new Nodo1(CajaDeBusquedaDeArchivos.FileNames[index]);
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;

            }
            else
            {
                recorrer();
            }

            
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void remover_Click(object sender, EventArgs e)
        {
            String elim = CajaDeBusquedaDeArchivos.FileName;

            int eliminar = listBox1.SelectedIndex; //Para tomar la posicion a eliminar

            if (listBox1.SelectedIndex != -1)
            {
                Listad.eliminar(elim);
                ListaC.eliminar(elim);
                listBox1.Items.RemoveAt(eliminar); //Para eliminar lo que este en la posicion 
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }

            int pausa;
            pausa = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            int a = ran.Next(listBox1.Items.Count - 1);
            axWindowsMediaPlayer1.URL = CajaDeBusquedaDeArchivos.FileNames[a];
            listBox1.SelectedIndex = a;

        }

        public void recorrer()
        {

            if (nuevo != null)
            {
                nuevo = ListaC.lc.enlace; // siguiente nodo al de acceso
                                                //
                while (nuevo == ListaC.lc.enlace)
                {
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                    {
                        listBox1.SelectedIndex += 1;
                        //recorrer();
                        nuevo = nuevo.enlace;
                    }
                    else
                    {

                        axWindowsMediaPlayer1.URL = CajaDeBusquedaDeArchivos.FileNames[0];
                        listBox1.SelectedIndex = 0;
                        nuevo = nuevo.enlace;
                    }

                    nuevo = nuevo.enlace;
                }
            }
            else
            {
                MessageBox.Show("\t Lista Circular vacía.");
            }
        }



    }
}
