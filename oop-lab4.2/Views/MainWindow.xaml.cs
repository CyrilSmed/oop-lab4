using oop_lab4_2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oop_lab4_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowView
    {
        internal MainWindowViewModel ViewModel { get; set; }
        public MainWindow()
        {
            ViewModel = new MainWindowViewModel(this);
            DataContext = ViewModel;
            InitializeComponent();
            UpdateCoordinateValues();
        }
        public void OnModelUpdated(object sender, EventArgs e)
        {
            UpdateCoordinateValues();
        }
        public void UpdateCoordinateValues()
        {
            xTopTextBox.Text = ViewModel.model.X.ToString();
            xSlider.Value = ViewModel.model.X;
            xBottomTextBox.Text = ViewModel.model.X.ToString();

            yTopTextBox.Text = ViewModel.model.Y.ToString();
            ySlider.Value = ViewModel.model.Y;
            yBottomTextBox.Text = ViewModel.model.Y.ToString();

            zTopTextBox.Text = ViewModel.model.Z.ToString();
            zSlider.Value = ViewModel.model.Z;
            zBottomTextBox.Text = ViewModel.model.Z.ToString();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                TextBox curTextBox = (TextBox)sender;

                int result;
                if(int.TryParse(curTextBox.Text, out result))
                {
                    switch (curTextBox.Tag)
                    {
                        case "X":
                            ViewModel.model.X = result;
                            break;
                        case "Y":
                            ViewModel.model.Y = result;
                            break;
                        case "Z":
                            ViewModel.model.Z = result;
                            break;
                    }
                    
                }
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider curSlider = (Slider)sender;
            switch (curSlider.Tag)
            {
                case "X":
                    ViewModel.model.X = (int)curSlider.Value;
                    break;
                case "Y":
                    ViewModel.model.Y = (int)curSlider.Value;
                    break;
                case "Z":
                    ViewModel.model.Z = (int)curSlider.Value;
                    break;
            }
        }
    }
}
