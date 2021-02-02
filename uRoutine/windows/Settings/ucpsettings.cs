using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Source;

namespace User.Action
{
    public partial class ucpsettings : Form
    {

        public ucpsettings()
        {
            InitializeComponent();
            Winstyle.Apply(this);

        }
    }
}
