using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Game
{
    public partial class FormGame : Form
    {
        public DataTable dtAnimal = new DataTable();
        public DataTable dtFruit = new DataTable();
        public DataTable dtVehicles = new DataTable();
        public FormGame()
        {
            InitializeComponent();
            dtAnimal.Columns.Add("Name", typeof(string));
            dtAnimal.Columns.Add("Score", typeof(int));
            dtAnimal.Columns.Add("Time", typeof(int));
            dtFruit.Columns.Add("Name", typeof(string));
            dtFruit.Columns.Add("Score", typeof(int));
            dtFruit.Columns.Add("Time", typeof(int));
            dtVehicles.Columns.Add("Name", typeof(string));
            dtVehicles.Columns.Add("Score", typeof(int));
            dtVehicles.Columns.Add("Time", typeof(int));
        }
        //FormMain main = new FormMain();
        public void AddData(int flag)
        {
            switch (flag){
                case 1: dtAnimal.Rows.Add(textName.Text, score, time); ; break;
                case 2: dtFruit.Rows.Add(textName.Text, score, time); ; break;
                case 3: dtVehicles.Rows.Add(textName.Text, score, time); ; break;
            }
        }
        int flag = 0;
        int score = 0;
        string answer = "";
        int time = 0;
        int[] check = new int[6] {-1,-1,-1,-1,-1,-1};

        private string animal(int id)
        {
            string s = "";
            switch (id)
            {
                case 0:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.bear;
                        s = "bear"; break;

                    }
                case 1:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.butter_fly;
                        s = "butterfly"; break;
                    }
                case 2:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.penguin;
                        s = "penguin"; break;
                    }
                case 3:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.cat;
                        s = "cat"; break;
                    }
                case 4:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.dog;
                        s = "dog"; break;
                    }
                case 5:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.Eagle;
                        s = "eagle"; break;
                    }
                case 6:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.elephant;
                        s = "elephant"; break;
                    }
                case 7:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.frog;
                        s = "frog"; break;
                    }
                case 8:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.giraffe;
                        s = "giraffe"; break;
                    }
                case 9:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.tiger;
                        s = "tiger"; break;
                    }
                case 10:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.hedgehog;
                        s = "hedgedog";break;
                    }
                case 11:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.turtle;
                        s = "turtle";break;
                    }
            }
            return s;
        }
        private string fruit(int id)
        {
            string s = "";
            switch (id)
            {
                case 0:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.apple;
                        s = "apple"; break;

                    }
                case 1:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.avocado;
                        s = "avocado"; break;
                    }
                case 2:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.banana;
                        s = "banana"; break;
                    }
                case 3:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.coconut;
                        s = "coconut"; break;
                    }
                case 4:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.lemon;
                        s = "lemon"; break;
                    }
                case 5:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.papaya;
                        s = "papaya"; break;
                    }
                case 6:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.pineapple;
                        s = "pineapple"; break;
                    }
                case 7:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.strawberry;
                        s = "strawberry"; break;
                    }
                case 8:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.tomato;
                        s = "tomato"; break;
                    }
                case 9:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.watermelon;
                        s = "watermelon"; break;
                    }
                case 10:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.carrot;
                        s = "carrot";break;
                    }
                case 11:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.mango;
                        s = "mango";break;
                    }

            }
            return s;
        }
        private string vehicle(int id)
        {
            string s = "";
            switch (id)
            {
                case 0:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.bike;
                        s = "bicycle"; break;

                    }
                case 1:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.bus;
                        s = "bus"; break;
                    }
                case 2:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.car;
                        s = "car"; break;
                    }
                case 3:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.cyclo;
                        s = "cyclo"; break;
                    }
                case 4:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.motobike;
                        s = "motobike"; break;
                    }
                case 5:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.plane;
                        s = "plane"; break;
                    }
                case 6:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.ship;
                        s = "ship"; break;
                    }
                case 7:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.subway;
                        s = "subway"; break;
                    }
                case 8:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.train;
                        s = "train"; break;
                    }
                case 9:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.truck;
                        s = "truck"; break;
                    }
                case 10:
                    {
                        pictureQuestion.BackgroundImage=Properties.Resources.ambulance;
                        s = "ambulance";break;
                    }
                case 11:
                    {
                        pictureQuestion.BackgroundImage = Properties.Resources.tractor;
                        s = "tractor";break;
                    }
            }
            return s;
        }
        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            flag = 1;
            if (buttonAnimal.BackColor == Color.White)
            {
                buttonAnimal.BackColor = Color.DeepSkyBlue;
                buttonFruit.BackColor = Color.White;
                buttonVehicles.BackColor = Color.White;
            }
            else
            {
                buttonAnimal.BackColor = Color.White;
                flag = 0;
            }
        }

        private void buttonFruit_Click(object sender, EventArgs e)
        {
            flag = 2;
            if (buttonFruit.BackColor == Color.White)
            {
                buttonFruit.BackColor = Color.DeepSkyBlue;
                buttonAnimal.BackColor = Color.White;
                buttonVehicles.BackColor = Color.White;
            }
            else
            {
                buttonFruit.BackColor = Color.White;
                flag = 0;
            }
        }

        private void buttonVehicles_Click(object sender, EventArgs e)
        {
            flag = 3;
            if (buttonVehicles.BackColor == Color.White)
            {
                buttonVehicles.BackColor = Color.DeepSkyBlue;
                buttonFruit.BackColor = Color.White;
                buttonAnimal.BackColor = Color.White;
            }
            else
            {
                buttonVehicles.BackColor = Color.White;
                flag = 0;
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 50) labelTime.Text = "00:0" + (59 - time).ToString();
            else labelTime.Text = "00:" + (59 - time).ToString();
            if (time >= 60) Result();

        }
        static int EleInArr(int a, int[]checking)
        {
            for(int i = 0; i < 6; i++)
            {
                if (a == checking[i]) return 1;
            }
            return 0;
        }
        int tmp = 0;
        private void game(int flag)
        {
            Random rand = new Random();
            int temp = rand.Next(11);
            while (EleInArr(temp, check) == 1)
            {
                temp = rand.Next(9);
            }
            check[tmp] = temp;
            switch (flag)
            {
                case 1: answer = animal(temp); break;
                case 2: answer = fruit(temp); break;
                case 3: answer = vehicle(temp); break;
            }
            tmp++;
        }
        int check_name_tmp(string s,DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (s == dt.Rows[i].ItemArray[0].ToString()) return 1;
            }
            return 0;
        }
        int check_name(int flag)
        {
            switch (flag)
            {
                case 1: return check_name_tmp(textName.Text, dtAnimal);
                case 2: return check_name_tmp(textName.Text, dtFruit);
                case 3: return check_name_tmp(textName.Text, dtVehicles);
            }
            return 0;
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                MessageBox.Show("Please choose your favorite topic!", "Notification");
            }
            else
            {
                if (textName.Text == "")
                {
                    MessageBox.Show("Please enter your name!", "Notification");
                }
                else if (check_name(flag) == 1)
                {
                    MessageBox.Show("The name was already used", "Notification");
                }
                else
                {
                    switch (flag)
                    {
                        case 1:
                            {
                                labelQuestion.Text = "What is this animal?";
                                break;
                            }
                        case 2:
                            {
                                labelQuestion.Text = "What is this fruit?";
                                break;
                            }
                        case 3:
                            {
                                labelQuestion.Text = "What is this vehicle?";
                                break;
                            }
                    }
                    panelGame.Visible = true;
                    game(flag);
                    if (!timer1.Enabled)
                    {
                        timer1.Start();
                    }
                    labelTime.Text = "00:59";
                }
            }
            
        }

        private void buttonBackpanel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Game is running, do you want to exit?", "Notification", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < 6; i++) check[i]=-1;
                tmp = 0;
                timer1.Enabled = !timer1.Enabled;
                panelGame.Visible = false;
                time = 0;
            }
        }

        private void buttonHomepanel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Game is running, do you want to exit?", "Notification", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                timer1.Enabled = !timer1.Enabled;
                time = 0;
                this.Hide();   
            }
            panelGame.Visible = false;
            for (int i = 0; i < 6; i++) check[i] = -1;
            tmp = 0;
            timer1.Enabled = !timer1.Enabled;
            this.AcceptButton = buttonOk;
            labelSco.Text = "Score: 0";
            labelRight.Text = "Right: 0/5";
            buttonAnimal.BackColor = Color.White;
            buttonFruit.BackColor = Color.White;
            buttonVehicles.BackColor = Color.White;
            textName.Text = "";
        }
        private void Result()
        {
            for (int i = 0; i < 6; i++) check[i] = -1;
            tmp = 0;
            timer1.Enabled = !timer1.Enabled;
            panelResult.Visible = true;
            labelResult.Text = score.ToString()+" point(s) in "+time.ToString()+" second(s)";
            this.AcceptButton = buttonpanelExit;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (answer == textAnswer.Text.ToLower())
            {
                score += 20;
            }
            textAnswer.Text = "";
            labelSco.Text = "Score: " + score.ToString();
            labelRight.Text = "Right: " + (score / 20).ToString() + "/5";
            game(flag);
            if (tmp == 6)
            {
                Result();
            }
        }

        private void buttonpanelExit_Click(object sender, EventArgs e)
        {
            AddData(flag);
            time = 0;
            score = 0;
            panelResult.Visible = false;
            panelGame.Visible = false;
            this.AcceptButton = buttonOk;
            labelSco.Text ="Score: 0";
            labelRight.Text = "Right: 0/5";
            buttonAnimal.BackColor = Color.White;
            buttonFruit.BackColor = Color.White;
            buttonVehicles.BackColor = Color.White;
            textName.Text = "";
            //them save data nua;
        }

        private void buttonVolu_Click(object sender, EventArgs e)
        {
            buttonVolu.Visible = false;
            buttonVolu.Enabled = false;
            buttonNoVolu.Enabled = true;
            buttonNoVolu.Visible = true;
            FormMain.play.Stop();
        }

        private void buttonNoVolu_Click(object sender, EventArgs e)
        {
            buttonNoVolu.Visible = false;
            buttonNoVolu.Enabled = false;
            buttonVolu.Enabled = true;
            buttonVolu.Visible = true;
            FormMain.play.Play();
        }
    }
}
