using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegos
{
    class main
    {
        static void Main(string[] args)
        { 
    Estrategia ClashRoyale = new Estrategia("Estrategia", "Digital", "Clash Royale", "",
        "Android/Ios");
            ClashRoyale.setGenero = "Estrategia";
            ClashRoyale.setFormato = "Digital";
            ClashRoyale.setDescripcion = "Destruye las torres enemigas";
            ClashRoyale.setTitulo = "Clash Royale";
            ClashRoyale.setPlataforma = "Android/Ios";

            Console.WriteLine("#####################");
            Console.WriteLine("Genero: " + ClashRoyale.getGenero + "");
            Console.WriteLine("Titulo:" + ClashRoyale.getTitulo + "");
            Console.WriteLine("Formato:" + ClashRoyale.getFormato + "");
            Console.WriteLine("Descripcion:" +  ClashRoyale.getDescripcion + "");
            Console.WriteLine("Plataforma:" + ClashRoyale.getPlataforma +"");
            Console.WriteLine("#####################");

            RPG WoW = new RPG("RPG", "Digital/Fisico", "world of warcraft", "", "Pc");
            WoW.setGenero = "RPG";
            WoW.setFormato = "Digital/Fisico";
            WoW.setDescripcion = "Sube de nivel tu personaje en un mundo abirto";
            WoW.setTitulo = "World of Warcraft";
            WoW.setPlataforma = "Pc";

                Console.WriteLine("Genero:" + WoW.getGenero + "");
                Console.WriteLine("Titulo:" + WoW.getTitulo + "");
                Console.WriteLine("Formato:" + WoW.getFormato + "");
                Console.WriteLine("Descripcion:" + WoW.getDescripcion + "");
                Console.WriteLine("Plataforma:" + WoW.getPlataforma + "");
                Console.WriteLine("#####################");

        }
    }
}
 
