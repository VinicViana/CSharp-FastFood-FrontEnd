using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_FastFood_FrontEnd {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
            pnVermelho.Height = btnPrincipal.Height;
            firstUserControl1.BringToFront();
        }

        private void btnPrincipal_Click(object sender, EventArgs e) {
            pnVermelho.Height = btnPrincipal.Height;
            pnVermelho.Top = btnPrincipal.Top;

            firstUserControl1.BringToFront();

        }

        private void btnPromocao_Click(object sender, EventArgs e) {
            pnVermelho.Height = btnPromocao.Height;
            pnVermelho.Top = btnPromocao.Top;

            secondUseControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e) {
            MessageBox.Show("Qualquer dúvida sobre o uso do sistema nos contate por uma de nossas linhas de contato!");
        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
