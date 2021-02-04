using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Source;

namespace User.Action
{
    public partial class ucpexport : Form
    {
        public ucpexport()
        {
            InitializeComponent();
            Winstyle.Apply(this,new Size(230,300));

        }

    }
}
