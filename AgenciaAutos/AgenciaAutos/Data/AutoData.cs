﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.Common;
using System.Data;

namespace AgenciaAutos.Data
{
    public class AutoData
    {

        public AutoData()
        {

        }
        public static string constr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            }
        }

        public static string Provider
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["conn"].ProviderName;
            }
        }

        public static DbProviderFactory dpf
        {
            get
            {
                return DbProviderFactories.GetFactory(Provider);
            }
        }

        private static int EjecutaNonQuery(string StoredProcedure, List<DbParameter> parametros)
        {
            int Id =0;
            try
            {
                using (DbConnection con= dpf.CreateConnection()){

                    con.ConnectionString = constr;
                    using(DbCommand cmd= dpf.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = StoredProcedure;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (DbParameter param in parametros)
                            cmd.Parameters.Add(param);
                        con.Open();
                        Id = cmd.ExecuteNonQuery();

                        
                    }
                     

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}