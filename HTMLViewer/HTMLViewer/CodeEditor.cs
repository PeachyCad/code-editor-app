﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLViewer
{
    public partial class CodeEditor : Form
    {
        public CodeEditor()
        {
            InitializeComponent();
            webControl.Source = new Uri("file:///index.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
