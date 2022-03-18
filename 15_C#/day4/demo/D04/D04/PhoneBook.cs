using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
   struct PhoneBook
    {
        string[] Names;
        long[] Numbers;
        int size;

        public PhoneBook()
        {
            Names = new string[5];
            Numbers = new long[5];
            size = 5;
        }

        public PhoneBook(int S)
        {
            size = S;
            Names = new string[size];
            Numbers = new long[size];
        }

        public int Size
        { get { return size; } }


        public void SetEntry ( int Index , string Name ,long Number)
        {
            if ( (Index >=0)&& (Index < size))
            {
                Names[Index] = Name;
                Numbers[Index] = Number;
            }
        }


        public long GetNumber ( string Name)
        {
            for ( int i = 0; i < size; i++)
                if ( Names[i] == Name)
                    return Numbers[i];

            return -1;
        }

        public long this [int Index , string Name]
        {
            set
            {
                if ((Index >= 0) && (Index < size))
                {
                    Names[Index] = Name;
                    Numbers[Index] = value;
                }
            }
        }


        public string this [int Index]
        {
            get
            {
                if ((Index >= 0) && (Index < size))
                    return $"{Names[Index]}:::{Numbers[Index]}";
                return "NA";
            }
        }


        public long this[string Name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                    if (Names[i] == Name)
                        return Numbers[i];
                return -1;
            }
            set
            {
                for (int i = 0; i < size; i++)
                    if (Names[i] == Name)
                        Numbers[i] = value;
            }
        }


    }
}
