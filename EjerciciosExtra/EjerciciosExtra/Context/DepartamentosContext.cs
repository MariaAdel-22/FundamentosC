using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using EjerciciosExtra.Models;

#region PROCEDIMIENTOS

/*
 CREATE PROCEDURE GET_DEPARTAMENTOS
AS
	SELECT * FROM DEPT;
GO
 */

/*
 CREATE PROCEDURE GET_EMPLEADOS (@COD_DEPT INT)
AS
	SELECT * FROM EMP WHERE DEPT_NO=@COD_DEPT
GO

 */

/*
 CREATE PROCEDURE CONT_EMPLEADOS (@COD_DEPT INT)
AS
	SELECT COUNT(EMP_NO) AS EMPLEADOS FROM EMP WHERE DEPT_NO=@COD_DEPT
GO
 */

/*
 CREATE PROCEDURE INSERTAR_EMPLEADO (@EMP_NO INT, @APELLIDO NVARCHAR(50), @OFICIO NVARCHAR(50), @DIR INT, @FECHA_ALT DATETIME,
@SALARIO INT, @COMISION INT, @DEPT_NO INT)
AS
	INSERT INTO EMP VALUES(@EMP_NO,@APELLIDO,@OFICIO,@DIR,@FECHA_ALT,@SALARIO,@COMISION,@DEPT_NO);
GO
 */
#endregion

namespace EjerciciosExtra.Context
{
    public class DepartamentosContext
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public DepartamentosContext() {

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            string cadenaconexion = config["hospitalBBDD"];

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();

            this.com.Connection = this.connect;

        }

        public List<Departamento> GetDepartamentos() {

            List<Departamento> Departamentos = new List<Departamento>();

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "GET_DEPARTAMENTOS";
            this.connect.Open();

            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                Departamento dep = new Departamento();

                dep.Dept_no = int.Parse(this.reader["DEPT_NO"].ToString());
                dep.Dnombre = this.reader["DNOMBRE"].ToString();
                dep.Loc = this.reader["LOC"].ToString();

                Departamentos.Add(dep);
            }

            this.reader.Close();
            this.connect.Close();

            return Departamentos;
        }

        public List<Empleado> GetEmpleado(int cod_dept) {

            List<Empleado> Empleados = new List<Empleado>();

            this.com.Parameters.AddWithValue("@COD_DEPT",cod_dept);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "GET_EMPLEADOS";

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                Empleado emp = new Empleado();

                emp.Emp_no = int.Parse(this.reader["EMP_NO"].ToString());
                emp.Dept_no = int.Parse(this.reader["DEPT_NO"].ToString());
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Comision = int.Parse(this.reader["COMISION"].ToString());
                emp.Dir = int.Parse(this.reader["DIR"].ToString());
                emp.Fecha_alt = DateTime.Parse(this.reader["FECHA_ALT"].ToString());
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());

                Empleados.Add(emp);
            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

            return Empleados;
        }

        public int CantEmpleados(int cod_dept) {

            int empleados = 0;

            this.com.Parameters.AddWithValue("@COD_DEPT", cod_dept);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "CONT_EMPLEADOS";

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                empleados = int.Parse(this.reader["EMPLEADOS"].ToString());
            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

            return empleados;
        }

        public void InsertarEmpleado(Empleado emp) {

            this.com.Parameters.AddWithValue("@EMP_NO", emp.Emp_no);
            this.com.Parameters.AddWithValue("@APELLIDO", emp.Apellido);
            this.com.Parameters.AddWithValue("@OFICIO", emp.Oficio);
            this.com.Parameters.AddWithValue("@DIR", emp.Dir);
            this.com.Parameters.AddWithValue("@FECHA_ALT", emp.Fecha_alt);
            this.com.Parameters.AddWithValue("@SALARIO", emp.Salario);
            this.com.Parameters.AddWithValue("@COMISION", emp.Comision);
            this.com.Parameters.AddWithValue("@DEPT_NO", emp.Dept_no);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "INSERTAR_EMPLEADO";

            this.connect.Open();

            this.com.ExecuteNonQuery();

            this.connect.Close();
        }
    }
}
