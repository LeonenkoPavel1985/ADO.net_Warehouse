using System;
using System.Collections.Generic;
using Lib;

namespace ADO.net_Warehouse
{
    class CLI
    {
        public static void ShowMenu()
        {
            Console.WriteLine("БАЗА ДАННЫХ 'СКЛАД ТОВАРОВ'.");
            Console.WriteLine("Выберите пункт меню для работы с базой:");
            Console.WriteLine("1. Отображение всей информации о товаре.");
            Console.WriteLine("2. Отображение всех типов товаров.");
            Console.WriteLine("3. Отображение всех поставщиков.");
            Console.WriteLine("4. Показать товар с максимальным количеством.");
            Console.WriteLine("5. Показать товар с минимальным количеством.");
            Console.WriteLine("6. Показать товар с минимальной себестоимостью.");
            Console.WriteLine("7. Показать товар с максимальной себестоимостью.");
            Console.WriteLine("0. Выход.");
        }
        public static void ShowProduct(List<Product> products)
        {
            foreach (var priduct in products)
            {
                ShowProduct(products);
            }
        }
        public static void ShowProducts(Product products)
        {
            Console.WriteLine("--- --- ---");
            Console.WriteLine();
            Console.WriteLine($"{products.Id}: {products.NameProduct} {products.TypeProd} {products.SupplierProd} {products.QuantityProduct} {products.CostPriceProduct} {products.DateDeliveryProduct}");
            Console.WriteLine("--- --- ---");
            Console.WriteLine();
        }
        public static void ShowListValue<T>(List<T> list, string title = " ")
        {
            if (title != " ")
            {
                Console.WriteLine($"{title}:");
            }
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static void ShowValue<T>(T value, string msg = " ")
        {
            if (msg != " ")
            {
                Console.Write(msg);
            }
            Console.WriteLine(value);
            Console.WriteLine();
        }
    }
}
  
