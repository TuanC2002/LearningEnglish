namespace Game
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.buttonAnimal = new System.Windows.Forms.Button();
            this.buttonFruit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonVehicles = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.buttonpanelExit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCongra = new System.Windows.Forms.Label();
            this.buttonNoVolu = new System.Windows.Forms.Button();
            this.buttonVolu = new System.Windows.Forms.Button();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelSco = new System.Windows.Forms.Label();
            this.pictureQuestion = new System.Windows.Forms.PictureBox();
            this.buttonHomepanel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.buttonBackpanel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnimal
            // 
            this.buttonAnimal.BackColor = System.Drawing.Color.White;
            this.buttonAnimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnimal.BackgroundImage")));
            this.buttonAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnimal.Location = new System.Drawing.Point(249, 117);
            this.buttonAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAnimal.Name = "buttonAnimal";
            this.buttonAnimal.Size = new System.Drawing.Size(168, 219);
            this.buttonAnimal.TabIndex = 0;
            this.buttonAnimal.UseVisualStyleBackColor = false;
            this.buttonAnimal.Click += new System.EventHandler(this.buttonAnimal_Click);
            // 
            // buttonFruit
            // 
            this.buttonFruit.BackColor = System.Drawing.Color.White;
            this.buttonFruit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFruit.BackgroundImage")));
            this.buttonFruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFruit.Location = new System.Drawing.Point(658, 117);
            this.buttonFruit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFruit.Name = "buttonFruit";
            this.buttonFruit.Size = new System.Drawing.Size(165, 219);
            this.buttonFruit.TabIndex = 1;
            this.buttonFruit.UseVisualStyleBackColor = false;
            this.buttonFruit.Click += new System.EventHandler(this.buttonFruit_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(411, 391);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(243, 52);
            this.textName.TabIndex = 3;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(305, 399);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 31);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // buttonVehicles
            // 
            this.buttonVehicles.BackColor = System.Drawing.Color.White;
            this.buttonVehicles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVehicles.BackgroundImage")));
            this.buttonVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVehicles.Location = new System.Drawing.Point(455, 117);
            this.buttonVehicles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVehicles.Name = "buttonVehicles";
            this.buttonVehicles.Size = new System.Drawing.Size(168, 219);
            this.buttonVehicles.TabIndex = 5;
            this.buttonVehicles.UseVisualStyleBackColor = false;
            this.buttonVehicles.Click += new System.EventHandler(this.buttonVehicles_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.Color.Brown;
            this.buttonBack.Location = new System.Drawing.Point(0, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(95, 79);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGame.BackgroundImage")));
            this.panelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGame.Controls.Add(this.panelResult);
            this.panelGame.Controls.Add(this.buttonNoVolu);
            this.panelGame.Controls.Add(this.buttonVolu);
            this.panelGame.Controls.Add(this.labelRight);
            this.panelGame.Controls.Add(this.labelSco);
            this.panelGame.Controls.Add(this.pictureQuestion);
            this.panelGame.Controls.Add(this.buttonHomepanel);
            this.panelGame.Controls.Add(this.buttonOk);
            this.panelGame.Controls.Add(this.labelTime);
            this.panelGame.Controls.Add(this.labelQuestion);
            this.panelGame.Controls.Add(this.textAnswer);
            this.panelGame.Controls.Add(this.buttonBackpanel);
            this.panelGame.Location = new System.Drawing.Point(0, 3);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1113, 743);
            this.panelGame.TabIndex = 7;
            this.panelGame.Visible = false;
            // 
            // panelResult
            // 
            this.panelResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelResult.BackgroundImage")));
            this.panelResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelResult.Controls.Add(this.buttonpanelExit);
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Controls.Add(this.labelScore);
            this.panelResult.Controls.Add(this.labelCongra);
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(1113, 750);
            this.panelResult.TabIndex = 16;
            this.panelResult.Visible = false;
            // 
            // buttonpanelExit
            // 
            this.buttonpanelExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonpanelExit.BackgroundImage")));
            this.buttonpanelExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpanelExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonpanelExit.ForeColor = System.Drawing.Color.Brown;
            this.buttonpanelExit.Location = new System.Drawing.Point(462, 415);
            this.buttonpanelExit.Name = "buttonpanelExit";
            this.buttonpanelExit.Size = new System.Drawing.Size(173, 95);
            this.buttonpanelExit.TabIndex = 13;
            this.buttonpanelExit.Text = "Exit";
            this.buttonpanelExit.UseVisualStyleBackColor = true;
            this.buttonpanelExit.Click += new System.EventHandler(this.buttonpanelExit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI Black", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(361, 314);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(56, 62);
            this.labelResult.TabIndex = 2;
            this.labelResult.Tag = "";
            this.labelResult.Text = "0";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI Black", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelScore.ForeColor = System.Drawing.Color.Red;
            this.labelScore.Location = new System.Drawing.Point(305, 211);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(327, 62);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Your score is:";
            // 
            // labelCongra
            // 
            this.labelCongra.AutoSize = true;
            this.labelCongra.BackColor = System.Drawing.Color.Transparent;
            this.labelCongra.Font = new System.Drawing.Font("Segoe UI Black", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelCongra.ForeColor = System.Drawing.Color.Red;
            this.labelCongra.Location = new System.Drawing.Point(302, 115);
            this.labelCongra.Name = "labelCongra";
            this.labelCongra.Size = new System.Drawing.Size(378, 62);
            this.labelCongra.TabIndex = 0;
            this.labelCongra.Text = "Congratuation!";
            // 
            // buttonNoVolu
            // 
            this.buttonNoVolu.BackColor = System.Drawing.Color.Transparent;
            this.buttonNoVolu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNoVolu.BackgroundImage")));
            this.buttonNoVolu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNoVolu.FlatAppearance.BorderSize = 0;
            this.buttonNoVolu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNoVolu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNoVolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoVolu.Location = new System.Drawing.Point(214, 3);
            this.buttonNoVolu.Name = "buttonNoVolu";
            this.buttonNoVolu.Size = new System.Drawing.Size(102, 76);
            this.buttonNoVolu.TabIndex = 20;
            this.buttonNoVolu.UseVisualStyleBackColor = false;
            this.buttonNoVolu.Visible = false;
            this.buttonNoVolu.Click += new System.EventHandler(this.buttonNoVolu_Click);
            // 
            // buttonVolu
            // 
            this.buttonVolu.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVolu.BackgroundImage")));
            this.buttonVolu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVolu.FlatAppearance.BorderSize = 0;
            this.buttonVolu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVolu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolu.Location = new System.Drawing.Point(214, 3);
            this.buttonVolu.Name = "buttonVolu";
            this.buttonVolu.Size = new System.Drawing.Size(102, 76);
            this.buttonVolu.TabIndex = 19;
            this.buttonVolu.UseVisualStyleBackColor = false;
            this.buttonVolu.Click += new System.EventHandler(this.buttonVolu_Click);
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.BackColor = System.Drawing.Color.Transparent;
            this.labelRight.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRight.ForeColor = System.Drawing.Color.Red;
            this.labelRight.Location = new System.Drawing.Point(857, 362);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(148, 38);
            this.labelRight.TabIndex = 18;
            this.labelRight.Text = "Right: 0/5";
            // 
            // labelSco
            // 
            this.labelSco.AutoSize = true;
            this.labelSco.BackColor = System.Drawing.Color.Transparent;
            this.labelSco.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSco.ForeColor = System.Drawing.Color.Red;
            this.labelSco.Location = new System.Drawing.Point(857, 283);
            this.labelSco.Name = "labelSco";
            this.labelSco.Size = new System.Drawing.Size(121, 38);
            this.labelSco.TabIndex = 17;
            this.labelSco.Text = "Score: 0";
            // 
            // pictureQuestion
            // 
            this.pictureQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureQuestion.Location = new System.Drawing.Point(291, 211);
            this.pictureQuestion.Name = "pictureQuestion";
            this.pictureQuestion.Size = new System.Drawing.Size(221, 273);
            this.pictureQuestion.TabIndex = 14;
            this.pictureQuestion.TabStop = false;
            // 
            // buttonHomepanel
            // 
            this.buttonHomepanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHomepanel.BackgroundImage")));
            this.buttonHomepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHomepanel.FlatAppearance.BorderSize = 0;
            this.buttonHomepanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomepanel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonHomepanel.ForeColor = System.Drawing.Color.Brown;
            this.buttonHomepanel.Location = new System.Drawing.Point(113, 0);
            this.buttonHomepanel.Name = "buttonHomepanel";
            this.buttonHomepanel.Size = new System.Drawing.Size(95, 79);
            this.buttonHomepanel.TabIndex = 13;
            this.buttonHomepanel.UseVisualStyleBackColor = false;
            this.buttonHomepanel.Click += new System.EventHandler(this.buttonHomepanel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOk.BackgroundImage")));
            this.buttonOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonOk.ForeColor = System.Drawing.Color.Brown;
            this.buttonOk.Location = new System.Drawing.Point(633, 362);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(173, 95);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(727, 155);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(107, 47);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "00:59";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.ForeColor = System.Drawing.Color.Brown;
            this.labelQuestion.Location = new System.Drawing.Point(243, 155);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 45);
            this.labelQuestion.TabIndex = 10;
            // 
            // textAnswer
            // 
            this.textAnswer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textAnswer.Location = new System.Drawing.Point(563, 281);
            this.textAnswer.Multiline = true;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(243, 52);
            this.textAnswer.TabIndex = 9;
            this.textAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBackpanel
            // 
            this.buttonBackpanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackpanel.BackgroundImage")));
            this.buttonBackpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackpanel.FlatAppearance.BorderSize = 0;
            this.buttonBackpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackpanel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonBackpanel.ForeColor = System.Drawing.Color.Brown;
            this.buttonBackpanel.Location = new System.Drawing.Point(3, 3);
            this.buttonBackpanel.Name = "buttonBackpanel";
            this.buttonBackpanel.Size = new System.Drawing.Size(95, 79);
            this.buttonBackpanel.TabIndex = 7;
            this.buttonBackpanel.UseVisualStyleBackColor = false;
            this.buttonBackpanel.Click += new System.EventHandler(this.buttonBackpanel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.ForeColor = System.Drawing.Color.Brown;
            this.buttonPlay.Location = new System.Drawing.Point(727, 365);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(173, 95);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // FormGame
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonBack;
            this.ClientSize = new System.Drawing.Size(1119, 743);
            this.ControlBox = false;
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonVehicles);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonFruit);
            this.Controls.Add(this.buttonAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngLearning";
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAnimal;
        private Button buttonFruit;
        private TextBox textName;
        private Label labelName;
        private Button buttonVehicles;
        private Button buttonBack;
        private Panel panelGame;
        private Button buttonBackpanel;
        private Label labelTime;
        private Label labelQuestion;
        private TextBox textAnswer;
        private System.Windows.Forms.Timer timer1;
        private Button buttonPlay;
        private Button buttonOk;
        private Button buttonHomepanel;
        private PictureBox pictureQuestion;
        private Panel panelResult;
        private Label labelScore;
        private Label labelCongra;
        private Label labelResult;
        private Button buttonpanelExit;
        private Label labelSco;
        private Label labelRight;
        private Button buttonNoVolu;
        private Button buttonVolu;
    }
}