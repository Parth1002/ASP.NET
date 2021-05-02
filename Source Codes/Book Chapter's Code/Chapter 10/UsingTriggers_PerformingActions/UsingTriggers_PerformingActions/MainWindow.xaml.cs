using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace UsingTriggers_PerformingActions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Place
    {
        private string _name;

        private string _state;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Place(string name, string state)
        {
            this._name = name;
            this._state = state;
        }
    }

    public class Places : ObservableCollection<Place>
    {
        public Places()
        {
            Add(new Place("India", "INDIA"));
            Add(new Place("Australia", "AUS"));
            Add(new Place("America", "USA"));
            Add(new Place("Africa", "AFR"));
            Add(new Place("Russia", "USSR"));

        }
    }
}
