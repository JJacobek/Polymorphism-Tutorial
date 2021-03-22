﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    class Dog : Animal
    {
        // Field
        private string _name;

        // Constructor
        public Dog(string name)
            : base("Dog")
        {
            _name = name;
        }

        // Name Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // MakeSound method
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }
    }
}
