using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class PuplisherManger
    {
        static DataBaseManger manger = new();
        static PublisherList pubLst = new PublisherList();

        //select all titles objects
        public static PublisherList SelectAllPulishers()
        {
            try
            {

                pubLst = PubTable2PubList(manger.ExecuteDataTable("SelectAllPublishers"));
                return pubLst;
            }
            catch (Exception ex)
            {

            }
            return new();
        }
     

        #region mapping title table to list of objects
        internal static PublisherList PubTable2PubList(DataTable Dt)
        {
            PublisherList pubList = new();
            try
            {
                for (int i = 0; i < Dt?.Rows.Count; i++)
                {
                    pubList.Add(DataRow2Pub(Dt.Rows[i]));
                }
            }
            catch (Exception ex)
            {

            }
            return pubList;
        }
        internal static Publisher DataRow2Pub(DataRow Dr)
        {
            Publisher p = new();
           
            try
            {
                p.pub_id = Dr["pub_id"]?.ToString() ?? "NA";
                p.pub_name = Dr["pub_name"]?.ToString() ?? "NA";
                //p.city = Dr["city"]?.ToString() ?? "NA";
                //p.country = Dr["country"]?.ToString() ?? "NA";
                //p.state = Dr["state"]?.ToString() ?? "NA";

                //p.State = EntityState.UnChanged;

            }
            catch (Exception ex)
            {

            }
            return p;
        }
        #endregion


    }
}
