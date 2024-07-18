using System;

namespace ejerciciosAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            //Pizzeria-Restaurant (:P): Se tiene una lista en la que se van almacenando todos los pedidos que los clientes hacen
            // Cada pedido tiene un id de pedido, un precio total de pedido, el nombre, direccion y dni de quien 
            // tomó el pedido, num de telefono y capaz algo mas (capaz no todos esos datos, solo lo importante)

            // Se pide: 1. Crear la funcionalidad necesaria para almacenar todos los pedidos y trabajar con ellos
            // 2. A partir de esta lista, guardar en un arreglo todos aquellos pedidos que hayan superado un monto
            // que se ingresa por teclado (ej: si ingreso 200, se guardaran en el arreglo solo aquellos pedidos que
            // hayan gastado 200 o mas en cada pedido)
            // 3. la lista que guarda los pedidos debe quedar ordenada automaticamente por opcion del menu seleccionada, de manera ascendente;
            // 4. crear funcionalidad para buscar un pedido, para saber si existe en la lista
            //
            //
            // * cada pedido puede contener un plato o comida, siendo estos:
            //   1.Spaghetti 2.Ensalada 3.Hamburguesa 4.Pizza 5.Helado 
            //
            ListaPizzaCafe l = new ListaPizzaCafe();
            Console.WriteLine("Inicio del programa\n" +
                "");
            l.InsertarPedido();
            l.MostrarListaPedidos();
        }
    }
}
