using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab4_2.ViewModels
{
    public interface IMainWindowView
    {
        void OnModelUpdated(object sender, EventArgs e);
    }
}
