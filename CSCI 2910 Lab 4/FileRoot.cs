using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_2910_Lab_4
{
    internal class FileRoot
    {
        private string _root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
        public string Root { get { return _root; } }
    }
}
