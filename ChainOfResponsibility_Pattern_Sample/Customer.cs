using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Sample;
public class Customer
{
    public string Password { get; set; }
    public int AccountValue { get; set; }
    public bool IsActive { get; set; }
}
