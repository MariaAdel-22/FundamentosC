using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

#region PROCEDIMIENTOS ALMACENADOS

/*
 CREATE PROCEDURE INSERTAR_COCHE (@COD_COCHE INT, @MARCA NVARCHAR(50), @MODELO NVARCHAR(50), @COLOR NVARCHAR(50), @IMAGEN IMAGE, @FECHA DATETIME)
AS
	INSERT INTO COCHES VALUES (@COD_COCHE, @MARCA,@MODELO,@COLOR,@IMAGEN,@FECHA)
GO
 */

/*
CREATE PROCEDURE BUSCAR_COCHE (@TIPO NVARCHAR(50))
AS
	IF(@TIPO = 'Color')
	BEGIN
		SELECT COUNT(Cod_Coche) AS CANTIDAD,COLOR FROM COCHES GROUP BY COLOR
	END
	ELSE

	IF(@TIPO = 'Marca')
	BEGIN
		SELECT COUNT(Cod_Coche) AS CANTIDAD,Marca FROM COCHES GROUP BY Marca
	END
	ELSE

	IF(@TIPO = 'Modelo')
	BEGIN
		SELECT COUNT(Cod_Coche) AS CANTIDAD,Modelo FROM COCHES GROUP BY Modelo
	END
	ELSE

	IF(@TIPO = 'Fecha')
	BEGIN
		SELECT COUNT(Cod_Coche) AS CANTIDAD,FechaInscripcion FROM COCHES GROUP BY FechaInscripcion
	END

	IF(@TIPO = 'Todos')
	BEGIN
		SELECT * FROM COCHES
	END
	ELSE

	BEGIN
		SELECT * FROM COCHES WHERE Cod_Coche=@TIPO
	END
	
GO
 */

/*
CREATE PROCEDURE MODIFICAR_COCHE (@COD_COCHE INT, @MARCA NVARCHAR(50),@MODELO NVARCHAR(50),@COLOR NVARCHAR(50), @IMAGEN IMAGE,
@FECHA DATETIME)
AS
	UPDATE COCHES SET Marca=@MARCA, Modelo=@MODELO, Color=@COLOR, Imagen=@IMAGEN,FechaInscripcion=@FECHA WHERE
	Cod_Coche=@COD_COCHE
GO
 */

/*
 CREATE PROCEDURE ELIMINAR_COCHE (@COD_COCHE INT)
AS
	DELETE FROM COCHES WHERE Cod_Coche=@COD_COCHE;	
GO
 */
