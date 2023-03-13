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
    public partial class cadastrarclientes : Form
    {
        Thread nt;
        public cadastrarclientes()
        {
            InitializeComponent();
        }

        private void cadastrarclientes_Load(object sender, EventArgs e)
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
