using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourInARowUI;
using UI;

namespace FourInARowUI
{

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
        //private Button m_ButtonStart = new Button();

        private Label label1Players;
        private Label labelPlayer1;
        private CheckBox checkBoxPlayer2;
        private TextBox textBoxPlayer1;
        private TextBox textBoxPlayer2;
        private Label labelBoardSize;
        private NumericUpDown numericUpDownRows;
        private NumericUpDown numericUpDownCols;
        private Label labelRows;
        private Label labelCols;
        private Button buttonStartGame;
        

        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1Players = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelCols = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Players
            // 
            this.label1Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1Players.Location = new System.Drawing.Point(21, 19);
            this.label1Players.Name = "label1Players";
            this.label1Players.Size = new System.Drawing.Size(77, 20);
            this.label1Players.TabIndex = 0;
            this.label1Players.Text = "Players:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(45, 52);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(57, 13);
            this.labelPlayer1.TabIndex = 1;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(48, 78);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(76, 17);
            this.checkBoxPlayer2.TabIndex = 1;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxSecondPlayer_Click);
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(132, 49);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer1.TabIndex = 0;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(132, 76);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer2.TabIndex = 2;
            this.textBoxPlayer2.Text = "[Computer]";
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBoardSize.Location = new System.Drawing.Point(21, 139);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(92, 17);
            this.labelBoardSize.TabIndex = 6;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(89, 172);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownRows.TabIndex = 3;
            this.numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(210, 172);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownCols.TabIndex = 4;
            this.numericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelRows
            // 
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRows.Location = new System.Drawing.Point(31, 172);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(52, 25);
            this.labelRows.TabIndex = 9;
            this.labelRows.Text = "Rows";
            // 
            // labelCols
            // 
            this.labelCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCols.Location = new System.Drawing.Point(162, 172);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(42, 25);
            this.labelCols.TabIndex = 10;
            this.labelCols.Text = "Cols";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStartGame.Location = new System.Drawing.Point(24, 217);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(221, 23);
            this.buttonStartGame.TabIndex = 5;
            this.buttonStartGame.Text = "Start!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // GameSettingsForm
            // 
            this.AcceptButton = this.buttonStartGame;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelCols);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.label1Players);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
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
        
        private void checkBoxSecondPlayer_Click(object sender, System.EventArgs e)
        {
            this.textBoxPlayer2.Enabled = !this.textBoxPlayer2.Enabled;
            textBoxPlayer2.Text = textBoxPlayer2.Enabled ? string.Empty : k_AIName;
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            if (this.textBoxPlayer1.Text == string.Empty || this.textBoxPlayer2.Text == string.Empty)
            {
                MessageBox.Show("Please enter proper names (no blanks)", "Error");
            }
            else if (this.textBoxPlayer1.Text == this.textBoxPlayer2.Text)
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
            get { return (int)this.numericUpDownRows.Value; }
        }

        public int BoardWidth
        {
            get { return (int)numericUpDownCols.Value; }
        }

        public string Player1Name
        {
            get { return this.textBoxPlayer1.Text; }
        }

        public string Player2Name
        {
            get { return textBoxPlayer2.Text; }
        }

        public bool IsPlayer2AI
        {
            get { return !this.checkBoxPlayer2.Checked; }
        }
    }
}
