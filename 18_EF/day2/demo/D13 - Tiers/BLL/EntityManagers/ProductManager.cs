using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ProductManager
    {
        static DBManager dBmanager = new();
       
        public static ProductList SelectAllProducts()
        {
            try
            {
                return DataTable2ProductList(
                dBmanager.ExecuteDataTable("SelectAllProducts"));
            }
            catch (Exception ex)
            {

            }
            return new();
        }

        public static bool DeleteProductByID (int ProductId)
        {
            try
            {
                Dictionary<string, object> Parms = new() { ["ProductId"] = ProductId };
                
                return dBmanager.ExecuteNonQuery("DeleteProductByID" , Parms) > 0;
            }
            catch
            {

            }
            return false;
        }

        #region Mapping

        internal static ProductList DataTable2ProductList (DataTable Dt)
        {
            ProductList PrdLst = new();
            try
            {
                for ( int i=0; i < Dt?.Rows.Count; i++ )
                {
                    PrdLst.Add(DataRow2Product(Dt.Rows[i]));
                }
            }
            catch ( Exception ex )
            {

            }
            return PrdLst;
        }


        internal static Product DataRow2Product (DataRow Dr)
        {
            Product P = new();
            try
            {
                if (int.TryParse(Dr["ProductID"]?.ToString()??"-1", out int TempInt))
                    P.ProductID = TempInt;

                P.ProductName = Dr["ProductName"]?.ToString() ?? "NA";

                P.QuantityPerUnit = Dr["QuantityPerUnit"]?.ToString() ?? "NA";

                if (short.TryParse(Dr["ReorderLevel"]?.ToString() ?? "-1", out short TempShort))
                    P.ReorderLevel = TempShort;

                if (short.TryParse(Dr["UnitsInStock"]?.ToString() ?? "-1", out  TempShort))
                    P.UnitsInStock = TempShort;

                if (short.TryParse(Dr["UnitsOnOrder"]?.ToString() ?? "-1", out TempShort))
                    P.UnitsOnOrder = TempShort;

                if (int.TryParse(Dr["SupplierID"]?.ToString() ?? "-1", out TempInt))
                    P.SupplierID = TempInt;

                if (int.TryParse(Dr["CategoryID"]?.ToString() ?? "-1", out TempInt))
                    P.CategoryID = TempInt;

                if (bool.TryParse(Dr["Discontinued"]?.ToString() , out bool TempBool))
                    P.Discontinued = TempBool;

                if ( decimal.TryParse (Dr["UnitPrice"]?.ToString(), out decimal TempDecimal))
                    P.UnitPrice = TempDecimal;

                P.State = EntityState.UnChanged;

            }
            catch (Exception ex)
            {

            }
            return P;
        }


        #endregion
    }
}
