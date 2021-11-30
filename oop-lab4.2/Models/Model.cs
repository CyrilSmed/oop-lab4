using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab4_2.Models
{
    internal class Model
    {
        public EventHandler modelUpdated;
        private int _x = 0;
        public int X
        {
            get { return _x; }
            set 
            {
                value = Math.Min(100, Math.Max(0, value));
                value = Math.Max(Y, value);
                _x = value;
                modelUpdated?.Invoke(this, EventArgs.Empty);
            }
        }
        

        private int _y = 0;
        public int Y
        {
            get { return _y; }
            set 
            {
                value = Math.Min(100, Math.Max(0, value));
                value = Math.Min(X, Math.Max(Z, value));
                _y = value;
                modelUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        private int _z = 0;
        public int Z
        {
            get { return _z; }
            set 
            {
                value = Math.Min(100, Math.Max(0, value));
                value = Math.Min(Y, value);
                _z = value;
                modelUpdated?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
