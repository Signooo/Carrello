namespace Carrello
{
    public partial class Form1 : Form
    {
        private Prodotto prodotto;
        private Carrello C;

        public Form1()
        {
            InitializeComponent();
            C = new Carrello("00001");
            prodotto = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = textBox1.Text;
            string modello = textBox2.Text;
            double prezzo = Convert.ToInt16(textBox3.Text);
            string identificativo = textBox4.Text;
            if (radioButton1.Checked)
            {
                prodotto = new ProdottoInformatico(marca, modello, identificativo, prezzo);
            }
            else if (radioButton2.Checked)
            {
                prodotto = new ProdottoAlimentare(marca, modello, identificativo, prezzo);
            }
            else if (radioButton3.Checked)
            {
                prodotto = new Prodotto(marca, modello, identificativo, prezzo);
            }
            else
            {
                MessageBox.Show("Errore");
            }
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
            listBox1.DataSource = C.ProdottiCarrello.Select(p => $"{p.Marca} - {p.Modello} - {p.CalcolaPrezzo():C}").ToList();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }

}
