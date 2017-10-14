using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CURDdemo.Models;

namespace CURDdemo.BLL
{
    public class DepartmentBLL:CommonGateway
    {
        public string SaveDepartmentInfo(Department department)
        {
            string Message = String.Empty;
            command = new SqlCommand("uspSaveDepartmentInfo", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("DepartmentName", department.DepartmentName);
            command.Parameters.AddWithValue("DepartmentCode", department.DepartmentCode);

            connection.Open();
            int RowAffected = command.ExecuteNonQuery();
            if (RowAffected > 0)
            {
                Message = "Save Sucessfull.";
            }
            else
            {
                Message = "Failed";
            }
            connection.Close();
            return Message;
        }

        public List<Department> GellAllDepartmentList()
        {
            command = new SqlCommand("uspGellAllDepartmentList", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            List<Department> listOfDepartment=new List<Department>();
            Department department;
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    department=new Department();
                    department.DeptId = Convert.ToInt32(dataReader["DeptId"].ToString());
                    department.DepartmentName = dataReader["DepartmentName"].ToString();
                    department.DepartmentCode = dataReader["DepartmentCode"].ToString();
                    listOfDepartment.Add(department);
                }
            }
            connection.Close();
            return listOfDepartment;
        }
    }
}