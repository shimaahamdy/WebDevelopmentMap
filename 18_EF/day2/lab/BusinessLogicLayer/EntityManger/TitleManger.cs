using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public static class TitleManger
    {
        static DataBaseManger manger = new();
        static TitleList titLst = new TitleList();

        //select all titles objects
        public static TitleList SelectAllTitles()
        {
            try
            {
               
                titLst = DataTable2TitleList(manger.ExecuteDataTable("SelectAllTitles"));
                return titLst;
            }
            catch (Exception ex)
            {

            }
            return new();
        }
        public static void updateAllTitiles()
        {
            try
            {
                TitleList2DataTable(manger.getDataTable());
                manger.update();
            }
            catch (Exception ex)
            {

            }
        }


      
       
        #region mapping title table to list of objects
        internal static TitleList DataTable2TitleList(DataTable Dt)
        {
            TitleList TitLst = new();
            try
            {
                for (int i = 0; i < Dt?.Rows.Count; i++)
                {
                    TitLst.Add(DataRow2Title(Dt.Rows[i]));
                }
            }
            catch (Exception ex)
            {

            }
            return TitLst;
        }
        internal static Title DataRow2Title(DataRow Dr)
        {
            Title t = new();
            try
            {
                t.title_id = Dr["title_id"]?.ToString() ?? "NA";
                t.title = Dr["title"]?.ToString() ?? "NA";
                t.type = Dr["type"]?.ToString() ?? "NA";
                t.pub_id = Dr["pub_id"]?.ToString() ?? "NA";
                
                if (decimal.TryParse(Dr["price"]?.ToString() ?? "-1", out decimal TempDec))
                    t.price = TempDec;

                if (decimal.TryParse(Dr["advance"]?.ToString() ?? "-1", out TempDec))
                    t.advance = TempDec;

                if (int.TryParse(Dr["royalty"]?.ToString() ?? "-1", out int TempInt))
                    t.royalty = TempInt;

                if (int.TryParse(Dr["ytd_sales"]?.ToString() ?? "-1", out TempInt))
                    t.ytd_sales= TempInt;


                t.notes = Dr["notes"]?.ToString() ?? "NA";

                t.pubdate = Convert.ToDateTime(Dr["pubdate"]);
                t.State = EntityState.UnChanged;

            }
            catch (Exception ex)
            {

            }
            return t;
        }
        #endregion


        #region mapping list of objects to title table
        internal static void TitleList2DataTable(DataTable DTable)
        {
            
            
            try
            {
                TitleList t =  titLst;
                for (int i = 0; i < titLst?.Count; i++)
                {
                    if (titLst[i]?.State == EntityState.Modified)
                        modifyTitle2DataRow(DTable, titLst[i], i);

                    else if (titLst[i]?.State == EntityState.Added)
                        addTitle2DataRow(DTable, titLst[i]);

                    else if (titLst[i]?.State == EntityState.Deleted)
                    {
                        DataRow row = DTable.Rows[i];
                        row.Delete();

                    }

                }
            }
            catch (Exception ex)
            {

            }
            
        }
        internal static void modifyTitle2DataRow(DataTable DTable,Title t,int index)
        {
           
            try
            {

                DataRow row = DTable.Rows[index];

                //DataRow row = manger.DTable.Select("=title_id" + t.title_id).First();
                row["title_id"] = t.title_id;
                row["title"] = t.title;
                row["type"] = t.type;
                row["pub_id"] = t.pub_id;
                row["price"] = t.price;
                row["advance"] = t.advance;
                row["royalty"] = t.royalty;
                row["ytd_sales"] = t.ytd_sales;
                row["notes"] = t.notes;
                row["pubdate"] = t.pubdate;

            }
            catch (Exception ex)
            {

            }
            
        }
        internal static void addTitle2DataRow(DataTable DTable,Title t)
        {
            DataRow row = DTable.NewRow();
            row["title_id"] = t?.title_id ?? "BN5696";
            row["title"] = t?.title ?? "NA";
            row["type"] = t?.type ?? "business";
            row["pub_id"] = t?.pub_id ?? "1756";
            row["price"] = t?.price?? 1;
            row["advance"] = t?.advance ??1;
            row["royalty"] = t?.royalty ??0;
            row["ytd_sales"] = t?.ytd_sales ??1;
            row["notes"] = t?.notes?? "NA";

            string iDate = "05/05/2005";
            DateTime oDate = Convert.ToDateTime(iDate);

            if (t.pubdate.Year >= 1977)
                row["pubdate"] = t.pubdate;
            else row["pubdate"] = oDate;
           
            DTable.Rows.Add(row);
        }
        #endregion
    }
}
