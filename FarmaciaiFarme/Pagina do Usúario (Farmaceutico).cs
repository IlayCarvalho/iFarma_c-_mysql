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
    public partial class PaginadoUsuario : Form
    {
        Thread nt;
        Thread Am;
        Thread Vv;
        Thread Vm;
        Thread Cc;
        Thread Rv;
        Thread Lc;
        Thread pp;


        public PaginadoUsuario()
        {
            InitializeComponent();
        }

        private void PaginadoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_listarmedicamentos_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new ListarMedicameto());
        }

        private void btn_alterarmedicamentos_Click(object sender, EventArgs e)
        {
            this.Close();
            Am = new Thread(novoForm2);
            Am.SetApartmentState(ApartmentState.STA);
            Am.Start();
        }

        private void novoForm2()
        {
            Application.Run(new alterarmedicamentos());
        }

        private void btn_verificarvalidades_Click(object sender, EventArgs e)
        {
            this.Close();
            Vv = new Thread(novoForm3);
            Vv.SetApartmentState(ApartmentState.STA);
            Vv.Start();

        }

        private void novoForm3()
        {
            Application.Run(new verificarvalidades());
        }

        private void btn_vendermedicamentos_Click(object sender, EventArgs e)
        {
            this.Close();
            Vm = new Thread(novoForm4);
            Vm.SetApartmentState(ApartmentState.STA);
            Vm.Start();
        }

        private void novoForm4()
        {
            Application.Run(new vendermedicamentos());
        }

        private void btn_cadastrarclientesbtn_cadastrarclientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Cc = new Thread(novoForm5);
            Cc.SetApartmentState(ApartmentState.STA);
            Cc.Start();
        }

        private void novoForm5()
        {
            Application.Run(new cadastrarclientes());
        }

        private void btn_relatoriodevendas_Click(object sender, EventArgs e)
        {
            this.Close();
            Rv = new Thread(novoForm6);
            Rv.SetApartmentState(ApartmentState.STA);
            Rv.Start();
        }

        private void novoForm6()
        {
            Application.Run(new relatoriodevendas());
        }

        private void btn_listarclientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Lc = new Thread(novoForm7);
            Lc.SetApartmentState(ApartmentState.STA);
            Lc.Start();
        }

        private void novoForm7()
        {
            Application.Run(new listarclientes());
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            pp = new Thread(novoForm8);
            pp.SetApartmentState(ApartmentState.STA);
            pp.Start();
        }

        private void novoForm8()
        {
            Application.Run(new Form1());
        }
    }
}
