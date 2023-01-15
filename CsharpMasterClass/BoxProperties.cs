using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMasterClass
{
    class BoxProperties
    {
        //examaple of member variables- variables on the class level. direct impact ont the appearance of the box

        private int length;
       private int height;
        private int width;
       

        public BoxProperties(int length, int height, int width)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            
        }
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("Length cannot be less than 0");
                }
                else

                    length = value;
            }
        }
     

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                height = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Width cannot be less than 0");

                }
                else width = value;
            }
        }

        public int Volume
        {
            get { return this.length * this.width * this.height; }
        
        }

        public int FrontSurface
        {
            get
            {
                return this.height * this.length;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2} and volume is {3}", length, width, height, Volume);
        }

    }
}
