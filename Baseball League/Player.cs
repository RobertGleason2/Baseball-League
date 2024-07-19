using System;
using System.Collections.Generic;
using System.Text;

namespace Baseball_League
{
    public enum POSITIONS { DESIGNATED_HITTER, PITCHER, CATCHER, FIRST_BASE, SECONND_BASE, THIRD_BASE, LEFT_FIELDER, RIGHT_FIELDER, SHORT_STOP}
    public class Player : IPeople
    {
        private string _firstName;
        private string _lastName;
        private POSITIONS _position;
        public string FirstName { set { _firstName = value; } get { return _firstName; } }
        public string LastName { set { _lastName = value; } get { return _lastName; } }
        public string FullName { get { return FirstName + " " + LastName; } }
        public POSITIONS Position { set { _position = value; } get { return _position; } }
        public Player() : this("No Last Name") { }
        public Player(string lastName) : this( "No First Name", lastName) { }
        public Player(string firstName, string lastName) : this(firstName, lastName, POSITIONS.FIRST_BASE) { }

        //Designated Constructor pattern
        public Player(string firstName, string lastName, POSITIONS position)
        {
            _firstName = firstName;
            _lastName = lastName;
            Position = position;
        }

        override
        public string ToString()
        {
            return FirstName + " " + LastName + ", " + Position;
        }
    }
}
