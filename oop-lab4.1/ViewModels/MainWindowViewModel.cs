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

        Container<CCircle> _shapeContainer = new Container<CCircle>();
        public Container<CCircle> ShapeContainer { get { return _shapeContainer; } }

        public void AddCircle(int posX, int posY)
        {
            ShapeContainer.Append(new CCircle(posX, posY));
        }
        public bool SelectCircleAt(int posX, int posY)
        {
            bool oneOrMoreSelected = false;
            for (ShapeContainer.First();
                 ShapeContainer.IsEOL() == false;
                 ShapeContainer.Next())
            {
                if(ShapeContainer.GetCurrent().IfInside(posX, posY))
                {
                    ShapeContainer.GetCurrent().SwitchSelection();
                    oneOrMoreSelected = true;
                }
            }
            return oneOrMoreSelected;
        }
    }
}
