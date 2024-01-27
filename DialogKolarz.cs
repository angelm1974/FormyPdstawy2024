using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormyPdstawy
{
    public partial class DialogKolarz : Form
    {
        public DialogKolarz(Kolarz _kolarz)
        {
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Kolarz nowyKolarz = new Kolarz();
            nowyKolarz.nowyNumer();
            nowyKolarz.Imie = txtImie.Text;
            nowyKolarz.Nazwisko = txtNazwisko.Text;
            nowyKolarz.Team = txtTeam.Text;
            nowyKolarz.Email = txtEmail.Text;
            nowyKolarz.Wpisowe = chkWpisowe.Checked;
            nowyKolarz.Ranking = (int)nmRanking.Value;
            nowyKolarz.Wiek = (byte)nmWiek.Value;

            Program.listaKolarzy.Add(nowyKolarz);
            Close();
        }
    }
}
