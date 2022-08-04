using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
    public class Marble


    {
        public int ID { get; set; }                                        //The get method returns the value of the variable. The set method assigns a value to the variable
        public string Color { get; set; }                                      
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Ordering
        {
            get                                                                //Created a list that makes sure the color is in the order I want it to be in.
            {
                if (Color == "Red")
                    return 0;

                else if (Color == "Orange")
                {
                    return 1;
                }
                else if (Color == "Yellow")
                {
                    return 2;
                }
                else if (Color == "Green")
                {
                    return 3;
                }
                else if (Color == "Blue")
                {
                    return 4;
                }
                else if (Color == "Indigo")
                {
                    return 5;
                }
                else if (Color == "Violet")
                {
                    return 6;
                }
                else
                {
                    return -1;                                                       //If the color is something else other than the colors listed above then return -1.
                }

               } 
            }


        public Marble(int iD, string color, string name, double weight)
        {
            ID = iD;
            Color = color;
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return (" ID: " + ID + ", Color: " + Color + ", Name: " + Name + ", Weight: " + Weight);
        }

    }
}

