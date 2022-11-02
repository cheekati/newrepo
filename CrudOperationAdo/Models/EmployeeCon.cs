using System.Data;
using System.Data.SqlClient;
namespace CrudOperationAdo.Models
{
    public class EmployeeCon
    {
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-1D4JGFHH;Initial Catalog=aspnet-RazorViewRoleBasedContenetExample-20220202061527;Integrated Security=True" providerName = "System.Data.SqlClient");
        public List<Employees> GetEmpList()
        {
            SqlCommand Con = new sqlCommand("",Con);
            Cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<EmployeeCon> empList = new List<EmployeeCon>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Employees emp = new Employees();
                emp.MGRNO = Convert.ToInt32(ds.Tables[0].Rows[i]["MGRNO"]);
                emp.QULIFICATION = Convert.ToInt32(ds.Tables[0].Rows[i]["MGRNO"]).ToString();
                emp.AMGR = Convert.ToInt32(ds.Tables[0].Rows[i]["EMPSalary"]);
                EmpList.Add(emp);

            }
            return EmpList();

        }
    }
}
