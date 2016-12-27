using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetDimension.NanUI;

namespace NanUIFirst
{
    public partial class MainForm : HtmlUIForm
    {
        public MainForm() : base("embedded://www/about.html")
        {
            InitializeComponent();
        }
    }
}
