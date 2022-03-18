using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class DBManager : IDisposable
    {

        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDA;
        DataTable DT;

        public DBManager()
        {
            try
            {
                sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString );
                sqlCmd = new SqlCommand( "" , sqlCn );
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlDA = new(sqlCmd);
                DT = new DataTable();
            }
            catch (Exception ex)
            {
                //Log Exception
            }
        }

        public int ExecuteNonQuery (string SPName)
        {
            int R = -1;
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                if ( sqlCn.State== ConnectionState.Closed )
                    sqlCn.Open();

                R= sqlCmd.ExecuteNonQuery();

                sqlCn.Close();
            }
            catch ( Exception ex )
            {

            }
            return R;
        }
        public object ExecuteScaler (string SPName)
        {
            object R = new();
            try
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                R = sqlCmd.ExecuteScalar();

                sqlCn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }
        public DataTable ExecuteDataTable ( string SPName)
        {
            try
            {
                DT.Clear();
                sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = SPName;

                sqlDA.Fill(DT);
                return DT;
            }
            catch (Exception ex)
            {

            }
            return new();
        }

        public int ExecuteNonQuery(string SPName , Dictionary<string,object> Parms)
        {
            int R = -1;
            try
            {
                sqlCmd.Parameters.Clear();
              
                foreach (var item in Parms)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = SPName;

                if (sqlCn.State == ConnectionState.Closed)
                    sqlCn.Open();

                R = sqlCmd.ExecuteNonQuery();

                sqlCn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }
        public object ExecuteScaler(string SPName , Dictionary<string, object> Parms)
        {
            throw new NotImplementedException();
        }
        public DataTable ExecuteDataTable(string SPName, Dictionary<string, object> Parms)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            try
            {
                sqlCn?.Dispose();
            }
            catch
            {

            }
        }
    }
}