using MVCCRUD.Service;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using MVCCRUD.Models;

namespace MVCCRUD.DAL
{
    public class EmpDAL : BaseService
    {
        public List<EmpModel> Read()
        {
            List<EmpModel> empList = new List<EmpModel>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            string sqlQuery = String.Format("select EMP_ID,EMP_Name,Address from Employee;");
            command.CommandText = sqlQuery;
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                empList.Add(new EmpModel
                {
                    Id = GetDBInt(dr["EMP_ID"]),
                    Address = GetDBString(dr["Address"]),
                    Name = GetDBString(dr["EMP_Name"].ToString())
                });
            }

            return empList;
        }
    }
}