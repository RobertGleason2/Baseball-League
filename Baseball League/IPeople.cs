using System;
using System.Collections.Generic;
using System.Text;

namespace Baseball_League
{
    public interface IPeople
    {
        string FirstName { set; get; }
        string LastName { set; get; }
        string FullName { get; }
    }
}
