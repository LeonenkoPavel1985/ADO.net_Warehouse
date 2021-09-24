using System;
using System.IO;
using Lib;

namespace ADO.net_Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBase();
            var exit = false;
            do
            {
                CLI.ShowMenu();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        db.Open(); // Отображение всей информации о товаре.
                        CLI.ShowProduct(db.GetProduct());
                        db.Close();
                        break;
                    case "2":  //  Отображение всех типов товаров.
                        db.Open();
                        CLI.ShowListValue(db.GetTypeProduct(), "Все типы товаров:");
                        db.Close();
                        break;
                    case "3":  //  Отображение всех поставщиков.
                        db.Open();
                        CLI.ShowListValue(db.GetSupplierProduct(), "Все поставщики:");
                        db.Close();
                        break;
                    case "4":  //  Показать товар с максимальным количеством.
                        db.Open();
                        CLI.ShowValue(db.GetMaxNumber(), "Товар с максимальным количеством:");
                        db.Close();
                        break;
                    case "5":  //  Показать товар с минимальным количеством.
                        db.Open();
                        CLI.ShowValue(db.GetMinNumber(), "Товар с минимальным количеством:");
                        db.Close();
                        break;
                    case "6":  // Показать товар с минимальной себестоимостью.
                        db.Open();
                        CLI.ShowValue(db.GetMinCostPPrice(), "Товар с минимальной себестоимостью:");
                        db.Close();
                        break;
                    case "7":  // Показать товар с максимальной себестоимостью.
                        db.Open();
                        CLI.ShowValue(db.GetMaxCostPPrice(), "Товар с максимальной себестоимостью:");
                        db.Close();
                        break;
                    case "0": // выход из программы.
                        exit = true;
                        break;
                    default:
                        break;
                }
            } while (!exit);
        }
    }
}
