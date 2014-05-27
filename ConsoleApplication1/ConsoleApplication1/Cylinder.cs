using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cylinder
    {
        #region Properties
        // auto-implemented properties
        public double Radius { get; protected set; }
        public double Height { get; protected set; }
        // regular property - getter only
        public double Volume
        {
            get
            {
                double result = Math.PI * Radius * Radius * Height;
                return result;
            }
        }
        #endregion

        #region Constructors
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;

        }
        #endregion

        #region methods

        public static Cylinder operator +(Cylinder leftSide, Cylinder rightSide)
        {
            Cylinder result = new Cylinder(leftSide.Radius, leftSide.Height + rightSide.Height);
            return result;

        }
        

#endregion

    }
}
