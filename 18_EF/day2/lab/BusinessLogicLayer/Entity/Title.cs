using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Title:EntityBase
    {
        string Title_id; //6
        string Titleo; //80
        string Type;//12 F
        string? Pub_id; //4 f
        decimal? Price;
        decimal? Advance;
        int? Royalty;
        int? Ytd_sales;
        string? Notes; //200
        DateTime Pubdate;

        public string title_id
        {
            get => Title_id;
            set
            {
                if (value != Title_id && value.Length <= 6)
                {
                    Title_id = value;
                    if(this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        
        public string title
        {
            get => Titleo;
            set
            {
                if (value != Titleo && value.Length <= 80)
                {
                    Titleo = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        
        public string type
        {
            get => Type;
            set
            {
                if (value != Type && value.Length <= 12)
                {
                    Type = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        public string? pub_id
        {
            get => Pub_id;
            set
            {
                if (value != Pub_id && value.Length == 4)
                {
                    Pub_id = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        
        public decimal? price
        {
            get => Price;
            set
            {
                if (value != Price)
                {
                    Price = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        
        public decimal? advance
        {
            get => Advance;
            set
            {
                if (value != Advance)
                {
                    Advance = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
         
        public int? royalty
        {
            get => Royalty;
            set
            {
                if (value != Royalty)
                {
                    Royalty = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }

        public int? ytd_sales
        {
            get => Ytd_sales;
            set
            {
                if (value != Ytd_sales)
                {
                    Ytd_sales = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
    
        public string? notes
        {
            get => Notes;
            set
            {
                if (value != Notes && value.Length <= 200)
                {
                    Notes = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }
        
        public DateTime pubdate
        {
            get => Pubdate;
            set
            {
                if (value != Pubdate)
                {
                    Pubdate = value;
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Modified;
                }
            }
        }


    }
}
