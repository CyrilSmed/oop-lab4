using oop_lab4_1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_lab4_1.Models;

namespace oop_lab4_1.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public IMainWindowView View { get; set; }
        public MainWindowViewModel(IMainWindowView view)
        {
            View = view;
        }

        Container<CShape> _container;
        Container<CShape> Container { get { return _container; } }
    }
}
