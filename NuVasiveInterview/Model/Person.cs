using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuVasiveInterview.Model
{
    public class Person
    {
        private String _name;
        private DateTime _date;

        public Person(String name, DateTime date)
        {
            _name = name;
            _date = date;
        }

        #region Properties
        public String Name
        {
            get { return _name; }     
        }

        

        public DateTime Date
        {
            get { return _date; }
        }
        #endregion Properties
    }
}
