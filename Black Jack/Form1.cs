namespace Black_Jack
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Carta> cartas;
        private Dictionary<int, int> jogadores_pontos;

        private int jogador_vez;

        public Form1()
        {
            InitializeComponent();

            reset();
        }

        private Dictionary<string, Bitmap> gerarImagens()
        {
            Dictionary<string, Bitmap> imagens = new Dictionary<string, Bitmap>();

            imagens.Add("1-1", Properties.Resources.ace_of_clubs);
            imagens.Add("1-2", Properties.Resources._2_of_clubs);
            imagens.Add("1-3", Properties.Resources._3_of_clubs);
            imagens.Add("1-4", Properties.Resources._4_of_clubs);
            imagens.Add("1-5", Properties.Resources._5_of_clubs);
            imagens.Add("1-6", Properties.Resources._6_of_clubs);
            imagens.Add("1-7", Properties.Resources._7_of_clubs);
            imagens.Add("1-8", Properties.Resources._8_of_clubs);
            imagens.Add("1-9", Properties.Resources._9_of_clubs);
            imagens.Add("1-10", Properties.Resources._10_of_clubs);
            imagens.Add("1-11", Properties.Resources.jack_of_clubs);
            imagens.Add("1-12", Properties.Resources.queen_of_clubs);
            imagens.Add("1-13", Properties.Resources.king_of_clubs);

            imagens.Add("2-1", Properties.Resources.ace_of_diamonds);
            imagens.Add("2-2", Properties.Resources._2_of_diamonds);
            imagens.Add("2-3", Properties.Resources._3_of_diamonds);
            imagens.Add("2-4", Properties.Resources._4_of_diamonds);
            imagens.Add("2-5", Properties.Resources._5_of_diamonds);
            imagens.Add("2-6", Properties.Resources._6_of_diamonds);
            imagens.Add("2-7", Properties.Resources._7_of_diamonds);
            imagens.Add("2-8", Properties.Resources._8_of_diamonds);
            imagens.Add("2-9", Properties.Resources._9_of_diamonds);
            imagens.Add("2-10", Properties.Resources._10_of_diamonds);
            imagens.Add("2-11", Properties.Resources.jack_of_diamonds);
            imagens.Add("2-12", Properties.Resources.queen_of_diamonds);
            imagens.Add("2-13", Properties.Resources.king_of_diamonds);

            imagens.Add("3-1", Properties.Resources.ace_of_hearts);
            imagens.Add("3-2", Properties.Resources._2_of_hearts);
            imagens.Add("3-3", Properties.Resources._3_of_hearts);
            imagens.Add("3-4", Properties.Resources._4_of_hearts);
            imagens.Add("3-5", Properties.Resources._5_of_hearts);
            imagens.Add("3-6", Properties.Resources._6_of_hearts);
            imagens.Add("3-7", Properties.Resources._7_of_hearts);
            imagens.Add("3-8", Properties.Resources._8_of_hearts);
            imagens.Add("3-9", Properties.Resources._9_of_hearts);
            imagens.Add("3-10", Properties.Resources._10_of_hearts);
            imagens.Add("3-11", Properties.Resources.jack_of_hearts);
            imagens.Add("3-12", Properties.Resources.queen_of_hearts);
            imagens.Add("3-13", Properties.Resources.king_of_hearts);

            imagens.Add("4-1", Properties.Resources.ace_of_spades);
            imagens.Add("4-2", Properties.Resources._2_of_spades);
            imagens.Add("4-3", Properties.Resources._3_of_spades);
            imagens.Add("4-4", Properties.Resources._4_of_spades);
            imagens.Add("4-5", Properties.Resources._5_of_spades);
            imagens.Add("4-6", Properties.Resources._6_of_spades);
            imagens.Add("4-7", Properties.Resources._7_of_spades);
            imagens.Add("4-8", Properties.Resources._8_of_spades);
            imagens.Add("4-9", Properties.Resources._9_of_spades);
            imagens.Add("4-10", Properties.Resources._10_of_spades);
            imagens.Add("4-11", Properties.Resources.jack_of_spades);
            imagens.Add("4-12", Properties.Resources.queen_of_spades);
            imagens.Add("4-13", Properties.Resources.king_of_spades);

            return imagens;
        }

        private void reset()
        {
            cartas = new Dictionary<string, Carta>();
            jogadores_pontos = new Dictionary<int, int>();

            Naipe[] cartas_naipes = { Naipe.PAUS, Naipe.OUROS, Naipe.COPAS, Naipe.ESPADAS };
            string[] cartas_nomes = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei" };
            Dictionary<string, Bitmap> cartas_imagens = gerarImagens();

            foreach (Naipe naipe in cartas_naipes)
            {
                for (int i = 0; i < cartas_nomes.Length; i++)
                {
                    int valor = i + 1;
                    string key = ((int) naipe) + "-" + valor;
                    Bitmap imagem = cartas_imagens[key];

                    cartas.Add(key, new Carta(naipe, cartas_nomes[i].ToString(), valor, imagem));
                }
            }

            jogadores_pontos.Add(0, 0);
            jogadores_pontos.Add(1, 0);

            lbl_carta_1.Text = "Mão do Jogador 1: ";
            lbl_pontos_1.Text = "Pontos: ";
            lbl_carta_2.Text = "Mão do Jogador 2: ";
            lbl_pontos_2.Text = "Pontos: ";

            img_carta_1.Image = Properties.Resources.cardback1;
            img_carta_2.Image = Properties.Resources.cardback1;

            jogador_vez = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playerScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void lbl_carta_2_Click(object sender, EventArgs e)
        {

        }

        private void btn_pegar_carta_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int numero = rand.Next(1, 13);
            int naipe = rand.Next(1, 4);
            string index = naipe + "-" + numero;

            Carta carta = cartas[index];

            jogadores_pontos[jogador_vez] += carta.valor;

            int pontos = jogadores_pontos[jogador_vez];
            int jogador = jogador_vez + 1;
            string lbl = "Mão do Jogador " + jogador + ": " + carta.valor;

            if (jogador_vez == 0)
            {
                img_carta_1.Image = carta.imagem;
                lbl_carta_1.Text = lbl;
                lbl_pontos_1.Text = "Pontos: " + pontos;
            }
            else
            {
                img_carta_2.Image = carta.imagem;
                lbl_carta_2.Text = lbl;
                lbl_pontos_2.Text = "Pontos: " + pontos;
            }

            if (pontos == 21)
            {
                MessageBox.Show("O jogador " + jogador + " vencêu");
                reset();
            } 
            else if (pontos > 21)
            {
                jogador = jogador == 1 ? 2 : 1;

                MessageBox.Show("Você perdeu, O jogador " + jogador + " vencêu");
                reset();
            }
        }

        private void btn_passar_vez_Click(object sender, EventArgs e)
        {
            jogador_vez = jogador_vez == 0 ? 1 : 0;

            img_carta_1.Image = Properties.Resources.cardback1;
            img_carta_2.Image = Properties.Resources.cardback1;
        }
    }
}
