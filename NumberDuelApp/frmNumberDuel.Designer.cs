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
            btnStart = new Button();
            pnlPlayerOpt = new Panel();
            rbn2Player = new RadioButton();
            rbnPlayComp = new RadioButton();
            lblGameStat = new Label();
            lblNumPicked = new Label();
            pnlButtons = new Panel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            bnt6 = new Button();
            bnt7 = new Button();
            bnt8 = new Button();
            bnt9 = new Button();
            bny10 = new Button();
            bnt11 = new Button();
            bnt12 = new Button();
            bnt13 = new Button();
            bnt14 = new Button();
            bnt15 = new Button();
            bnt16 = new Button();
            tblMain.SuspendLayout();
            pnlPlayerOpt.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
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
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
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
            pnlPlayerOpt.Controls.Add(rbnPlayComp);
            pnlPlayerOpt.Controls.Add(rbn2Player);
            pnlPlayerOpt.Dock = DockStyle.Fill;
            pnlPlayerOpt.Location = new Point(403, 3);
            pnlPlayerOpt.Name = "pnlPlayerOpt";
            pnlPlayerOpt.Size = new Size(394, 61);
            pnlPlayerOpt.TabIndex = 1;
            // 
            // rbn2Player
            // 
            rbn2Player.AutoSize = true;
            rbn2Player.Location = new Point(55, 16);
            rbn2Player.Name = "rbn2Player";
            rbn2Player.Size = new Size(66, 19);
            rbn2Player.TabIndex = 0;
            rbn2Player.TabStop = true;
            rbn2Player.Text = "2 Player";
            rbn2Player.UseVisualStyleBackColor = true;
            // 
            // rbnPlayComp
            // 
            rbnPlayComp.AutoSize = true;
            rbnPlayComp.Location = new Point(203, 16);
            rbnPlayComp.Name = "rbnPlayComp";
            rbnPlayComp.Size = new Size(145, 19);
            rbnPlayComp.TabIndex = 1;
            rbnPlayComp.TabStop = true;
            rbnPlayComp.Text = "Play against Computer";
            rbnPlayComp.UseVisualStyleBackColor = true;
            // 
            // lblGameStat
            // 
            lblGameStat.Anchor = AnchorStyles.None;
            lblGameStat.BorderStyle = BorderStyle.FixedSingle;
            lblGameStat.Location = new Point(78, 82);
            lblGameStat.Name = "lblGameStat";
            lblGameStat.Size = new Size(243, 82);
            lblGameStat.TabIndex = 2;
            lblGameStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumPicked
            // 
            lblNumPicked.Anchor = AnchorStyles.None;
            lblNumPicked.BorderStyle = BorderStyle.FixedSingle;
            lblNumPicked.Location = new Point(478, 82);
            lblNumPicked.Name = "lblNumPicked";
            lblNumPicked.Size = new Size(243, 82);
            lblNumPicked.TabIndex = 3;
            lblNumPicked.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            tblMain.SetColumnSpan(pnlButtons, 2);
            pnlButtons.Controls.Add(bnt16);
            pnlButtons.Controls.Add(bnt15);
            pnlButtons.Controls.Add(bnt14);
            pnlButtons.Controls.Add(bnt13);
            pnlButtons.Controls.Add(bnt12);
            pnlButtons.Controls.Add(bnt11);
            pnlButtons.Controls.Add(bny10);
            pnlButtons.Controls.Add(bnt9);
            pnlButtons.Controls.Add(bnt8);
            pnlButtons.Controls.Add(bnt7);
            pnlButtons.Controls.Add(bnt6);
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
            // btn1
            // 
            btn1.Location = new Point(36, 10);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 50);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(124, 66);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 50);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(9, 116);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 50);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(89, 188);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 50);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(243, 10);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 50);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // bnt6
            // 
            bnt6.Location = new Point(220, 128);
            bnt6.Name = "bnt6";
            bnt6.Size = new Size(75, 50);
            bnt6.TabIndex = 9;
            bnt6.Text = "6";
            bnt6.UseVisualStyleBackColor = true;
            // 
            // bnt7
            // 
            bnt7.Location = new Point(255, 206);
            bnt7.Name = "bnt7";
            bnt7.Size = new Size(75, 50);
            bnt7.TabIndex = 10;
            bnt7.Text = "7";
            bnt7.UseVisualStyleBackColor = true;
            // 
            // bnt8
            // 
            bnt8.Location = new Point(327, 77);
            bnt8.Name = "bnt8";
            bnt8.Size = new Size(75, 50);
            bnt8.TabIndex = 11;
            bnt8.Text = "8";
            bnt8.UseVisualStyleBackColor = true;
            // 
            // bnt9
            // 
            bnt9.Location = new Point(368, 167);
            bnt9.Name = "bnt9";
            bnt9.Size = new Size(75, 50);
            bnt9.TabIndex = 12;
            bnt9.Text = "9";
            bnt9.UseVisualStyleBackColor = true;
            // 
            // bny10
            // 
            bny10.Location = new Point(422, 10);
            bny10.Name = "bny10";
            bny10.Size = new Size(75, 50);
            bny10.TabIndex = 13;
            bny10.Text = "10";
            bny10.UseVisualStyleBackColor = true;
            // 
            // bnt11
            // 
            bnt11.Location = new Point(465, 107);
            bnt11.Name = "bnt11";
            bnt11.Size = new Size(75, 50);
            bnt11.TabIndex = 14;
            bnt11.Text = "11";
            bnt11.UseVisualStyleBackColor = true;
            // 
            // bnt12
            // 
            bnt12.Location = new Point(485, 204);
            bnt12.Name = "bnt12";
            bnt12.Size = new Size(75, 50);
            bnt12.TabIndex = 15;
            bnt12.Text = "12";
            bnt12.UseVisualStyleBackColor = true;
            // 
            // bnt13
            // 
            bnt13.Location = new Point(574, 37);
            bnt13.Name = "bnt13";
            bnt13.Size = new Size(75, 50);
            bnt13.TabIndex = 16;
            bnt13.Text = "13";
            bnt13.UseVisualStyleBackColor = true;
            // 
            // bnt14
            // 
            bnt14.Location = new Point(585, 152);
            bnt14.Name = "bnt14";
            bnt14.Size = new Size(75, 50);
            bnt14.TabIndex = 17;
            bnt14.Text = "14";
            bnt14.UseVisualStyleBackColor = true;
            // 
            // bnt15
            // 
            bnt15.Location = new Point(683, 66);
            bnt15.Name = "bnt15";
            bnt15.Size = new Size(75, 50);
            bnt15.TabIndex = 18;
            bnt15.Text = "15";
            bnt15.UseVisualStyleBackColor = true;
            // 
            // bnt16
            // 
            bnt16.Location = new Point(694, 188);
            bnt16.Name = "bnt16";
            bnt16.Size = new Size(75, 50);
            bnt16.TabIndex = 19;
            bnt16.Text = "16";
            bnt16.UseVisualStyleBackColor = true;
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
        private Button bnt16;
        private Button bnt15;
        private Button bnt14;
        private Button bnt13;
        private Button bnt12;
        private Button bnt11;
        private Button bny10;
        private Button bnt9;
        private Button bnt8;
        private Button bnt7;
        private Button bnt6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
    }
}