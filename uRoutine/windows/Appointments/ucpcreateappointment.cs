﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Source;

namespace User.Action
{
    public partial class ucpcreateappointment : Form
    {
        public ucpcreateappointment()
        {
            InitializeComponent();
            Winstyle.Apply(this,new Size(210,100),"Appointment");

        }
    }
}

