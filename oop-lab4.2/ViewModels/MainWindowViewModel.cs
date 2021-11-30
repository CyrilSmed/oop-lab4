using oop_lab4_2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_lab4_2.Models;

namespace oop_lab4_2.ViewModels
{
    internal class MainWindowViewModel
    {

        internal IMainWindowView View { get; set; }

        public Model model { get; private set; }

        public MainWindowViewModel(IMainWindowView view)
        {
            View = view;
            model = new Model();
            model.modelUpdated += View.OnModelUpdated;
        }


    }
}