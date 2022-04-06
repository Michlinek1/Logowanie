namespace logowanie
{
    public partial class Form1 : Form
    {
        public static string login;
        public static string haslo;

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            haslo = textBox2.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo) || string.IsNullOrEmpty(login) && string.IsNullOrEmpty(haslo))
            {
                MessageBox.Show("Wystąpił błąd, spróbuj ponownie!");
            }
            else if (login == haslo)
            {
                DialogResult dialogResult = MessageBox.Show("Twój login jest taki sam co hasło, czy chcesz kontynuować?", "Uwaga", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Zostałeś zalogowany!");
                    logowac();    

                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Zostałeś zalogowany!");
                logowac();
                
            }




        }



        public void logowac()
        {

            File.AppendAllText(@"C:\Users\Michal\source\repos\logowanie\logowanie\loginytxt\loginhaslo.txt", $"Login {textBox1.Text}, hasło {textBox2.Text} \n");
            witaj witamkod = new witaj();
            witamkod.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            czyszczenie Wyczysc = new czyszczenie();
            Wyczysc.Show();
        }

        }
    }

