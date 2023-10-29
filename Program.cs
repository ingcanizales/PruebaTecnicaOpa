using System;
using PruebaTecnicaOpa.Entity;
using System.Collections.Generic;
using System.Linq;
namespace PruebaTecnicaOpa
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlElementos control = new ControlElementos();
            control.query();          
        }
    }

    public class ControlElementos
    {
        public ControlElementos()
        {
            _listaElementos = new List<Elementos>();


            _listaElementos.Add(new Elementos { Id = 1, Peso = 5, Caloria = 3 });
            _listaElementos.Add(new Elementos { Id = 2, Peso = 3, Caloria = 5 });
            _listaElementos.Add(new Elementos { Id = 3, Peso = 5, Caloria = 2 });
            _listaElementos.Add(new Elementos { Id = 1, Peso = 1, Caloria = 8 });
            _listaElementos.Add(new Elementos { Id = 2, Peso = 2, Caloria = 3 });
        }

        public List<Elementos> _listaElementos;

        public void query()
        {
            string pesoIngresado;
            string caloriaIngresada;
            Console.WriteLine("Señor usuario ingrese el peso");
            pesoIngresado = Console.ReadLine();

            Console.WriteLine("Señor usuario ingrese la cantidad de caloría");
            caloriaIngresada = Console.ReadLine();
            double peso = int.Parse(pesoIngresado);
            double caloria = int.Parse(caloriaIngresada);

            var consulta = _listaElementos.Where(elemento => elemento.Peso < peso && elemento.Caloria < caloria);
            foreach (var item in consulta)
            {
                Console.Write($"los Elementos recomendados son peso {item.Peso} y calorías {item.Caloria} {Environment.NewLine}");

            }
                
        }

    }
    

    
}