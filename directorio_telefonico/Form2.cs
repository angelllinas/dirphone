using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace directorio_telefonico
{
    public partial class FormCrear : Form
    {
        private ConetDB conn;

        public FormCrear()
        {
            InitializeComponent();
            conn = new ConetDB();    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (conn.getConn() != null)
            {
                
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }
    }
}
