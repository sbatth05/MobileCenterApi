﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MobileCenterApi.Models
{
    public class Contact
    {
        public String Namefield { get; set; }
        public String Emailfield { get; set; }
        public String Messagefield { get; set; }


        SqlConnection sqlConn;
        String connection_String = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=MobileCenterApi;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;

        //this statement is related to insert delete update query that is the main statement of any database record 
        public void Addcontact(String Query)
        {

            sqlConn = new SqlConnection(connection_String);
            sqlConn.Open();


            sqlCmd = new SqlCommand(Query, sqlConn);
            sqlCmd.ExecuteNonQuery();

            sqlConn.Close();

        }

        // this code is used to in the details of a prticuar query from the table using the sql statement with the help of where clause 
        public DataTable LoginVerification(String query)
        {
            DataTable tbl = new DataTable();


            sqlConn = new SqlConnection(connection_String);

            sqlConn.Open();
            sqlCmd = new SqlCommand(query, sqlConn);

            sqlDatareader = sqlCmd.ExecuteReader();

            tbl.Load(sqlDatareader);

            sqlConn.Close();
            return tbl;

        }






    }
}