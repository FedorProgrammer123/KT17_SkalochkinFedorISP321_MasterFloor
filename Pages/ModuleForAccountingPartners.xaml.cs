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

namespace KT16_SkalochkinFedor_ISP_321_MasterFloor.Pages
{
    /// <summary>
    /// Логика взаимодействия для ModuleForAccountingPartners.xaml
    /// </summary>
    public partial class ModuleForAccountingPartners : Page
    {
        public ModuleForAccountingPartners()
        {
            InitializeComponent();
            ShowPartners.ItemsSource = Classes.Context.GetContext().PartnersImport.ToList();
            
        }
    }
}
