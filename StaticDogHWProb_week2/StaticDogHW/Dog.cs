using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDogHW
{
    internal class Dog
    {
        //properties
        public float Weight { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }

        //constructor
        public Dog(float pWeight, float pHeight, string pName) 
        {
            Weight = pWeight;
            Height = pHeight;
            Name = pName;
        }
    }
}
