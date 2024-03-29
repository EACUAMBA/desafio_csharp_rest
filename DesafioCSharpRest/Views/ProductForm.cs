﻿using DesafioCSharpRest.Domain.Models;
using DesafioCSharpRest.Domain.Services;
using Quickwire.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioCSharpRest.Views
{
    public partial class ProductForm : UserControl
    {
        private static ProductForm? instance;

        public ProductForm()
        {
            InitializeComponent();
        }

        public static ProductForm getInstance()
        {
            if(instance == null)
                instance = new ProductForm();

            instance.clearForm();
            return instance;
        }

        internal static ProductForm getInstance(Product product)
        {
            if (instance == null)
                instance = new ProductForm();
            if (product == null) return getInstance();
            instance.fillFieldsToUpdate(product);
            return instance;
        }
    }
}
