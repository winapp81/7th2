using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_7th
{

    interface IListable
    {
        string[] ColumnValues
        {
            get;
        }
    }
    public abstract class PdaItem
    {
        public virtual string Name
        {
            get;set;
        }
        public PdaItem(string name)
        {
            this.Name = name;
        }

    } // base class pdaItem

    public class Contact : PdaItem, IListable  //반드시 클래스가 인터페이스 앞에
    {
        //public Contact()
        //{
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Contact(string fName, string lName,string address, string phone ) : base(null)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Address = address;
            this.Phone = phone;
        }



        //string[] IListable.ColumnValues => throw new NotImplementedException();
        //public string[] ColumnValues => throw new NotImplementedException();
        public string[] ColumnValues
        {
            get
            {
                return new string[]
                    { FirstName,
                    LastName,
                    Phone,
                    Address
                    };
            }
        }

        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "First NAme", "Last Name      "  ,
                    "Phone         ",
                    "Address                  "
                };
            }
        }
    } // class Contact


    class Publication : IListable
    {
        
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Publication(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }

        public string[] ColumnValues
        {
            get
            {
                return new string[]
                {
                    this.Title,
                    this.Author,
                    this.Year.ToString()
                };
            }
        }//columnValues

        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "Title",
                    "Author",
                    "Year"
                };
            }
        }//Headers

    }// class publication


    class Program
    {
        public static void Main()
        {
            Contact[] contacts = new Contact[2];
            contacts[0] = new Contact
            (
                "Dick", "Traci",
                "123 Main St., Spokane, WA 99037",
                "123-123-1234"
            );
            contacts[1] = new Contact
            (
                "Dick2", "Traci2",
                "222 Main St., Spokane, WA 99037",
                "222-123-1234"
            );

        }
    }
}
