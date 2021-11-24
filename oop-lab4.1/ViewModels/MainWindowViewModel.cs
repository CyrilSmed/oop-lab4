using oop_lab4._1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab4._1.ViewModels
{
    internal class MainWindowViewModel : ObservableObject
    {
        public RelayCommand CommandExample { get; set; }

        public IMainWindowView View { get; set; }

        public MainWindowViewModel()
        {
            CommandExample = new RelayCommand(o =>
           {

           });
        }

    }
}
