using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace DatabaseConnectionSample.Models
{
    public class EmpDbRepository
    {

        public static List<Emp> GetEmpList()
        {
            List<Emp> emplist = new List<Emp>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if(cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();  
                }
                SqlCommand selecttempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl";
                selecttempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selecttempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    Emp emp = new Emp
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3),
                    };
                    emplist.Add(emp);
                }
            }
            return emplist;
        }
        public static Emp GetEmpById(int id)
        {
            Emp empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectEmp = "Select * from emptbl where eno=@id";
                //selectempcmd.Parameters.AddWithValue("@id", id);
                selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectEmp;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new Emp
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3),
                    };
                }
            
            }
            return empFound;
        }

        public static int AddNewEmp(Emp newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.Id;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.Name;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.City;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.Salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteEmp(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;

        }
    }
}
