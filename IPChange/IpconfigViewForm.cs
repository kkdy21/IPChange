using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPChange
{
    public partial class IpconfigViewForm : Form
    {
        public IpconfigViewForm()
        {
            InitializeComponent();
        }

        public void setText(string text)
        {
            textBox1.Text = text;

        }
    }
}
