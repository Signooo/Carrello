using eCommerce;

namespace Carrello_con_prodotti
{
    public partial class Form1 : Form
    {
        private Prodotto prodotto;
        private Carrello C;
        public Form1()
        {
            InitializeComponent();
            C = new Carrello("00001"); //Creo l'oggetto C di tipo Carrello
            prodotto = new Prodotto("EA", "FC25", "000001", 35);

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
        private void AggiornaInterfaccia()
        {
            Carrello.DataSource = null;
            Carrello.DataSource = C.ProdottiCarrello;
            Carrello.DisplayMember = "Modello";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C.svuotaCarrello();
            AggiornaInterfaccia();
        }
    }
}
