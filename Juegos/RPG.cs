using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegos
{
    class RPG : Juego
    {
        private string plataforma;

        public RPG(string _gene, string _form, string _title, string _desc, string plataform)
        {
            this.genero = _gene;
            this.formato = _form;
            this.titulo = _title;
            this.descripcion = _desc;
            this.plataforma = plataform;
        }

        public override void Caracteristica()
        {
            Console.WriteLine("Caracteristica del rpg");
        }

        public string setPlataforma
        {
            set { plataforma = value; }
        }
        public string getPlataforma
        {
            get { return plataforma; }
        }

    }
}