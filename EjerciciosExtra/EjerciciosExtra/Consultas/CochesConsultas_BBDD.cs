using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace EjerciciosExtra.Consultas
{

    public class CochesConsultas_BBDD
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;
        String cadenaConexion;

        public CochesConsultas_BBDD() {

            this.cadenaConexion = @"Data Source=LAPTOP-IVMF1NEK\MSSQLSERVE;Initial Catalog=CONCESIONARIO;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.connect = new SqlConnection(this.cadenaConexion);
            this.com = new SqlCommand();

            this.com.Connection = this.connect;
        }

        public void InsertarCoche(Coche coche) {

            string sql = "INSERT INTO COCHES VALUES (@CODIGO,@MARCA,@MODELO,@COLOR,@IMAGEN,@FECHA)";

            SqlParameter codigo_coche = new SqlParameter("@CODIGO",coche.Cod_Coche);
            SqlParameter marca = new SqlParameter("@MARCA",coche.Marca);
            SqlParameter modelo = new SqlParameter("@MODELO",coche.Modelo);

            SqlParameter color = new SqlParameter("@COLOR",coche.Color);
            SqlParameter imagen = new SqlParameter("@IMAGEN",coche.Imagen);
            SqlParameter fecha = new SqlParameter("@FECHA",coche.fechaInscripcion);

            this.com.Parameters.Add(codigo_coche);
            this.com.Parameters.Add(marca);
            this.com.Parameters.Add(modelo);

            this.com.Parameters.Add(color);
            this.com.Parameters.Add(imagen);
            this.com.Parameters.Add(fecha);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();

            int insertado = this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

        }

        public List<String> MostrarCoches(bool color=false,bool marca=false,bool modelo=false,bool fecha=false) {

            List<String> result = new List<string>();
            int cantidad = 0;

            if (color==true) {

                string sql = "SELECT COUNT(Cod_Coche) AS CANTIDAD,COLOR FROM COCHES GROUP BY COLOR";

                this.com.CommandType = System.Data.CommandType.Text;
                this.com.CommandText = sql;

                this.connect.Open();
                this.reader = this.com.ExecuteReader();

                while (this.reader.Read()) {

                    cantidad = (int)this.reader["CANTIDAD"];
                    result.Add(this.reader["COLOR"].ToString()+":"+cantidad.ToString());
                }

                this.reader.Close();
                this.connect.Close();
            }

            if (marca == true) {

                string sql = "SELECT COUNT(Cod_Coche) AS CANTIDAD,MARCA FROM COCHES GROUP BY MARCA";

                this.com.CommandType = System.Data.CommandType.Text;
                this.com.CommandText = sql;

                this.connect.Open();
                this.reader = this.com.ExecuteReader();

                while (this.reader.Read()) {

                    cantidad = (int)this.reader["CANTIDAD"];
                    result.Add(this.reader["MARCA"].ToString() + ":" + cantidad.ToString());

                }

                this.reader.Close();
                this.connect.Close();
            }


            return result;

        }
    }
}
