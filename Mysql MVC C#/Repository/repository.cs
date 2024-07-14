using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysql_MVC_C_.Models;
using Mysql_MVC_C_.Data;
using Microsoft.VisualBasic;
namespace Mysql_MVC_C_.Repository
{
    public class repository
    {
      Dataset dataset = new Dataset();
       public void CreateCustomer (Customer customer)
       {
            string Query = "Iserto into Custumers ( Name , Email) Values (@Name , @Email )";
            using (MySqlCommand cmd = new MySqlCommand(Query,dataset.Connection)){
                
            }
       }
    
    }
}