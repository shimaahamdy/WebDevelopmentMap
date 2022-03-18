using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataBaseManger
    {
        SqlConnection sqlConn;  //to connect with database
        SqlCommand sqlCmd;    //commands that will applied to database
        SqlCommand sqlCmd2;
        internal DataTable DTable;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        SqlCommandBuilder updateTable;

        
        public DataBaseManger()
        {
            try
            {
                sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["pubsCN"].ConnectionString);
                sqlCmd = new SqlCommand("select *from titles", sqlConn);
                //sqlCmd2 = new SqlCommand("select *from titles", sqlConn);
                //sqlCmd.CommandType = CommandType.StoredProcedure;

                DTable = new DataTable();
                adapter = new(sqlCmd);
                //adapter2 = new(sqlCmd2);

                updateTable = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = updateTable.GetInsertCommand();
                adapter.UpdateCommand = updateTable.GetUpdateCommand();
                adapter.DeleteCommand = updateTable.GetDeleteCommand();

                //updateTable = new SqlCommandBuilder(adapter2);
                //adapter2.InsertCommand = updateTable.GetInsertCommand();
                //adapter2.UpdateCommand = updateTable.GetUpdateCommand();
                //adapter2.DeleteCommand = updateTable.GetDeleteCommand();



            }
            catch (Exception ex)
            {
                //Log Exception
            }
        }
        public DataTable getDataTable()
        {
            return DTable;
        }
        public int ExecuteNonQuery(string StoredProcedure)
        {
            int R = -1;
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = StoredProcedure;

                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();

                R = sqlCmd.ExecuteNonQuery();

                sqlConn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }

        public object ExecuteScaler(string StoredProcedure)
        {
            object R = new();
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = StoredProcedure;

                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();

                R = sqlCmd.ExecuteScalar();

                sqlConn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }

        public DataTable ExecuteDataTable(string StoredProcedure)
        {
            try
            {
                DTable.Clear();
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = StoredProcedure;

                adapter.Fill(DTable);
                return DTable;
            }
            catch (Exception ex)
            {

            }
         
            return new DataTable();
        }

        public int ExecuteNonQuery(string StoredProcedure, Dictionary<string, object> Parmeters)
        {
            int R = -1;
            try
            {
                sqlCmd.Parameters.Clear();

                foreach (var item in Parmeters)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = StoredProcedure;

                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();

                R = sqlCmd.ExecuteNonQuery();

                sqlConn.Close();
            }
            catch (Exception ex)
            {

            }
            return R;
        }

        public object ExecuteScaler(string StoredProcedure, Dictionary<string, object> Parmeters)
        {
            object R = new();
            try
            {
                sqlCmd.Parameters.Clear();

                foreach (var item in Parmeters)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = StoredProcedure;

                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();

                R = sqlCmd.ExecuteScalar();

                sqlConn.Close();
            }
            catch (Exception e)
            {

            }
            return R;
        }
        
        public DataTable ExecuteDataTable(string StoredProcedure, Dictionary<string, object> Parmeters)
        {
            try
            {
                DTable.Clear();
                sqlCmd.Parameters.Clear();

                foreach (var item in Parmeters)
                    sqlCmd.Parameters.Add(new SqlParameter(item.Key, item.Value));

                sqlCmd.CommandText = StoredProcedure;

                adapter.Fill(DTable);
                return DTable;
            }
            catch (Exception ex)
            {

            }
            return new DataTable();
        }

        public void Dispose()
        {
            try
            {
                sqlConn?.Dispose();
            }
            catch
            {

            }
        }
    
        public void update()
        {
            adapter.Update(DTable);
        }
    }
}