namespace Carrello
{
    public partial class Form1 : Form
    {
        private Prodotto prodotto;
        private Carrello C;
        public Form1()
        {
            InitializeComponent();
            C = new Carrello("00001"); //Creo l'oggetto C di tipo Carrello
            prodotto = new Prodotto("AMIRI", "Felpa", "000001", 350);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C.aggiungiProdotto(prodotto);
            AggiornaInterfaccia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C.rimuoviProdotto(prodotto);
            AggiornaInterfaccia();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C.svuotaCarrello();
            AggiornaInterfaccia();
        }
        private void AggiornaInterfaccia()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = C.ProdottiCarrello;
            listBox1.DisplayMember = "Identificativo";
        }
    }
}
