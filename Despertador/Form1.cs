using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despertador
{
    public partial class frmDespertador : Form
    {
        // declaração da variavél música
        string musica;

        public frmDespertador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void rdbdesligado_CheckedChanged(object sender, EventArgs e)
        {
            Media.Ctlcontrols.stop();
            ThoraDesp.Stop();
        }

        private void rdbligado_CheckedChanged(object sender, EventArgs e)
        {
            lblhoraDespertar.Text = mtbhoradespertar.Text;
            mtbhoradespertar.Text = "";
            ThoraDesp.Start();
        }

        private void ThoraDesp_Tick(object sender, EventArgs e)
        {
            if(lblhoraActual.Text==lblhoraDespertar.Text)
            {
                Media.URL = musica;
            }
        }

        private void ThoraActual_Tick(object sender, EventArgs e)
        {
            
            lblhoraActual.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" +DateTime.Now.Second.ToString("00");
        }

        private void btnadicionarmusica_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if(abrir.ShowDialog()==DialogResult.OK) 
            {
                musica = abrir.FileName;
                txtmusica.Text = abrir.SafeFileName;

            }
        }

        private void lblhoraDespertar_Click(object sender, EventArgs e)
        {

        }
    }
}
