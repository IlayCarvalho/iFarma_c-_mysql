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
    public partial class Listarusuarios : Form
    {
        Thread nt;
        Thread pp;
        Thread PU;
        public Listarusuarios()
        {
            InitializeComponent();
        }

        private void btn_adcusuarioLU_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void novoForm()
        {
            Application.Run(new adm());
        }

        private void btn_sairListarusuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            pp = new Thread(novoForm1);
            pp.SetApartmentState(ApartmentState.STA);
            pp.Start();

        }

        private void novoForm1()
        {
            Application.Run(new Form1());
        }

        private void btn_listarusuariosLU_Click(object sender, EventArgs e)
        {

        }

        private void btn_pagfarmaceuticoLU_Click(object sender, EventArgs e)
        {
            this.Close();
            PU = new Thread(novoForm2);
            PU.SetApartmentState(ApartmentState.STA);
            PU.Start();
        }

        private void novoForm2()
        {
            Application.Run(new PaginadoUsuario());
        }
    }
}
