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
            //Create Pikachu object
            Houndour houndour = new Houndour();
            //add Pikachu object to the list
            this.pokemonsList.Add(houndour);
            //display the Pokemon's name and image
            this.displayPokemon(houndour);
        }
        /// <summary>
        /// Display the Pokemon's name and image
        /// </summary>
        /// <param name="pokemon"></param>
        private void displayPokemon(Pokemon pokemon)
        {
            this.lbPokemonName.Text = pokemon.getName();
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Noibat noibat = new Noibat();
            this.displayPokemon(noibat);
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