#endregion

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
        
        //Con éste método insertamos cada coche a la BBDD
        public void InsertarCoche(Coche coche) {

            SqlParameter codigo_coche = new SqlParameter("@COD_COCHE",coche.Cod_Coche);
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

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "INSERTAR_COCHE";

            this.connect.Open();

            int insertado = this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

        }

        //Dependiendo de qué parámetro es true o false, a la base de datos le pasa un tipo string donde dice de qué tipo es y hace la búsqueda
        public List<String> MostrarCoches(bool color=false,bool marca=false,bool modelo=false,bool fecha=false,bool todos=false) {

            List<String> result = new List<string>();
            String tipo = "";
            int cantidad = 0;

            if (color==true) {

                tipo = "Color";

                SqlParameter pmColor = new SqlParameter("@TIPO",tipo);
                this.com.Parameters.Add(pmColor);

                this.com.CommandType=System.Data.CommandType.StoredProcedure;
                this.com.CommandText = "BUSCAR_COCHE";

                this.connect.Open();
                this.reader = this.com.ExecuteReader();

                while (this.reader.Read()) {

                    cantidad = (int)this.reader["CANTIDAD"];
                    result.Add(this.reader["Color"].ToString()+":"+cantidad.ToString());
                }

                this.reader.Close();
                this.connect.Close();
                this.com.Parameters.Clear();
            }

            if (marca == true) {

                tipo = "Marca";

                SqlParameter pmMarca = new SqlParameter("@TIPO",tipo);
                this.com.Parameters.Add(pmMarca);

                this.com.CommandType = System.Data.CommandType.StoredProcedure;
                this.com.CommandText = "BUSCAR_COCHE";

                this.connect.Open();
                this.reader = this.com.ExecuteReader();

                while (this.reader.Read()) {

                    cantidad = (int)this.reader["CANTIDAD"];
                    result.Add(this.reader["Marca"].ToString() + ":" + cantidad.ToString());

                }

                this.reader.Close();
                this.connect.Close();
                this.com.Parameters.Clear();
            }

            if (modelo == true) {

                tipo = "Modelo";

                SqlParameter pmModelo = new SqlParameter("@TIPO",tipo);
                this.com.Parameters.Add(pmModelo);

                this.com.CommandType = System.Data.CommandType.StoredProcedure;
                this.com.CommandText = "BUSCAR_COCHE";

                this.connect.Open();
                this.reader = this.com.ExecuteReader();

                while (this.reader.Read()) {

                    cantidad = (int)this.reader["CANTIDAD"];
                    result.Add(this.reader["Modelo"].ToString()+":"+cantidad.ToString());
                }

                this.reader.Close();
                this.connect.Close();
                this.com.Parameters.Clear();
            }

            if (fecha == true) {

                tipo = "Fecha";

                SqlParameter pmFecha = new SqlParameter("@TIPO",tipo);
                this.com.Parameters.Add(pmFecha);

                this.com.CommandType = System.Data.CommandType.StoredProcedure;
                this.com.CommandText = "BUSCAR_COCHE";

                this.connect.Open();
                this.reader = this.com.ExecuteReader();

                while (this.reader.Read()) {

                    cantidad = (int)this.reader["CANTIDAD"];
                    result.Add(this.reader["FechaInscripcion"].ToString()+":"+cantidad);
                }

                this.reader.Close();
                this.connect.Close();
                this.com.Parameters.Clear();
            }

            if (todos == true) {

                tipo = "Todos";
                SqlParameter pmTodos = new SqlParameter("@TIPO", tipo);
                this.com.Parameters.Add(pmTodos);

                this.com.CommandType = System.Data.CommandType.StoredProcedure;
                this.com.CommandText = "BUSCAR_COCHE";

                this.connect.Open();
                this.reader = this.com.ExecuteReader();


                while (this.reader.Read())
                {

                   result.Add(this.reader["Marca"].ToString() + "-" + this.reader["Modelo"].ToString());
                }

                this.reader.Close();
                this.connect.Close();
                this.com.Parameters.Clear();

            }

            return result;

        }

        //Éste método busca al coche por su código de coche pasado en el formulario (su posición en la lista)
        public Coche CargarCoche(int cod_coche) {

            Coche coche = new Coche();

            SqlParameter pmCodCoche = new SqlParameter("@TIPO", cod_coche);
            this.com.Parameters.Add(pmCodCoche);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BUSCAR_COCHE";

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                coche.Cod_Coche = int.Parse(this.reader["Cod_Coche"].ToString());
                coche.Marca = this.reader["Marca"].ToString();
                coche.Modelo = this.reader["Modelo"].ToString();

                coche.Color = this.reader["Color"].ToString();
                coche.Imagen = (byte[])this.reader["Imagen"];
                coche.fechaInscripcion = DateTime.Parse(this.reader["FechaInscripcion"].ToString());
            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

            return coche;
        }

        //Con éste método cargamos todos los coches en el listado al inicializar el formulario
        public List<String>CargarCoches() {

            List<String> listado = new List<string>();
            listado = this.MostrarCoches(todos: true);

            return listado;
        }

        //Con éste método modificamos el obj pasado por parámetro con el que hay en la BBDD
        public void ModificarCoche(Coche coche) {

            SqlParameter pmCodNew = new SqlParameter("@COD_COCHE",coche.Cod_Coche);
            SqlParameter pmMarca = new SqlParameter("@MARCA",coche.Marca);

            SqlParameter pmModelo = new SqlParameter("@MODELO",coche.Modelo);
            SqlParameter pmColor = new SqlParameter("@COLOR",coche.Color);
            SqlParameter pmImagen = new SqlParameter("@IMAGEN", coche.Imagen);
            SqlParameter pmFecha = new SqlParameter("@FECHA",coche.fechaInscripcion);

            this.com.Parameters.Add(pmCodNew);
            this.com.Parameters.Add(pmMarca);

            this.com.Parameters.Add(pmModelo);
            this.com.Parameters.Add(pmColor);
            this.com.Parameters.Add(pmImagen);
            this.com.Parameters.Add(pmFecha);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "MODIFICAR_COCHE";

            this.connect.Open();
            this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

        }

        //Eliminamos el coche cuyo código de coche sea el pasado por parámetro
        public void EliminarCoche(int cod_coche) {

            SqlParameter pmCodCoche = new SqlParameter("@COD_COCHE", cod_coche);
            this.com.Parameters.Add(pmCodCoche);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "ELIMINAR_COCHE";

            this.connect.Open();
            this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();
        }
    }
}
