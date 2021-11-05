using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegos
{
    abstract class Juego
    {
        public string genero;
        public string formato;
        public string titulo;
        public string descripcion;
        public string setGenero
        {
            set { genero = value; }
        }
        public string setFormato
        {
            set { formato = value; }
        }
        public string setTitulo
        {
            set { titulo = value; }
        }
        public string setDescripcion
        {
            set { descripcion = value; }
        }
        public string getGenero
        {
            get { return genero; }
        }
        public string getFormato
        {
            get { return formato; }
        }
        public string getTitulo
        {
            get { return titulo; }
        }
        public string getDescripcion
        {
            get { return descripcion; }
        }
        public abstract void Caracteristica();
    }
}