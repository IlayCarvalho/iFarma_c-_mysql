using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FarmaciaiFarme
{
    public partial class alterarmedicamentos : Form
    {
        Thread nt;
        public alterarmedicamentos()
        {
            InitializeComponent();
        }

        private void btn_vendermedicamentos_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrarclientesbtn_cadastrarclientes_Click(object sender, EventArgs e)
        {

        }

        private void btn_relatoriodevendas_Click(object sender, EventArgs e)
        {

        }

        private void btn_verificarvalidades_Click(object sender, EventArgs e)
        {

        }

        private void btn_alterarmedicamentos_Click(object sender, EventArgs e)
        {

        }

        private void lb_nomefarmaceutico_Click(object sender, EventArgs e)
        {

        }

        private void btn_listarmedicamentos_Click(object sender, EventArgs e)
        {

        }

        private void btn_adcmedicamento_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new PaginadoUsuario());
        }
    }
}
