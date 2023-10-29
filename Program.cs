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
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            ///
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }
    }

    public class ControlElementos
    {
        public ControlElementos()
        {
            _listaClientes = new List<Elementos>();


            _listaClientes.Add(new Elementos { Id = 1, Peso = 5, Caloria = 3 });
            _listaClientes.Add(new Elementos { Id = 2, Peso = 3, Caloria = 5 });
            _listaClientes.Add(new Elementos { Id = 3, Peso = 5, Caloria = 2 });
            _listaClientes.Add(new Elementos { Id = 1, Peso = 1, Caloria = 8 });
            _listaClientes.Add(new Elementos { Id = 2, Peso = 2, Caloria = 3 });
        }

        public List<Elementos> _listaClientes;
    }
}