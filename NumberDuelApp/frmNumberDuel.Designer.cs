namespace NumberDuelApp
{
    partial class frmNumberDuel
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
            tblMain = new TableLayoutPanel();
            lblRule = new Label();
            lblNumPicked = new Label();
            btnStart = new Button();
            pnlPlayerOpt = new Panel();
            rbnPlayComp = new RadioButton();
            rbn2Player = new RadioButton();
            lblGameStat = new Label();
            pnlButtons = new Panel();
            btn16 = new Button();
            btn15 = new Button();
            btn14 = new Button();
            btn13 = new Button();
            btn12 = new Button();
            btn11 = new Button();
            btn10 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            tblMain.SuspendLayout();
            pnlPlayerOpt.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.Controls.Add(lblRule, 2, 1);
            tblMain.Controls.Add(lblNumPicked, 1, 1);
            tblMain.Controls.Add(btnStart, 0, 0);
            tblMain.Controls.Add(pnlPlayerOpt, 1, 0);
            tblMain.Controls.Add(lblGameStat, 0, 1);
            tblMain.Controls.Add(pnlButtons, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblRule
            // 
            lblRule.Dock = DockStyle.Fill;
            lblRule.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRule.Location = new Point(535, 67);
            lblRule.Name = "lblRule";
            lblRule.Size = new Size(262, 112);
            lblRule.TabIndex = 5;
            lblRule.Text = "All numbers picked must be either a multiple or a factor of the number picked previously";
            lblRule.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumPicked
            // 
            lblNumPicked.Anchor = AnchorStyles.None;
            lblNumPicked.BorderStyle = BorderStyle.FixedSingle;
            lblNumPicked.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumPicked.Location = new Point(277, 82);
            lblNumPicked.Name = "lblNumPicked";
            lblNumPicked.Size = new Size(243, 82);
            lblNumPicked.TabIndex = 3;
            lblNumPicked.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Left;
            btnStart.BackColor = SystemColors.ActiveCaptionText;
            btnStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(3, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(135, 43);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // pnlPlayerOpt
            // 
            tblMain.SetColumnSpan(pnlPlayerOpt, 2);
            pnlPlayerOpt.Controls.Add(rbnPlayComp);
            pnlPlayerOpt.Controls.Add(rbn2Player);
            pnlPlayerOpt.Dock = DockStyle.Fill;
            pnlPlayerOpt.Location = new Point(269, 3);
            pnlPlayerOpt.Name = "pnlPlayerOpt";
            pnlPlayerOpt.Size = new Size(528, 61);
            pnlPlayerOpt.TabIndex = 1;
            // 
            // rbnPlayComp
            // 
            rbnPlayComp.AutoSize = true;
            rbnPlayComp.Location = new Point(203, 16);
            rbnPlayComp.Name = "rbnPlayComp";
            rbnPlayComp.Size = new Size(145, 19);
            rbnPlayComp.TabIndex = 1;
            rbnPlayComp.Text = "Play against Computer";
            rbnPlayComp.UseVisualStyleBackColor = true;
            // 
            // rbn2Player
            // 
            rbn2Player.AutoSize = true;
            rbn2Player.Checked = true;
            rbn2Player.Location = new Point(55, 16);
            rbn2Player.Name = "rbn2Player";
            rbn2Player.Size = new Size(66, 19);
            rbn2Player.TabIndex = 0;
            rbn2Player.TabStop = true;
            rbn2Player.Text = "2 Player";
            rbn2Player.UseVisualStyleBackColor = true;
            // 
            // lblGameStat
            // 
            lblGameStat.Anchor = AnchorStyles.None;
            lblGameStat.BorderStyle = BorderStyle.FixedSingle;
            lblGameStat.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameStat.Location = new Point(11, 82);
            lblGameStat.Name = "lblGameStat";
            lblGameStat.Size = new Size(243, 82);
            lblGameStat.TabIndex = 2;
            lblGameStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            tblMain.SetColumnSpan(pnlButtons, 3);
            pnlButtons.Controls.Add(btn16);
            pnlButtons.Controls.Add(btn15);
            pnlButtons.Controls.Add(btn14);
            pnlButtons.Controls.Add(btn13);
            pnlButtons.Controls.Add(btn12);
            pnlButtons.Controls.Add(btn11);
            pnlButtons.Controls.Add(btn10);
            pnlButtons.Controls.Add(btn9);
            pnlButtons.Controls.Add(btn8);
            pnlButtons.Controls.Add(btn7);
            pnlButtons.Controls.Add(btn6);
            pnlButtons.Controls.Add(btn5);
            pnlButtons.Controls.Add(btn4);
            pnlButtons.Controls.Add(btn3);
            pnlButtons.Controls.Add(btn2);
            pnlButtons.Controls.Add(btn1);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(3, 182);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(794, 265);
            pnlButtons.TabIndex = 4;
            // 
            // btn16
            // 
            btn16.BackColor = Color.MediumSpringGreen;
            btn16.Location = new Point(694, 188);
            btn16.Name = "btn16";
            btn16.Size = new Size(75, 50);
            btn16.TabIndex = 19;
            btn16.Text = "16";
            btn16.UseVisualStyleBackColor = false;
            // 
            // btn15
            // 
            btn15.BackColor = Color.MediumSpringGreen;
            btn15.Location = new Point(683, 66);
            btn15.Name = "btn15";
            btn15.Size = new Size(75, 50);
            btn15.TabIndex = 18;
            btn15.Text = "15";
            btn15.UseVisualStyleBackColor = false;
            // 
            // btn14
            // 
            btn14.BackColor = Color.MediumSpringGreen;
            btn14.Location = new Point(585, 152);
            btn14.Name = "btn14";
            btn14.Size = new Size(75, 50);
            btn14.TabIndex = 17;
            btn14.Text = "14";
            btn14.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            btn13.BackColor = Color.MediumSpringGreen;
            btn13.Location = new Point(574, 37);
            btn13.Name = "btn13";
            btn13.Size = new Size(75, 50);
            btn13.TabIndex = 16;
            btn13.Text = "13";
            btn13.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            btn12.BackColor = Color.MediumSpringGreen;
            btn12.Location = new Point(485, 204);
            btn12.Name = "btn12";
            btn12.Size = new Size(75, 50);
            btn12.TabIndex = 15;
            btn12.Text = "12";
            btn12.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            btn11.BackColor = Color.MediumSpringGreen;
            btn11.Location = new Point(465, 107);
            btn11.Name = "btn11";
            btn11.Size = new Size(75, 50);
            btn11.TabIndex = 14;
            btn11.Text = "11";
            btn11.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            btn10.BackColor = Color.MediumSpringGreen;
            btn10.Location = new Point(422, 10);
            btn10.Name = "btn10";
            btn10.Size = new Size(75, 50);
            btn10.TabIndex = 13;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.MediumSpringGreen;
            btn9.Location = new Point(368, 167);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 50);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.MediumSpringGreen;
            btn8.Location = new Point(327, 77);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 50);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.MediumSpringGreen;
            btn7.Location = new Point(255, 206);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 50);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.MediumSpringGreen;
            btn6.Location = new Point(220, 128);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 50);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.MediumSpringGreen;
            btn5.Location = new Point(243, 10);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 50);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.MediumSpringGreen;
            btn4.Location = new Point(89, 188);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 50);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.MediumSpringGreen;
            btn3.Location = new Point(9, 116);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 50);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.MediumSpringGreen;
            btn2.Location = new Point(124, 66);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 50);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.MediumSpringGreen;
            btn1.Location = new Point(36, 10);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 50);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // frmNumberDuel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmNumberDuel";
            Text = "frmNumberDuel";
            tblMain.ResumeLayout(false);
            pnlPlayerOpt.ResumeLayout(false);
            pnlPlayerOpt.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnStart;
        private Label lblNumPicked;
        private Panel pnlPlayerOpt;
        private RadioButton rbnPlayComp;
        private RadioButton rbn2Player;
        private Label lblGameStat;
        private Panel pnlButtons;
        private Button btn16;
        private Button btn15;
        private Button btn14;
        private Button btn13;
        private Button btn12;
        private Button btn11;
        private Button btn10;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Label lblRule;
    }
}