namespace PokemonDex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the form loads, the following code will be executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Display the Pokemon's name, image, and other stats
        /// </summary>
        /// <param name="pokemon"></param>
        private void displayPokemon(Pokemon pokemon)
        {
            this.lbPokemonName.Text = pokemon.getName();
            this.lbnametype.Text = $"Type:  {pokemon.Type} Type2:  {pokemon.Type2}";


            // Display other stats in lbStatus
            this.lbStatus.Text = $"HP: {pokemon.HP}\n" +
                                 $"Attack: {pokemon.Attack}\n" +
                                 $"Defense: {pokemon.Defense}\n" +
                                 $"Special Attack: {pokemon.SpecialAttack}\n" +
                                 $"Special Defense: {pokemon.SpecialDefense}\n" +
                                 $"Speed: {pokemon.Speed}\n" +
                                 $"Total: {pokemon.Total}\n" +
                                 $"Height: {pokemon.Height}\n" +
                                 $"Weight: {pokemon.Weight}\n" +
                                 $"Species: {pokemon.Species}";

            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Noibat noibat = new Noibat();
            // Add Sonolax object to the list
            this.pokemonsList.Add(noibat);
            // Display the Sonolax's name and image
            this.displayPokemon(noibat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Houndour houndour = new Houndour();
            // Add Noibat object to the list
            this.pokemonsList.Add(houndour);
            // Display the Noibat's name and image
            this.displayPokemon(houndour);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MrMime mrMime = new MrMime();
            this.pokemonsList.Add(mrMime);
            this.displayPokemon(mrMime);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vaporeon vaporeon = new Vaporeon();
            this.pokemonsList.Add(vaporeon);
            this.displayPokemon(vaporeon);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Meowscarada meowscarada = new Meowscarada();
            this.pokemonsList.Add(meowscarada);
            this.displayPokemon(meowscarada);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ceruledge ceruledge = new Ceruledge();
            this.pokemonsList.Add(ceruledge);
            this.displayPokemon(ceruledge);

        }
    }
}
