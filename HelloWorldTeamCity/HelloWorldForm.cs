﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldTeamCity {
    public partial class HelloWorldForm : Form {

        public HelloWorldForm( ) {
            InitializeComponent( );
        }

        private void buttonOK_Click( object sender, EventArgs e ) {
            this.DialogResult = DialogResult.OK;
            this.Close( );
            // Edit from new-branch-2
        }

    }
}
