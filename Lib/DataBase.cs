using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace Lib
{
    // Подключаемся к базе данных.
    public class DataBase
    {
        const string CONN_STR = "********************************************;";
        private readonly MySqlConnection _db;
        private MySqlCommand _command;
        public DataBase()
        {
            _db = new MySqlConnection(CONN_STR);
            _command = new MySqlCommand { Connection = _db };
        }
        public void Open()
        {
            _db.Open();
        }
        public void Close()
        {
            _db.Close();
        }
        // Вызываем весь список товаров.
        public List<Product> GetProduct()
        {
            var list = new List<Product>();
            var sql =
                @"
SELECT table_product.id,
       name_product,
       type_product,
       name_suppliers,
       quantity_product,
       costPrice_product,
       dateDelivery_product
FROM
     table_product,
     table_type_product,
     table_supplier
WHERE table_product.quantity_product = (SELECT MAX(quantity_product)FROM table_product)
AND table_product.id_type = table_type_product.id
AND table_product.id_supplier = table_supplier.id;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                var id = result.GetInt32("id");
                var nameProduct = result.GetString("nameProduct");
                var nameType = result.GetString("nameType");
                var supplierProd = result.GetString("supplier");
                var quantityProduct = result.GetString("quantity");
                var costPriceProduct = result.GetInt32("costPrice");
                var dateDeliveryProduct = result.GetDateTime("dateDelivery");
                list.Add(new Product { Id = id, NameProduct = nameProduct, TypeProd = nameType, SupplierProd = supplierProd, QuantityProduct = quantityProduct, CostPriceProduct = costPriceProduct, DateDeliveryProduct = dateDeliveryProduct });
            }
            return list;
        }
        // Отображаем все типы товаров.
        public List<string> GetTypeProduct()
        {
            List<string> types = new List<string>();
            var sql =
                @"
SELECT id, type_product
FROM table_type_product;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                types.Add(result.GetString("types"));
            }
            return types;
        }
        // Отображаем всех постащиков.
        public List<string> GetSupplierProduct()
        {
            List<string> supplier = new List<string>();
            var sql =
                @"
SELECT id, name_suppliers
FROM table_supplier;;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                supplier.Add(result.GetString("supplier"));
            }
            return supplier;
        }
        // Отобразить товар с максимальном количеством.
        public int GetMaxNumber() 
        {
            var sql =
                @"
SELECT table_product.id,
       name_product,
       type_product,
       name_suppliers,
       quantity_product,
       costPrice_product,
       dateDelivery_product
FROM
     table_product,
     table_type_product,
     table_supplier
WHERE table_product.quantity_product = (SELECT MAX(quantity_product)FROM table_product)
AND table_product.id_type = table_type_product.id
AND table_product.id_supplier = table_supplier.id;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            int value = 0;
            while (result.Read())
            {
                value = result.GetInt32("max");
            }
            return value;
        }
        //Отобразить товар с минимальным количеством.
        public int GetMinNumber()
        {
            var sql =
                @"
SELECT table_product.id,
       name_product,
       type_product,
       name_suppliers,
       quantity_product,
       costPrice_product,
       dateDelivery_product
FROM table_product,
     table_type_product,
     table_supplier
WHERE table_product.quantity_product = (SELECT MIN(quantity_product)FROM table_product)
AND table_product.id_type = table_type_product.id
AND table_product.id_supplier = table_supplier.id;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            int value = 0;
            while (result.Read())
            {
                value = result.GetInt32("min");
            }
            return value;
        }
        //Отобразить товар с минимальной себестоимостью.
        public int GetMinCostPPrice()
        {
            var sql =
                @"
SELECT table_product.id,
       name_product,
       type_product,
       name_suppliers,
       quantity_product,
       costPrice_product,
       dateDelivery_product
FROM table_product,
     table_type_product,
     table_supplier
WHERE table_product.costPrice_product = (SELECT MIN(costPrice_product) FROM table_product)
AND table_product.id_type= table_type_product.id
AND table_product.id_supplier = table_supplier.id;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            int value = 0;
            while (result.Read())
            {
                value = result.GetInt32("min");
            }
            return value;
        }
        //Отобразить товар с минимальной себестоимостью.
        public int GetMaxCostPPrice()
        {
            var sql =
                @"
SELECT table_product.id,
       name_product,
       type_product,
       name_suppliers,
       quantity_product,
       costPrice_product,
       dateDelivery_product
FROM table_product,
     table_type_product,
     table_supplier
WHERE table_product.costPrice_product = (SELECT MAX(costPrice_product) FROM table_product)
AND table_product.id_type= table_type_product.id
AND table_product.id_supplier = table_supplier.id;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            int value = 0;
            while (result.Read())
            {
                value = result.GetInt32("max");
            }
            return value;
        }
    }
}

           


    
   
