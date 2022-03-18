using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomePage
{
    public class person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public char Gender { get; set; }
        public string Country { get; set; }
        public person(int id,string _name,int _age,char _gender,string country)
        {
            Id = id;
            name = _name;
            age = _age;
            Gender = _gender;
            Country = country;
        }
        
        
    }
}