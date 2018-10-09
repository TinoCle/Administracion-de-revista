using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminRevista
{
    class Articulo : IComparable
    {
        string titulo;
        string autor;
        string textoArticulo;
        int cantidadpalabras;

        public Articulo(string t, string a, string txt)
        {
            titulo = t;
            autor = a;
            textoArticulo = txt;
            cantidadpalabras = (textoArticulo.Split(' ')).Length;
        }
        
        public int Cantidadpalabras { get => cantidadpalabras;}
        public string Titulo { get => titulo;}
        public string Autor { get => autor;}
        public string TextoArticulo { get => textoArticulo;}

        public int CompareTo(Object art)
        {
            if (((Articulo)art).cantidadpalabras > cantidadpalabras)
            {
                return -1;
            }
            else if(((Articulo)art).cantidadpalabras == cantidadpalabras)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
