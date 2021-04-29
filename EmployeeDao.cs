using BussinessObject;
using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class EmployeeDao
    {
        string constr = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();


        public async Task<Employee> CreateEmployees(Employee employee)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Name", employee.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Address", employee.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Salary", employee.Salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Experience", employee.Experience, dbType: DbType.Int32, direction: ParameterDirection.Input);
            
            try
            {
               using(var con=new SqlConnection(constr))
                {
                    var task = await con.QueryMultipleAsync("CreateEmployees", param, commandType: CommandType.StoredProcedure);
                    var result = task.Read<Employee>().SingleOrDefault();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", employee.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Name", employee.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Address", employee.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Salary", employee.Salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Experience", employee.Experience, dbType: DbType.Int32, direction: ParameterDirection.Input);

            try
            {
                using (var con = new SqlConnection(constr))
                {
                    var task = await con.QueryMultipleAsync("UpdateEmployees", param, commandType: CommandType.StoredProcedure);
                    var result = task.Read<Employee>().SingleOrDefault();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> GetEmployeeById(Employee employee)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", employee.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Name", employee.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Address", employee.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Salary", employee.Salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Experience", employee.Experience, dbType: DbType.Int32, direction: ParameterDirection.Input);

            try
            {
                using (var con = new SqlConnection(constr))
                {
                    var task = await con.QueryMultipleAsync("GetEmployeeById", param, commandType: CommandType.StoredProcedure);
                    var result = task.Read<Employee>().SingleOrDefault();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> DeleteEmployeeByName(Employee employee)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", employee.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Name", employee.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Address", employee.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@Salary", employee.Salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Experience", employee.Experience, dbType: DbType.Int32, direction: ParameterDirection.Input);

            try
            {
                using (var con = new SqlConnection(constr))
                {
                    var task = await con.QueryMultipleAsync("DeleteEmployeeByName", param, commandType: CommandType.StoredProcedure);
                    var result = task.Read<Employee>().SingleOrDefault();
                    return result;
                }

               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
