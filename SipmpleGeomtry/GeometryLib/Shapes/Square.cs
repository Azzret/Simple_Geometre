﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
   public class Square:Rectangle
    {
        public Square(double side) 
            : base(side, side)
        {
        }
    }
}
