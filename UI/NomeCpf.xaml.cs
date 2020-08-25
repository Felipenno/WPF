﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Lógica interna para NomeCpf.xaml
    /// </summary>
    public partial class NomeCpf : Window
    {
        public NomeCpf()
        {
            InitializeComponent();
        }

        private void BtnContinuarVenda(object sender, RoutedEventArgs e)
        {


            NovaVenda novaVenda = new NovaVenda(boxNomeCliente.Text, boxCpfCliente.Text);
            novaVenda.ShowDialog();
            Close();
        }
    }
}
