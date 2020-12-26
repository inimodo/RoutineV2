using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Source.Style;
using Source;

namespace User.Forms
{
    public partial class ucpi_board
    {
        public void InitializeInterface()
        {
            this.BackColor = u_Stylesource.o_backcolor;

            this.e_gens.BackColor = u_Stylesource.o_backcolor;
            this.e_div_one.BackColor = u_Stylesource.o_headercolor;

        }
    }
}
