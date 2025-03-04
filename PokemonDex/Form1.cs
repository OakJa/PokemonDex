namespace PokemonDex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Houndour houndour = new Houndour();
            this.displayPokemon(houndour);
        }


        private void displayPokemon(Pokemon pokemon)
        {
            this.label1.Text = pokemon.getName();
            byte[] imageData = pokemon.getImage();

            if (imageData == null || imageData.Length == 0)
            {
                MessageBox.Show("Invalid image data.");
                return;
            }

            using (var ms = new MemoryStream(imageData))
            {
                try
                {
                    this.pictureBox1.Image = Image.FromStream(ms);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
