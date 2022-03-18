using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Publisher: EntityBase
    {
		string Pub_id;
		string? Pub_name;
		string? City;
		string? Stat;
		string? Country;
		public string pub_id
        {
			get => Pub_id;
			set
            {
				if (value != Pub_id && value.Length==4)
				{
					Pub_id = value;
					if(this.State != EntityState.Added)
					this.State = EntityState.Modified;
				}
			}
		}
		
		
		public string? pub_name
        {
			get => Pub_name;
			set
			{
				if (value != Pub_name && value.Length<=40)
				{
					Pub_name = value;
					if (this.State != EntityState.Added)
						this.State = EntityState.Modified;
				}
			}
		}
		
		public string? city
		{
			get => City;
			set
			{
				if (value != City && value.Length<=20)
				{
					City = value;
					if (this.State != EntityState.Added)
						this.State = EntityState.Modified;
				}
			}
		}
        
		public string? state
        {
			get => Stat;
			set
			{
				if (value != Stat && value.Length == 2)
				{
					Stat = value;
					if (this.State != EntityState.Added)
						this.State = EntityState.Modified;
				}
			}
		}

        public string? country
        {
			get => Country;
            set
            {
				if (value != Country && value.Length <=30)
				{
					Stat = value;
					if (this.State != EntityState.Added)
						this.State = EntityState.Modified;
				}
			}
        }
		
	}
}
