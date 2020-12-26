using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace User.Forms
{
    public partial class ucpi_general
    {
        public string GetPath() {
            FolderBrowserDialog o_browser = new FolderBrowserDialog();
            if (o_browser.ShowDialog() == DialogResult.OK) {
                if (Directory.Exists(o_browser.SelectedPath)) {
                    return o_browser.SelectedPath;
                }
            }
            o_browser.Dispose();
            return null;
        }
    }
}
