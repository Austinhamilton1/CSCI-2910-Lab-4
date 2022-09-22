using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_2910_Lab_4
{
    public class FileRoot
    {
        static private string _root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
        static public string Root { get { return _root; } }
    }
}
