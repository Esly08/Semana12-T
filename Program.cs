


using System.Net.Http.Headers;

namespace _1308723_Herencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Productos productoX = new Productos();
            productoX.nombre = "Producto genérico";
            productoX.cantidad = 10;
            productoX.unidad = "Unidades";
            productoX.costo = 100.50m;

            Perecedero comida = new Perecedero();
            comida.nombre = "Producto genérico";
            comida.cantidad = 10;
            comida.unidad = "Unidades";
            comida.costo = 100.50m;
            comida.FechaCaducidad = new DateTime(2022, 06, 01);
            comida.FechaProduccion = new DateTime(2022, 08, 02);
            comida.Lote = 1.1091832129;

            if (comida is Productos)
            {
                Console.WriteLine("Es producto");
            }
            else
            {
                Console.WriteLine("No es producto");
            }
            Console.ReadLine();

            NoPerecedero herramienta = new NoPerecedero();
            herramienta.nombre = "Producto genérico";
            herramienta.cantidad = 10;
            herramienta.unidad = "Unidades";
            herramienta.costo = 100.50m;
            herramienta.Lote = 1.298735;

            Natural papa = new Natural();
            papa.nombre = "Producto genérico";
            papa.cantidad = 10;
            papa.unidad = "Libras";
            papa.costo = 100.50m;
            papa.Lote = 3.45567;
            papa.FechaCaducidad = new DateTime(2022, 09, 01);
            papa.FechaProduccion = new DateTime(2022, 05, 11);
            papa.Precocido = false;

            if (papa is Natural)
                Console.WriteLine("Papa no es precocida");

            if (papa is Perecedero)
                Console.WriteLine("Papa es precocida");

            LicenciaSoft tablet = new LicenciaSoft();
            tablet.nombre = "Tab E-8";
            tablet.cantidad = 8;
            tablet.unidad = " Unidades ";
            tablet.costo = 1206.68m;
            tablet.EsCanjeable = false;
            tablet.codigo = "1E3FG9";

            AudioLibro Estrellas = new AudioLibro();
            Estrellas.nombre = "Cuando no queden más estrellas que contar";
            Estrellas.cantidad = 100;
            Estrellas.unidad = "20 escuchas";
            Estrellas.costo = 200.00m;
            Estrellas.EsCanjeable = true;
            Estrellas.duracion = 5.54;

            if (Estrellas is AudioLibro)
                Console.WriteLine("Cuando no queden más estrellas que contar - Audio Libro");

            else
                Console.WriteLine("No es un Audio Libro");

            DispositivosElec estufa = new DispositivosElec();
            estufa.nombre = "La poderosa34";
            estufa.cantidad = 50;
            estufa.unidad = "Unidades";
            estufa.costo = 345.09m;
            estufa.corriente = "Corriente Alterna";

            Enlatados frijoles = new Enlatados();
            frijoles.nombre = "Frijoles fritos";
            frijoles.cantidad = 45;
            frijoles.unidad = "Unidades";
            frijoles.costo = 24m;
            frijoles.presentacion = 10.08;

            //No estoy segura de mi código. Me faltó aclarar lo de los if.

        }
    }
}