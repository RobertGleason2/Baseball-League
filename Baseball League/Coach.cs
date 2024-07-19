using System;
using System.Collections.Generic;
using System.Text;

namespace Baseball_League
{
    public enum TITLE { MAIN, ASSISTENT}
    public class Coach : IPeople
    {
        private string _firstName;
        private string _lastName;
        private TITLE _title;
        public string FirstName { set { _firstName = value; } get { return _firstName; } }
        public string LastName { set { _lastName = value; } get { return _lastName; } }
        public string FullName { get { return FirstName + " " + LastName; } }
        public TITLE Title { set { _title = value; } get { return _title; } }
        public Coach() : this("No Last Name") { }

        public Coach(string lastName) : this("No First Name", lastName) { }
        public Coach(string firstName, string lastName) : this(firstName, lastName, TITLE.ASSISTENT) { }

        //Designated Constructor
        public Coach(string firstName, string lastName, TITLE title)
        {
            FirstName = firstName;
            LastName = lastName;
            title = Title;

        }
        override
        public string ToString()
        {
            return FirstName + " " + LastName + ", " + Title;
        }
    }
}
