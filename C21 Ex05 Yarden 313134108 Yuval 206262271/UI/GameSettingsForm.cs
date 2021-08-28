using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowUI
{
    using System;

    using UI;

    public class GameSettingsForm : Form
    {
        private const string k_AIName = "[Computer]";

        //private Label m_LabelPlayers = new Label();
        //private Label m_LabelPlayer1 = new Label();
        //private Label m_LabelPlayer2 = new Label();
        //private Label m_LabelBoardSize = new Label();
        //private Label m_LabelRows = new Label();
        //private Label m_LabelCols = new Label();
       
        //private TextBox m_TextboxPlayer1 = new TextBox();
        //private TextBox m_TextboxPlayer2 = new TextBox();
        //private CheckBox m_CheckBoxPlayer2 = new CheckBox();
        //private NumericUpDown m_NumericUpDownRows = new NumericUpDown();
        //private NumericUpDown m_NumericUpDownCols = new NumericUpDown();
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button m_ButtonStart = new Button();
        

        public GameSettingsForm()
        {
            //this.Text = "Game Settings";
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //this.Size = new Size(300,300);
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.MinimizeBox = false;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Player 2:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxSecondPlayer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(132, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = String.Format(@"{0}", k_AIName);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Board Size:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 172);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(210, 172);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(31, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rows";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(162, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cols";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(57, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // GameSettingsForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.Text = "Game Settings";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //private void YuvalInitializeComponent()
        //{
        //    //Players Label
        //    this.m_LabelPlayers.AutoSize = true;
        //    this.m_LabelPlayers.Location = new System.Drawing.Point(15, 15);
        //    this.m_LabelPlayers.TabIndex = 0;
        //    this.m_LabelPlayers.Text = "Players:";
        //    this.Controls.Add(m_LabelPlayers);
            
        //    //Player1 Label
        //    this.m_LabelPlayer1.AutoSize = true;
        //    this.m_LabelPlayer1.Location = new System.Drawing.Point(29, 39);
        //    this.m_LabelPlayer1.TabIndex = 1;
        //    this.m_LabelPlayer1.Text = "Player 1:";
        //    this.Controls.Add(m_LabelPlayer1);

        //    //Player 1 textBox
        //    int textBoxPlayer1Top = m_LabelPlayer1.Top + m_LabelPlayer1.Height / 2;
        //    textBoxPlayer1Top -= m_TextboxPlayer1.Height / 2;

        //    this.m_TextboxPlayer1.Location = new Point(m_LabelPlayer1.Right + 15, textBoxPlayer1Top);
        //    this.m_TextboxPlayer1.TabIndex = 2;
        //    this.Controls.Add(m_TextboxPlayer1);

        //    //Player2 Label
        //    this.m_LabelPlayer2.AutoSize = true;
        //    this.m_LabelPlayer2.Location = new System.Drawing.Point(29, 59);
        //    this.m_LabelPlayer2.TabIndex = 3;
        //    this.m_LabelPlayer2.Text = "Player 2:";
        //    this.Controls.Add(m_LabelPlayer2);

        //    //Player 2 textBox
        //    int textBoxPlayer2Top = m_LabelPlayer2.Top + m_LabelPlayer2.Height / 2;
        //    textBoxPlayer2Top -= m_TextboxPlayer2.Height / 2;
        //    m_TextboxPlayer2.Enabled = false;
        //    this.m_TextboxPlayer2.Location = new System.Drawing.Point(m_LabelPlayer2.Right + 15, textBoxPlayer2Top);
        //    this.m_TextboxPlayer2.TabIndex = 4;
        //    m_TextboxPlayer2.Text = "[Computer]";
        //    this.Controls.Add(m_TextboxPlayer2);

        //    //Player2 check Box
        //    m_CheckBoxPlayer2.AutoSize = true;
        //    this.Controls.Add(m_CheckBoxPlayer2);
        //}

        private void GameSettings_Load(object sender, System.EventArgs e)
        {

        }

        private void checkBoxSecondPlayer_Click(object sender, System.EventArgs e)
        {
            this.textBox2.Enabled = !this.textBox2.Enabled;
            textBox2.Text = textBox2.Enabled ? string.Empty : k_AIName;
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            if (this.textBox1.Text == string.Empty || this.textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter proper names (no blanks)", "Error");
            }
            else if (this.textBox1.Text == this.textBox2.Text)
            {
                MessageBox.Show("Players names should be different, please change one of the names and try again.", "Error");
            }
            else
            {
                GameForm gameForm = new GameForm(BoardHeight, BoardWidth, Player1Name, Player2Name, IsPlayer2AI);
                this.Dispose();
                gameForm.ShowDialog();
            }
        }

        public int BoardHeight
        {
            get { return (int)this.numericUpDown1.Value; }
        }

        public int BoardWidth
        {
            get { return (int)numericUpDown2.Value; }
        }

        public string Player1Name
        {
            get { return this.textBox1.Text; }
        }

        public string Player2Name
        {
            get { return textBox2.Text; }
        }

        public bool IsPlayer2AI
        {
            get { return !this.checkBox1.Checked; }
        }
    }
}
