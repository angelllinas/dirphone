using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace directorio_telefonico
{
    public partial class Crear : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(System.IntPtr hwnd, int wsg, int wparam, int lparam);

        public Crear()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tituloLogo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFormInPanel(Object Formhijo)
        {
            if (this.panelGestion.Controls.Count > 0) 
                this.panelGestion.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelGestion.Controls.Add(fh);
            this.panelGestion.Tag = fh;
            fh.Show();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormCrear());      
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormBuscar());
        }
    }
}
