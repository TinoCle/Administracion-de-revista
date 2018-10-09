using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRevista
{
    class Revista
    {
        List<Articulo> articulos;
        string fecha;
        int cantidadPalabras;

        public Revista()
        {
            //Obtengo la fecha actual
            fecha = DateTime.Now.ToShortDateString();
            articulos = new List<Articulo>();
            cantidadPalabras = 0;
        }

        public string Fecha { get => fecha;}
        public int CantidadPalabras { get => cantidadPalabras;}

        private bool TitulosIguales(string titulo)
        {
            foreach (Articulo a in articulos)
            {
                if (a.Titulo.ToLower() == titulo.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public bool Agregar(Articulo art)
        {
            if (TitulosIguales(art.Titulo))
            {
                MessageBox.Show("El artículo tiene el mismo título que uno anterior.",
                    "Artículo repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (art.Cantidadpalabras > 100)
            {
                MessageBox.Show("El límite de palabras en el artículo fue superado. " +
                    "("+art.Cantidadpalabras.ToString()+"/100)",
                    "Límite de palabras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((cantidadPalabras + art.Cantidadpalabras) > 1000)
            {
                MessageBox.Show("El límite de palabras en la revista fue superado. " +
                    "("+ (cantidadPalabras + art.Cantidadpalabras).ToString()+"/1000)",
                    "Límite de palabras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Sino
            articulos.Add(art);
            cantidadPalabras += art.Cantidadpalabras;
            return true;
        }

        public void Eliminar(string titulo)
        {
            int indice = -1;
            int palabrasBorradas = 0;
            foreach(Articulo art in articulos)
            {
                if(art.Titulo.ToLower() == titulo.ToLower())
                {
                    palabrasBorradas = art.Cantidadpalabras;
                    indice = articulos.IndexOf(art);
                }
            }
            if (indice != -1)
            {
                cantidadPalabras -= palabrasBorradas;
                articulos.RemoveAt(indice);
            }
        }

        public int CantidadAutor(string autor)
        {
            int count = 0;

            foreach (Articulo a in articulos)
            {
                if (a.Autor.ToLower() == autor.ToLower())
                {
                    count += 1;
                }
            }
            return count;
        }

        public List<Articulo> ArticulosDelAutor(string autor)
        {
            List<Articulo> listado = new List<Articulo>();
            foreach(Articulo art in articulos)
            {
                if (art.Autor.ToLower() == autor.ToLower())
                {
                    listado.Add(art);
                }
            }
            return listado;
        }

        public string GetTexto(string titulo)
        {
            foreach(Articulo art in articulos)
            {
                if(art.Titulo.ToLower() == titulo.ToLower())
                {
                    return art.TextoArticulo;
                }
            }
            return "";
        }
    }
}
