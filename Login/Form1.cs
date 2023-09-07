using MySql.Data.MySqlClient;

namespace Login

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = user.Text;
            contraseña = pass.Text;
            MySqlConnection con = new MySqlConnection("server - 127.0.0.1 ; Database = login; user Id-root ; password-lentp123 ");
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Eror" + ex.ToString());
                throw;
            }
            string sql = "select user,pass from users where user = '" + nombre + "' AND pass = '" + contraseña + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido" + nombre);
            }
            else
            {
                MessageBox.Show("No existe este usuario " + nombre);
            }

        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Ingrese su usuario";
                user.ForeColor = Color.Black;
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Ingrese su usuario")
            {
                user.Text = "";
                user.ForeColor = Color.Black;
            }

        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Ingrese su contraseña";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = false;

            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Ingrese su contraseña")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = true;
            }
        }

        private void muestra_CheckedChanged(object sender, EventArgs e)
        {
            if (muestra.Checked == true)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}