using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab4_1.Models
{
    public class CCircle : CShape
    {

        public override void DrawItself(Graphics gfx)
        {
            Debug.WriteLine("CCircle.DrawItself()");
            throw new NotImplementedException();
        }
    }
}
