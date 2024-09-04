using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp39
{

    class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }
        public Producto(string nombre, decimal precio, int cantidadStock)
        {
            Nombre = nombre;
            Precio = precio;
            CantidadStock = cantidadStock;
        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}\nPrecio: {Precio}\nCantidad en stock: {CantidadStock}");
        }
    }

    class Libro : Producto
    {
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public Libro(string nombre, decimal precio, int cantidadStock, string autor, int numeroPaginas) : base(nombre,precio,cantidadStock)
        {
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Autor: {Autor}\nNumero de paginas: {NumeroPaginas}");
        }

    }

    class Revista : Producto
    {
        public string Edicion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Revista(string nombre,decimal precio,int cantidadStock,string edicion, DateTime fechaPublicacion) : base(nombre,precio,cantidadStock)
        {
            Edicion = edicion;
            FechaPublicacion = fechaPublicacion;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Edicion: {Edicion}\nFecha de publicacion: {FechaPublicacion}");
        }
    }
    class MaterialOficina : Producto
    {
        public string TipoMaterial { get; set; }
        public MaterialOficina(string nombre, decimal precio, int cantidadStock, string tipoMaterial) : base (nombre,precio,cantidadStock)
        {
            TipoMaterial = tipoMaterial;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tipo de material: {TipoMaterial}");
        }
    }

    class Inventario : IlistaEditable<Producto>
    {
        public List<Producto> producto { get; set; }
        public Inventario()
        {
            producto = new List<Producto>();
        }
        public void Agregar(Producto productoo)
        {
            producto.Add(productoo);
        }
        public void Quitar(Producto productoo)
        {
            producto.Add(productoo);
        }
        public void MostrarInventario()
        {
            Console.WriteLine("Inventario completo: ");
            foreach(var product in producto)
            {
                product.MostrarDetalles();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Libro Habitosatomicos = new Libro("Habitos atomicos", 25000,10,"nose", 3000);
            Revista superman = new Revista("Superman 2008", 100000,1,"numero 20", DateTime.Now);
            MaterialOficina hojas = new MaterialOficina("hojas A4",6000,100,"madera");

            Inventario inventario = new Inventario();
            inventario.Agregar(superman);
            inventario.Agregar(Habitosatomicos);
            inventario.Agregar(hojas);

            inventario.MostrarInventario();
            Console.ReadKey();
        }
    }
}
