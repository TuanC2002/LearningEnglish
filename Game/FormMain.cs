using System.ComponentModel;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace Game
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static SoundPlayer play = new SoundPlayer(@"D:\C#\exx\Game\music\song.wav");
        FormGame game = new FormGame();
        //dataGridViewAnimal
        private void butStart_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonVolu_Click(object sender, EventArgs e)
        {
            buttonVolu.Visible = false;
            buttonVolu.Enabled=false;
            buttonNoVolu.Enabled = true;
            buttonNoVolu.Visible = true;
            play.Stop();
        }
        private void buttonNoVolu_Click(object sender, EventArgs e)
        {
            buttonNoVolu.Visible = false;
            buttonNoVolu.Enabled = false;
            buttonVolu.Enabled = true;
            buttonVolu.Visible = true;
            play.Play();    
        }

        private void buttonBackWordList_Click(object sender, EventArgs e)
        {
            buttonAnimalWord.BackColor = Color.White;
            buttonFruitWord.BackColor = Color.White;
            buttonVehiclesWord.BackColor=Color.White;
            panelWordList.Visible = false;
        }

        private void buttonWordList_Click(object sender, EventArgs e)
        {
            panelWordList.Visible = true;
        }

        private void buttonAnimalWord_Click(object sender, EventArgs e)
        {
            if (buttonAnimalWord.BackColor == Color.White)
            {
                buttonAnimalWord.BackColor = Color.DeepSkyBlue;
                buttonFruitWord.BackColor = Color.White;
                buttonVehiclesWord.BackColor = Color.White;
            }
            pictureBoxWord.Image = Properties.Resources.aniaml_word;
            pictureBoxWord.Visible = true;
        }

        private void buttonFruitWord_Click(object sender, EventArgs e)
        {
            if (buttonFruitWord.BackColor == Color.White)
            {
                buttonFruitWord.BackColor = Color.DeepSkyBlue;
                buttonAnimalWord.BackColor = Color.White;
                buttonVehiclesWord.BackColor = Color.White;
            }
            pictureBoxWord.Image = Properties.Resources.fruti_word;
            pictureBoxWord.Visible = true;
        }

        private void buttonVehiclesWord_Click(object sender, EventArgs e)
        {
            if (buttonVehiclesWord.BackColor == Color.White)
            {
                buttonVehiclesWord.BackColor = Color.DeepSkyBlue;
                buttonFruitWord.BackColor = Color.White;
                buttonAnimalWord.BackColor = Color.White;
            }
            pictureBoxWord.Image = Properties.Resources.vehicle_Word;
            pictureBoxWord.Visible = true;
        }

        private void buttonExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            panelScore.Visible = true;
        }
        private void buttonBackScore_Click(object sender, EventArgs e)
        {
            buttonFruit.BackColor = Color.White;
            buttonAnimal.BackColor = Color.White;
            buttonVehicle.BackColor = Color.White;
            panelScore.Visible = false;
            dataView.Visible = false;
        }
        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            if (buttonAnimal.BackColor == Color.White)
            {
                buttonAnimal.BackColor = Color.DeepSkyBlue;
                buttonFruit.BackColor = Color.White;
                buttonVehicle.BackColor = Color.White;
            }
            dataView.DataSource = game.dtAnimal;
            dataView.Sort(dataView.Columns[1], ListSortDirection.Descending);
            dataView.Visible = true;
        }

        private void buttonFruit_Click(object sender, EventArgs e)
        {
            if (buttonFruit.BackColor == Color.White)
            {
                buttonAnimal.BackColor = Color.White;
                buttonFruit.BackColor = Color.DeepSkyBlue;
                buttonVehicle.BackColor = Color.White;
            }
            dataView.DataSource = game.dtFruit;
            dataView.Sort(dataView.Columns[1], ListSortDirection.Descending);
            dataView.Visible = true;
        }

        private void buttonVehicle_Click(object sender, EventArgs e)
        {
            if (buttonVehicle.BackColor == Color.White)
            {
                buttonAnimal.BackColor = Color.White;
                buttonFruit.BackColor = Color.White;
                buttonVehicle.BackColor = Color.DeepSkyBlue;
            }
            dataView.DataSource = game.dtVehicles;
            dataView.Sort(dataView.Columns[1], ListSortDirection.Descending);
            dataView.Visible = true;
        }
    }
}