using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Ej_6;

namespace Ejercicio_polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro miAnimal = new Perro(); //aca instancio el metodo y creo lista
            miAnimal.NombrePerro = "Firulais";
            Console.WriteLine(miAnimal.NombrePerro);
            Console.WriteLine("Hago este sonido " + miAnimal.Sonido());
            Console.ReadLine();

            Gato miGato = new Gato();
            miGato.NombreGato = "michi";
            Console.WriteLine(miGato.NombreGato);
            Console.WriteLine("Hago este sonido " + miGato.Sonido());
            Console.ReadLine();

            Vaca miVaca = new Vaca();
            miVaca.NombreVaca= "Lola";
            Console.WriteLine(miVaca.NombreVaca);
            Console.WriteLine("Hago este sonido " + miVaca.Sonido());
            Console.ReadLine();

            Auto miAuto = new Auto();
            miAuto.velocidad = 10;
            Console.WriteLine(miAuto.velocidad);
            Console.WriteLine(miAuto.Acelerar());
            Console.ReadLine();

            Bicicleta miBici = new Bicicleta();
            miBici.velocidad = 5;
            Console.WriteLine(miBici.velocidad);
            Console.WriteLine(miBici.Acelerar());
            Console.ReadLine();


            Rectangulo miRec = new Rectangulo();
            miRec.Ancho = 5;
            miRec.Largo = 10;
            Console.WriteLine(miRec.Ancho);
            Console.WriteLine(miRec.Largo);
            Console.WriteLine(miRec.CalcularArea());
            Console.ReadLine();


            Circulo miCir = new Circulo();
            miCir.Radio = 2;
            Console.WriteLine(miCir.Radio);
            Console.WriteLine(miCir.CalcularArea());
            Console.ReadLine();


            Vendedor miVen = new Vendedor();
            miVen.NombreVendedor = "Carlito";
            Console.WriteLine(miVen.NombreVendedor);
            Console.WriteLine(miVen.CalcularSalario());
            Console.ReadLine();

            Gerente miGer = new Gerente();
            miGer.NombreGerente = "Luis";
            Console.WriteLine(miGer.NombreGerente);
            Console.WriteLine(miGer.CalcularSalario());
            Console.ReadLine();

            Bateria miBat = new Bateria();
            miBat.instrumentobat = "bom";
            Console.WriteLine(miBat.instrumentobat);
            Console.WriteLine(miBat.Tocar());
            Console.ReadLine();

            Guitarra miGuit = new Guitarra();
            miGuit.instrumentoguit = "gui";
            Console.WriteLine(miGuit.instrumentoguit);
            Console.WriteLine(miGuit.Tocar());
            Console.ReadLine();

            Piano miPian = new Piano();
            miPian.InstrumentoPian = "pin";
            Console.WriteLine(miPian.InstrumentoPian);
            Console.WriteLine(miPian.Tocar());
            Console.ReadLine();


            // EJERCICIO OPCIONAL
            List<Producto> productos = new List<Producto>();

            // Agregar objetos de la clase ProductoFisico usando constructor
            Productofisico productoFisico1 = new Productofisico("Torta", 2500, 2.5);
            productos.Add(productoFisico1);

            Productofisico productoFisico2 = new Productofisico("Libro", 1500, 1.6);
            productos.Add(productoFisico2);

            // Agregar objetos de la clase ProductoDigital usando constructor
            Productodigital productoDigital1 = new Productodigital("Caramelo", 15000, 750);
            productos.Add(productoDigital1);

            Productodigital productoDigital2 = new Productodigital("conitos", 150, 55);
            productos.Add(productoDigital2);

            // Imprimir información de cada producto
            foreach (Producto producto in productos)
            {
                Console.WriteLine("Nombre: " + producto.Nombre);
                Console.WriteLine("Precio: " + producto.Precio);
                Console.WriteLine("Impuesto: " + producto.CalcularImpuesto());
                Console.WriteLine("Total: " + producto.CalcularTotal());
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
