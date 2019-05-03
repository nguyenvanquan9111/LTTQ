﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class DashBoardVM: BaseViewModel
    {
        public static DashBoardVM Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new DashBoardVM();
                return _ins;
            }

            set
            {
                _ins = value;
            }
        }
        private static DashBoardVM _ins;

        public string NumberOfChildren
        {
            get
            {
                return _numberOfChildren;
            }

            set
            {
                _numberOfChildren = value;
                OnPropertyChange("NumberOfChildren");
            }
        }

        public string NumberOfTeacher
        {
            get
            {
                return _numberOfTeacher;
            }

            set
            {
                _numberOfTeacher = value;
                OnPropertyChange("NumberOfTeacher");
            }
        }

        public string NumberOfClass
        {
            get
            {
                return _numberOfClass;
            }

            set
            {
                _numberOfClass = value;
                OnPropertyChange("NumberOfClass");
            }
        }

        private static string _numberOfClass;
        private static string _numberOfChildren;
        private static string _numberOfTeacher;

        public DashBoardVM()
        {
            UpdateDashboard();
        }

        public void UpdateDashboard()
        {
            int a = DataProvider.Ins.DB.children.Count();
            int b = DataProvider.Ins.DB.teachers.Count();
            int c = DataProvider.Ins.DB.classes.Count();

            NumberOfChildren = a > 1 ? (a.ToString() + " children") : (a.ToString() + " child");
            NumberOfTeacher = b > 1 ? (b.ToString() + " teachers") : (b.ToString() + " teacher");
            NumberOfClass = c > 1 ? (c.ToString() + " classes") : (c.ToString() + " class");
        }
    }
}
