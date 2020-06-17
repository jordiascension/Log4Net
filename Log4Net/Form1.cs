using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using log4net;

namespace Log4Net
{
    public partial class Form1 : Form
    {

        private static readonly ILog logger = 
            LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            logger.Info("Boton Pulsado");
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var sAttr = ConfigurationManager.
                AppSettings["FileName"].ToString();
            MessageBox.Show(sAttr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
