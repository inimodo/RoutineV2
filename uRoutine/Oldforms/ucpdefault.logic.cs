using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Source;
using Source.Style;
using System.IO;

namespace User
{
    public partial class ucpdefault
    {
        public void Closeloop(int i_code)
        {
            
            i_exitcode = i_code;
            this.Close();
        }
    }
}