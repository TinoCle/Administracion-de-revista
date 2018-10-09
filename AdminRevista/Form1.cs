using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRevista
{
    public partial class Form1 : Form
    {
        Revista revista = new Revista();
        public Form1()
        {
            InitializeComponent();
            txtFecha.Text = revista.Fecha;
            txtCdadArt.Text = "0";
            txtCdadTotalPal.Text = "0";
        }

        private bool CamposVacios()
        {
            bool bandera = false;
            foreach(Control c in groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    if (((TextBox)c).Text == "")
                    {
                        bandera = true;
                    }
                }
            }
            return bandera;
        }

        private bool ContieneNumeros(string s)
        {
            return (s.Contains("1") || s.Contains("2") || s.Contains("3") || s.Contains("4")
                || s.Contains("5") || s.Contains("6") || s.Contains("7") ||
                s.Contains("8") || s.Contains("9") || s.Contains("0"));
        }

        private bool CamposValidos()
        { 
            bool bandera = true;

            if (ContieneNumeros(txtAutor.Text))
            {
                bandera = false;
                errorProvider1.SetError(txtAutor, "Este campo no puede tener números.");
            }
            else{
                errorProvider1.SetError(txtAutor, "");
            }

            return bandera;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            lblCdadPalabras.Text = "0/100";
            try
            {
                if (CamposVacios())
                {
                    throw new ArgumentNullException();
                }
                else if (CamposValidos())
                {
                    Articulo articulo = new Articulo(txtTitulo.Text, txtAutor.Text, txtTextoArticulo.Text);
                    if (revista.Agregar(articulo))
                    {
                        txtCdadArt.Text = (int.Parse(txtCdadArt.Text) + 1).ToString();
                        txtCdadTotalPal.Text = revista.CantidadPalabras.ToString();
                        MessageBox.Show("Artículo agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Limpio los campos
                        txtTitulo.Text = "";
                        txtAutor.Text = "";
                        txtTextoArticulo.Text = "";
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Debe completar todos los campos del artículo",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            listaArticulos.Items.Clear();
            txtinfoTexto.Text = "";
            errorProvider1.SetError(txtInfoAutor, "");
            txtCantidadAutor.Text = revista.CantidadAutor(txtInfoAutor.Text).ToString();

            //Si está vacío el campo autor
            if (txtInfoAutor.Text == "")
            {
                MessageBox.Show("Debe completar el campo autor antes de realizar la búsqueda","Completar campo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Si contiee números
            else if (ContieneNumeros(txtInfoAutor.Text))
            {
                errorProvider1.SetError(txtInfoAutor, "Este campo no puede contener números.");
            }
            else{
                //Obtengo los artículos del autor
                List<Articulo> listado = new List<Articulo>();
                listado = revista.ArticulosDelAutor(txtInfoAutor.Text);

                //Ordeno segun IComparable (Cantidad de palabras de cada artículo)
                listado.Sort();

                //Pongo los títulos en el listado
                foreach (Articulo art in listado)
                {
                    listaArticulos.Items.Add(art.Titulo);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar el artículo?",
                "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(respuesta == DialogResult.Yes)
            {
                //Actualizo los campos
                txtCdadArt.Text = (int.Parse(txtCdadArt.Text) - 1).ToString();
                revista.Eliminar(listaArticulos.SelectedItem.ToString());
                //Elimino de la revista y vuelvo a hacer la misma búsqueda
                BtnBuscar_Click(sender, e);
                txtCdadTotalPal.Text = revista.CantidadPalabras.ToString();
            }
        }

        private void ListaArticulos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Muestro el texto del artículo
            txtinfoTexto.Text = revista.GetTexto(listaArticulos.SelectedItem.ToString());
            //Ahora que tengo uno seleccionado, es posible eliminar
            BtnEliminar.Enabled = true;
        }

        private void TxtTextoArticulo_TextChanged(object sender, EventArgs e)
        {
            if ((txtTextoArticulo.Text.Split(' ')).Length<=100)
            {
                lblCdadPalabras.ForeColor = Color.Green;
                lblCdadPalabras.Text = (txtTextoArticulo.Text.Split(' ')).Length.ToString() + "/100";
            }
            else
            {
                lblCdadPalabras.ForeColor = Color.Red;
                lblCdadPalabras.Text = (txtTextoArticulo.Text.Split(' ')).Length.ToString() + "/100";
            }
        }

        //Al comenzar a escribir el nombre de un autor, se muestra la cantidad de
        //artículos que tiene, de este modo se sabe de antemano qué resultado
        //puede arrojar la búsqueda.
        private void TxtInfoAutor_TextChanged(object sender, EventArgs e)
        {
            //Muestro la cantidad de artículos que tiene
            txtCantidadAutor.Text = revista.CantidadAutor(txtInfoAutor.Text).ToString();
        }
    }
}
