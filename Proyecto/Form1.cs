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

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Image != null)
            {
                button1.Image = null;
            }
            else
            {
                
                string ruta = Path.Combine(Application.CommonAppDataPath, @"image\Vehiculo.png");
                button1.Image = Image.FromFile(@ruta);
            }
            
        }
    }
}
