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
            if (radioButton1.Checked)
            {
                C.aggiungiProdotto(prodotto);
                AggiornaInterfaccia();
            }

            else if (radioButton2.Checked)
            {
                C.aggiungiProdotto(prodotto);
                AggiornaInterfaccia();
            }
            else
            {
                C.aggiungiProdotto(prodotto);
                AggiornaInterfaccia();
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string prodottoSelezionato = comboBox1.SelectedItem.ToString();

                string[] parti = prodottoSelezionato.Split(" - ");

                string marca = parti[0].Trim();
                string modello = parti[1].Trim();
                double prezzo = Convert.ToInt16(parti[2].Trim());

                prodotto = new ProdottoInformatico(marca, modello, identificativo, prezzo);
            }

            else if (radioButton2.Checked)
            {
                string prodottoSelezionato = comboBox1.SelectedItem.ToString();

                string[] parti = prodottoSelezionato.Split(" - ");

                string marca = parti[0].Trim();
                string modello = parti[1].Trim();
                double prezzo = Convert.ToInt16(parti[2].Trim());

                prodotto = new ProdottoAlimentare(marca, modello, identificativo, prezzo);
            }
            else
            {
                string prodottoSelezionato = comboBox1.SelectedItem.ToString();

                string[] parti = prodottoSelezionato.Split(" - ");

                string marca = parti[0].Trim();
                string modello = parti[1].Trim();
                double prezzo = Convert.ToInt16(parti[2].Trim());

                prodotto = new Prodotto(marca, modello, identificativo, prezzo);
            }
            
        }
    }
}
