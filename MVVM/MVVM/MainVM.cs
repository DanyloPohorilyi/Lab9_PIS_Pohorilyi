﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class MainVM :INotifyPropertyChanged
    {
        private double _number1;
        private double _number2;
        private double _number3;
        private double _number4;
        private double _number5;
        
        public double Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged("Number4");
                OnPropertyChanged("Number5");
            }
        }
        public double Number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                OnPropertyChanged("Number4");
                OnPropertyChanged("Number5");
            }
        }
        public double Number3
        {
            get { return _number3; }
            set
            {
                _number3 = value;
                OnPropertyChanged("Number4");
                OnPropertyChanged("Number5");
            }
        }

        public double Number4
        {
            get
            {
                var parallelepiped = new Parallelepiped(Number1, Number2, Number3);
                return parallelepiped.S;
            }
        }
        public double Number5
        {
            get
            {
                var parallelepiped = new Parallelepiped(Number1, Number2, Number3);
                return parallelepiped.V;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
