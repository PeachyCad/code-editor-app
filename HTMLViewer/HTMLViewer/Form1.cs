using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webControl1.Source = new Uri("D:\\Program Files\\source\\git_repos\\CodeEditor\\code-editor-app\\index.html");
        }
    }
}
