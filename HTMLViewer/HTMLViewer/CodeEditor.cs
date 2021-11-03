using System;
using System.IO;
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

        private void saveCodeButton_Click(object sender, EventArgs e)
        {
            string editorValue = webControl.ExecuteJavascriptWithResult("getEditorValue()").ToString();
            string filePath = @"..\..\..\..\results\source_code.txt";
            File.WriteAllText(filePath, editorValue);
        }
    }
}
