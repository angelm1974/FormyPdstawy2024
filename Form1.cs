namespace FormyPdstawy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kolarzBindingSource.DataSource = Program.listaKolarzy;
        }


        #region Metody odpowiadajace za zdarzenia
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogKolarz dlg = new DialogKolarz(new Kolarz());
            dlg.ShowDialog();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            var wybrany = (Kolarz)kolarzBindingSource.Current;
            DialogKolarz dlg = new DialogKolarz(wybrany);
            dlg.ShowDialog();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Form1_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kolarzBindingSource;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}