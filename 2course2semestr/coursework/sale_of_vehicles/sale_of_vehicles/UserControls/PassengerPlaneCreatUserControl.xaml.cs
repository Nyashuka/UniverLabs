﻿using System;
using System.Collections.Generic;
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

namespace sale_of_vehicles
{
    /// <summary>
    /// Interaction logic for PassengerPlaneCreatUserControl.xaml
    /// </summary>
    public partial class PassengerPlaneCreatUserControl : UserControl, IInterfaceDataReceiver<Vehicle>
    {
        public PassengerPlaneCreatUserControl()
        {
            InitializeComponent();
        }

        public Vehicle GetData()
        {
            return new PassengerPlane(/*name*/                 Name.Text,
                                       /*model*/               Model.Text,
                                       /*price*/                Convert.ToDouble(Price.Text),
                                       /*numbers of seats*/     Convert.ToInt32(NumbersOfSeats.Text),
                                       /*fuel type*/            new AviationFuel("A23"),
                                       /*functionality*/        new PlaneFunctionality()
                                       );
        }
    }
}
