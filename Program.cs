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
            _listaElementos.Add(new Elementos { Id = 4, Codigo = "E4", Peso = 1, Caloria = 8 });
            _listaElementos.Add(new Elementos { Id = 5, Codigo = "E5", Peso = 2, Caloria = 3 });
        }

        public List<Elementos> _listaElementos;
        public List<Elementos> _listaElementosSumados = new List<Elementos>();

        public void query()
        {
            //se realiza el ingeso y la lectura de los datos.
            string pesoIngresado;
            string caloriaIngresada;
            var sumCaloria = 0.0;
            var sumPeso = 0.0;

            Console.WriteLine("Señor usuario ingrese el peso máximo");
            pesoIngresado = Console.ReadLine();

            Console.WriteLine("Señor usuario ingrese la cantidad mínima de caloría");
            caloriaIngresada = Console.ReadLine();
            double peso = int.Parse(pesoIngresado);
            double caloria = int.Parse(caloriaIngresada);

            //Se realiza la consulta utilizando linq.
            var consulta = _listaElementos.ToList();
            foreach (var item in consulta)
            {
                var minCal = sumCaloria + item.Caloria;
                var pesMax = sumPeso + item.Peso;

                if (minCal > caloria && pesMax < peso)
                {
                    _listaElementosSumados.Add(item);
                    sumCaloria = _listaElementosSumados.Select(s => s.Caloria).Sum();
                    sumPeso = _listaElementosSumados.Select(s => s.Peso).Sum();
                }


                if (minCal <= caloria && pesMax < peso)
                {
                    _listaElementosSumados.Add(item);

                    sumCaloria = _listaElementosSumados.Select(s => s.Caloria).Sum();
                    sumPeso = _listaElementosSumados.Select(s => s.Peso).Sum();
                }


                if ( sumPeso >= peso) break;
            }


            if (_listaElementos != null)
            {

                //Se realiza la suma de los valores

                if (sumCaloria < caloria)
                {
                    Console.WriteLine(" No existen elementos con las caracteristicas solicitadas.");
                }
                else
                {
                    if (sumPeso > 0 && sumPeso < peso && sumCaloria > caloria)
                    {
                        Console.WriteLine("Los elementos seleccionados tienen las siguientes caracteristicas: ");
                        foreach (var item in _listaElementosSumados)
                        {
                            Console.Write($" {item.Codigo} con peso: {item.Peso} y calorías: {item.Caloria} {Environment.NewLine}");


                        }
                    }
                    Console.WriteLine($" los valores totales de calorías son: {sumCaloria} y de peso peso: {sumPeso}");

                }

            }


        }

    }



}