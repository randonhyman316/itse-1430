/***********************
 * Randon Hyman
 * ITSE 1430 
 * 5/3/2018
 * ********************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : IProductDatabase
    {
        public SqlProductDatabase(string connString)
        {
            if (connString == null)
                throw new ArgumentException("Connection string cannot be null.");
            else if (connString == "")
                throw new ArgumentException("Connection string cannot be empty.");
            else
                _connString = connString;
        }
        private readonly string _connString;

        public Product Add(Product product)
        {
            using (var conn = CreateConnection())
            {
                var cmd = new SqlCommand("AddProduct", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                conn.Open();
                var result = cmd.ExecuteScalar();
                var id = Convert.ToInt32(result);

                cmd.Parameters.AddWithValue("@id", product.Id);

                return product;

            };
        }

        public Product FindById(int id)
        {
            using (var conn = CreateConnection())
            {
                var cmd = new SqlCommand("GetAllProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int productId = Convert.ToInt32(reader.GetValue(0));
                        if (productId != id)
                            continue;

                        return new Product()
                        {
                            Id = Convert.ToInt32(id),
                            Name = Convert.ToString(reader.GetValue(2)),
                            Description = Convert.ToString(reader.GetValue(2)),
                            Price = reader.GetFieldValue<Decimal>(3),
                            IsDiscontinued = reader.GetFieldValue<bool>(4),

                        };
                    }
                }
            }

            return null;
        }

        public Product Get(int id)
        {
            var product = FindById(id);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            var ds = new DataSet();
            using (var conn = CreateConnection())
            {
                var da = new SqlDataAdapter();
                var cmd = new SqlCommand("GetAllProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                da.SelectCommand = cmd;
                da.Fill(ds);
            }

            if (!ds.Tables.OfType<DataTable>().Any())
                return Enumerable.Empty<Product>();

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table == null)
                return Enumerable.Empty<Product>();

            var products = new List<Product>();
            foreach(var row in table.Rows.OfType<DataRow>())
            {
                var product = new Product()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row.Field<string>("Name"),
                    Description = row.Field<string>("Description"),
                    Price = row.Field<Decimal>("Price"),
                    IsDiscontinued = row.Field<bool>("IsDiscontinued")
                    
                };
                products.Add(product);

            }
            // sort
            products.Sort(delegate(Product x, Product y) { return x.Name.CompareTo(y.Name); });
            return products;
        }

        public void Remove(int id)
        {
            using (var conn = CreateConnection())
            {
                var da = new SqlDataAdapter();
                var cmd = new SqlCommand("RemoveProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteScalar();
            }
        }

        public Product Update(Product product)
        {
            using (var conn = CreateConnection())
            {
                var cmd = new SqlCommand("UpdateProduct", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", product.Id);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                conn.Open();
                var result = cmd.ExecuteScalar();
                var id = Convert.ToInt32(result);

                cmd.Parameters.AddWithValue("@id", product.Id);

                return product;

            };
        }

        private SqlConnection CreateConnection()
        {
            return new SqlConnection(_connString);
        }
    }
}
