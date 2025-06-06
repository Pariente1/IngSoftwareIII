﻿using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProyectoKamil.Dto;

namespace ProyectoKamil.Data
{
    public static class WorkCenterRepository
    {
        private static string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";
        public static bool WorkCenterExists(string nombreCentro)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM Catalogo_Centros WHERE Nombre_Centro = @NombreCentro";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombreCentro", nombreCentro);
                conn.Open();
                exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            return exists;
        }

        public static List<WorkCenterDto> GetWorkCenters(string id, string nombreCentro, string ciudad)
        {
            List<WorkCenterDto> puestos = new List<WorkCenterDto>();
            string query = "SELECT ID_Centro, Nombre_Centro, Ciudad FROM Catalogo_Centros";            
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        puestos.Add(new WorkCenterDto
                        {
                            ID = Convert.ToInt32(reader["ID_Centro"]),
                            Nombre = reader["Nombre_Centro"].ToString(),
                            Ciudad = reader["Ciudad"].ToString()
                        });
                    }
                }
            }
            return puestos;
        }

        public static int InsertWorkCenter(string nombreCentro, string ciudad)
        {
            int newId = 0;
            string query = "INSERT INTO Catalogo_Centros (Nombre_Centro, Ciudad) VALUES (@NombreCentro, @Ciudad); SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombreCentro", nombreCentro);
                cmd.Parameters.AddWithValue("@Ciudad", ciudad);
                conn.Open();
                newId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return newId;
        }

        public static bool UpdateWorkCenter(string nombreCentro, string nombreCentroNuevo, string ciudad)
        {
            bool success = false;
            string query = "UPDATE Catalogo_Centros SET Nombre_Centro = @NombreCentroNuevo, Ciudad = @Ciudad WHERE Nombre_Centro = @NombreCentro";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombreCentroNuevo", nombreCentroNuevo);
                cmd.Parameters.AddWithValue("@NombreCentro", nombreCentro);
                cmd.Parameters.AddWithValue("@Ciudad", ciudad);                
                conn.Open();
                success = cmd.ExecuteNonQuery() > 0;
            }
            return success;
        }

        public static bool DeleteWorkCenter(string nombreCentro)
        {
            bool success = false;
            string query = "DELETE FROM Catalogo_Centros WHERE Nombre_Centro = @NombreCentro";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombreCentro", nombreCentro);
                conn.Open();
                success = cmd.ExecuteNonQuery() > 0;
            }
            return success;
        }
    }
}
