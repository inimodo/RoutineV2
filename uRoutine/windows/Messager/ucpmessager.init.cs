using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Source;
namespace User.Action
{
    public partial class ucpmessager
    {
        partial void InitializeInterface()
        { 

            this.e_nav_title.Text = s_wintitle;


            if (b_ask)
            {
                this.e_yes.Text = "YES";
                this.e_no.Text = "NO";
            }
            else
            {
                this.e_yes.Hide();
                this.e_no.Text = "OKAY";
            }
            this.e_msg.Text = s_wintext;

            this.Text = s_wintitle;

        }
    }
}
