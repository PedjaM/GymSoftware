using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{

    public partial class FormaServer : Form
    {

  
        Server s;
        public FormaServer()
        {
            InitializeComponent();
        }


      

        private void FormaServer_Load(object sender, EventArgs e)
        {
            s = new Server();
            if(s.PokreniServer())
            {
                lblServer.Text = "Server je pokrenut";
            
            }
       



        }

        private void dugmeUgasiServer_Click(object sender, EventArgs e)
        {
            if(s.ZaustaviServer())
            {
                Environment.Exit(1);
            }
        }
    }
}
