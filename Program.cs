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
            //llamada del método query para ejecutar la consulta
            ControlElementos control = new ControlElementos();
            control.query();          
        }
    }

    public class ControlElementos
    {
        public ControlElementos()
        {
            //Se crea la lista y se agregan los elementos  
            _listaElementos = new List<Elementos>();


            _listaElementos.Add(new Elementos { Id = 1, Codigo = "E1" ,Peso = 5, Caloria = 3 });
            _listaElementos.Add(new Elementos { Id = 2, Codigo = "E2", Peso = 3, Caloria = 5 });
            _listaElementos.Add(new Elementos { Id = 3, Codigo = "E3", Peso = 5, Caloria = 2 });
            _listaElementos.Add(new Elementos { Id = 1, Codigo = "E5", Peso = 1, Caloria = 8 });
            _listaElementos.Add(new Elementos { Id = 2, Codigo = "E6", Peso = 2, Caloria = 3 });
        }

        public List<Elementos> _listaElementos;

        public void query()
        {
            //se realiza el ingeso y la lectura de los datos.
            string pesoIngresado;
            string caloriaIngresada;
            Console.WriteLine("Señor usuario ingrese el peso máximo");
            pesoIngresado = Console.ReadLine();

            Console.WriteLine("Señor usuario ingrese la cantidad máxima de caloría");
            caloriaIngresada = Console.ReadLine();
            double peso = int.Parse(pesoIngresado);
            double caloria = int.Parse(caloriaIngresada);

            //Se realiza la consulta utilizando linq.
            var consulta = _listaElementos.Where(elemento => elemento.Peso < peso && elemento.Caloria < caloria);
            if (consulta != null)
            {
                //Se muestran los elementos filtrados.
                Console.WriteLine("Los elementos seleccionados tienen las siguientes caracteristicas: ");
                foreach (var item in consulta)
                {
                    Console.Write($" {item.Codigo} con peso: {item.Peso} y calorías: {item.Caloria} {Environment.NewLine}");

                }
            }
            
                
        }

    }
    

    
}