﻿using MahApps.Metro.Controls;
using Rework.Models;
using Rework.ViewModels;
using System;
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

namespace Rework.Content
{
    /// <summary>
    /// Interaction logic for Class.xaml
    /// </summary>
    public partial class Class : UserControl
    {
        private List<string> ListGrade;
        public Class()
        {
            InitializeComponent();
            ListGrade = new List<string>();
            this.DataContext = new ClassViewModel();
        }

        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            HamburgerMenuControl.Content = e.InvokedItem;
        }

        void UpdateGradeList()
        {
            ListGrade.Clear();
            List<grade> Grades = DataProvider.Ins.DB.grades.ToList();
            foreach(grade g in Grades)
            {
                ListGrade.Add(g.name);
            }
            CbGrade.ItemsSource = ListGrade;
        }

        private void ClassUC_LayoutUpdated(object sender, EventArgs e)
        {
            UpdateGradeList();
        }

        private void MetroDataGrid_AutoGeneratedColumns(object sender, EventArgs e)
        {
            var grid = (DataGrid)sender;
            ColumnTemplate.DisplayIndex = grid.Columns.Count - 1;
        }
    }
}