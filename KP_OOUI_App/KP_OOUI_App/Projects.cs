﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace KP_OOUI_App
{
        public class Projects : INotifyPropertyChanged
        {
            private int _id;
            private string _name;
            private ObservableCollection<Info> _info
                = new ObservableCollection<Info>();
            public int ID
            {
                get { return _id; }
                set
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
            public ObservableCollection<Info> Info
            {
                get { return _info; }
            }
            #region INotifyPropertyChanged Members 
            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged(string name)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
            }
            #endregion
        }
        public class Info : INotifyPropertyChanged
        {
            private int _id;
            private DateTime _date;
            private string _skill;
            public int ID
            {
                get { return _id; }
                set
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
            public DateTime Date
            {
                get { return _date; }
                set
                {
                    _date = value;
                    OnPropertyChanged("Date");
                }
            }
            public string Skill
            {
                get { return _skill; }
                set
                {
                    _skill = value;
                    OnPropertyChanged("Skill");
                }
            }
            #region INotifyPropertyChanged Members 
            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged(string name)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
            }
            #endregion
        }
    }
