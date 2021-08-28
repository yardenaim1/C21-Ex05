using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowUI
{
    public class GameSettings : Form
    {
        private Label m_LabelPlayers = new Label();
        private Label m_LabelPlayer1 = new Label();
        private Label m_LabelPlayer2 = new Label();
        private Label m_LabelBoardSize = new Label();
        private Label m_LabelRows = new Label();
        private Label m_LabelCols = new Label();
       
        private TextBox m_TextboxPlayer1 = new TextBox();
        private TextBox m_TextboxPlayer2 = new TextBox();
        private CheckBox m_CheckBoxPlayer2 = new CheckBox();
        private NumericUpDown m_NumericUpDownRows = new NumericUpDown();
        private NumericUpDown m_NumericUpDownCols = new NumericUpDown();
        

        private Button m_ButtonStart = new Button();
        

        public GameSettings()
        {
            this.Text = "Game Settings";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Size = new Size(300,300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //Players Label
            this.m_LabelPlayers.AutoSize = true;
            this.m_LabelPlayers.Location = new System.Drawing.Point(15, 15);
            this.m_LabelPlayers.TabIndex = 0;
            this.m_LabelPlayers.Text = "Players:";
            this.Controls.Add(m_LabelPlayers);
            
            //Player1 Label
            this.m_LabelPlayer1.AutoSize = true;
            this.m_LabelPlayer1.Location = new System.Drawing.Point(29, 39);
            this.m_LabelPlayer1.TabIndex = 1;
            this.m_LabelPlayer1.Text = "Player 1:";
            this.Controls.Add(m_LabelPlayer1);

            //Player 1 textBox
            int textBoxPlayer1Top = m_LabelPlayer1.Top + m_LabelPlayer1.Height / 2;
            textBoxPlayer1Top -= m_TextboxPlayer1.Height / 2;

            this.m_TextboxPlayer1.Location = new Point(m_LabelPlayer1.Right + 15, textBoxPlayer1Top);
            this.m_TextboxPlayer1.TabIndex = 2;
            this.Controls.Add(m_TextboxPlayer1);

            //Player2 Label
            this.m_LabelPlayer2.AutoSize = true;
            this.m_LabelPlayer2.Location = new System.Drawing.Point(29, 59);
            this.m_LabelPlayer2.TabIndex = 3;
            this.m_LabelPlayer2.Text = "Player 2:";
            this.Controls.Add(m_LabelPlayer2);

            //Player 2 textBox
            int textBoxPlayer2Top = m_LabelPlayer2.Top + m_LabelPlayer2.Height / 2;
            textBoxPlayer2Top -= m_TextboxPlayer2.Height / 2;
            m_TextboxPlayer2.Enabled = false;
            this.m_TextboxPlayer2.Location = new System.Drawing.Point(m_LabelPlayer2.Right + 15, textBoxPlayer2Top);
            this.m_TextboxPlayer2.TabIndex = 4;
            m_TextboxPlayer2.Text = "[Computer]";
            this.Controls.Add(m_TextboxPlayer2);

            //Player2 check Box
            m_CheckBoxPlayer2.AutoSize = true;
            this.Controls.Add(m_CheckBoxPlayer2);




        }

    }
}
