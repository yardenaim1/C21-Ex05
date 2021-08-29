using System;
using System.Windows.Forms;

namespace UI
{
    public class GameForm : Form
    {
        private readonly string r_Player1Name, r_Player2Name;
        private readonly bool r_IsPlayer2AI;
        private readonly int r_Rows, r_Cols;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCol1;
        private Button buttonCol2;
        private Button buttonCol3;
        private Button buttonCol4;
        private Label label4;

        private void buttonCol3_Click(object sender, EventArgs e)
        {

        }

        public GameForm(int i_BoardHeight, int i_BoardWidth, string i_Player1Name, string i_Player2Name, bool i_IsAI)
        {
            this.r_Rows = i_BoardHeight;
            this.r_Cols = i_BoardWidth;
            this.r_Player1Name = i_Player1Name;
            this.r_Player2Name = i_Player2Name;
            this.r_IsPlayer2AI = i_IsAI;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCol1 = new System.Windows.Forms.Button();
            this.buttonCol2 = new System.Windows.Forms.Button();
            this.buttonCol3 = new System.Windows.Forms.Button();
            this.buttonCol4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // buttonCol1
            // 
            this.buttonCol1.Location = new System.Drawing.Point(24, 12);
            this.buttonCol1.Name = "buttonCol1";
            this.buttonCol1.Size = new System.Drawing.Size(38, 35);
            this.buttonCol1.TabIndex = 4;
            this.buttonCol1.Text = "1";
            this.buttonCol1.UseVisualStyleBackColor = true;
            // 
            // buttonCol2
            // 
            this.buttonCol2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCol2.Location = new System.Drawing.Point(87, 12);
            this.buttonCol2.Name = "buttonCol2";
            this.buttonCol2.Size = new System.Drawing.Size(38, 35);
            this.buttonCol2.TabIndex = 5;
            this.buttonCol2.Text = "2";
            this.buttonCol2.UseVisualStyleBackColor = true;
            // 
            // buttonCol3
            // 
            this.buttonCol3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCol3.Location = new System.Drawing.Point(157, 12);
            this.buttonCol3.Name = "buttonCol3";
            this.buttonCol3.Size = new System.Drawing.Size(38, 35);
            this.buttonCol3.TabIndex = 6;
            this.buttonCol3.Text = "3";
            this.buttonCol3.UseVisualStyleBackColor = true;
            this.buttonCol3.Click += new System.EventHandler(this.buttonCol3_Click);
            // 
            // buttonCol4
            // 
            this.buttonCol4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCol4.Location = new System.Drawing.Point(224, 12);
            this.buttonCol4.Name = "buttonCol4";
            this.buttonCol4.Size = new System.Drawing.Size(38, 35);
            this.buttonCol4.TabIndex = 7;
            this.buttonCol4.Text = "4";
            this.buttonCol4.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(611, 210);
            this.Controls.Add(this.buttonCol4);
            this.Controls.Add(this.buttonCol3);
            this.Controls.Add(this.buttonCol2);
            this.Controls.Add(this.buttonCol1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4 in a Raw !!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
