
namespace SnakesAndLadderApp
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_roll2 = new System.Windows.Forms.Button();
            this.lbl_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_roll = new System.Windows.Forms.Button();
            this.dice_pbx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p4_pbx = new System.Windows.Forms.PictureBox();
            this.p3_pbx = new System.Windows.Forms.PictureBox();
            this.p2_pbx = new System.Windows.Forms.PictureBox();
            this.p1_pbx = new System.Windows.Forms.PictureBox();
            this.board_panel = new System.Windows.Forms.Panel();
            this.p6_pbx = new System.Windows.Forms.PictureBox();
            this.p5_pbx = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice_pbx)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p4_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_pbx)).BeginInit();
            this.board_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p6_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_roll2);
            this.panel2.Controls.Add(this.lbl_number);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_roll);
            this.panel2.Controls.Add(this.dice_pbx);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(676, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 461);
            this.panel2.TabIndex = 0;
            // 
            // btn_roll2
            // 
            this.btn_roll2.BackColor = System.Drawing.Color.Yellow;
            this.btn_roll2.Location = new System.Drawing.Point(82, 319);
            this.btn_roll2.Name = "btn_roll2";
            this.btn_roll2.Size = new System.Drawing.Size(62, 34);
            this.btn_roll2.TabIndex = 3;
            this.btn_roll2.Text = "Player2";
            this.btn_roll2.UseVisualStyleBackColor = false;
            this.btn_roll2.Click += new System.EventHandler(this.btn_roll2_Click);
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(73, 144);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(44, 13);
            this.lbl_number.TabIndex = 2;
            this.lbl_number.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dice : ";
            // 
            // btn_roll
            // 
            this.btn_roll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_roll.Location = new System.Drawing.Point(17, 319);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(59, 34);
            this.btn_roll.TabIndex = 0;
            this.btn_roll.Text = "Player1";
            this.btn_roll.UseVisualStyleBackColor = false;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // dice_pbx
            // 
            this.dice_pbx.Location = new System.Drawing.Point(32, 216);
            this.dice_pbx.Name = "dice_pbx";
            this.dice_pbx.Size = new System.Drawing.Size(100, 80);
            this.dice_pbx.TabIndex = 0;
            this.dice_pbx.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.p4_pbx);
            this.panel1.Controls.Add(this.p3_pbx);
            this.panel1.Controls.Add(this.p2_pbx);
            this.panel1.Controls.Add(this.p1_pbx);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 74);
            this.panel1.TabIndex = 0;
            // 
            // p4_pbx
            // 
            this.p4_pbx.BackgroundImage = global::SnakesAndLadderApp.Properties.Resources.p4;
            this.p4_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p4_pbx.Location = new System.Drawing.Point(135, 7);
            this.p4_pbx.Name = "p4_pbx";
            this.p4_pbx.Size = new System.Drawing.Size(37, 51);
            this.p4_pbx.TabIndex = 3;
            this.p4_pbx.TabStop = false;
            // 
            // p3_pbx
            // 
            this.p3_pbx.BackgroundImage = global::SnakesAndLadderApp.Properties.Resources.p3;
            this.p3_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p3_pbx.Location = new System.Drawing.Point(92, 7);
            this.p3_pbx.Name = "p3_pbx";
            this.p3_pbx.Size = new System.Drawing.Size(37, 51);
            this.p3_pbx.TabIndex = 2;
            this.p3_pbx.TabStop = false;
            // 
            // p2_pbx
            // 
            this.p2_pbx.BackgroundImage = global::SnakesAndLadderApp.Properties.Resources.p2;
            this.p2_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2_pbx.Location = new System.Drawing.Point(49, 7);
            this.p2_pbx.Name = "p2_pbx";
            this.p2_pbx.Size = new System.Drawing.Size(37, 51);
            this.p2_pbx.TabIndex = 1;
            this.p2_pbx.TabStop = false;
            // 
            // p1_pbx
            // 
            this.p1_pbx.BackgroundImage = global::SnakesAndLadderApp.Properties.Resources.p1;
            this.p1_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1_pbx.Location = new System.Drawing.Point(6, 7);
            this.p1_pbx.Name = "p1_pbx";
            this.p1_pbx.Size = new System.Drawing.Size(37, 51);
            this.p1_pbx.TabIndex = 0;
            this.p1_pbx.TabStop = false;
            // 
            // board_panel
            // 
            this.board_panel.BackgroundImage = global::SnakesAndLadderApp.Properties.Resources.Board;
            this.board_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.board_panel.Controls.Add(this.p6_pbx);
            this.board_panel.Controls.Add(this.p5_pbx);
            this.board_panel.Location = new System.Drawing.Point(1, 2);
            this.board_panel.Name = "board_panel";
            this.board_panel.Size = new System.Drawing.Size(669, 461);
            this.board_panel.TabIndex = 0;
            // 
            // p6_pbx
            // 
            this.p6_pbx.BackgroundImage = global::SnakesAndLadderApp.Properties.Resources.p2;
            this.p6_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p6_pbx.Location = new System.Drawing.Point(3, 422);
            this.p6_pbx.Name = "p6_pbx";
            this.p6_pbx.Size = new System.Drawing.Size(37, 24);
            this.p6_pbx.TabIndex = 2;
            this.p6_pbx.TabStop = false;
            // 
            // p5_pbx
            // 
            this.p5_pbx.BackgroundImage = global::SnakesAndLadderApp.Properties.Resources.p1;
            this.p5_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p5_pbx.Location = new System.Drawing.Point(30, 422);
            this.p5_pbx.Name = "p5_pbx";
            this.p5_pbx.Size = new System.Drawing.Size(37, 24);
            this.p5_pbx.TabIndex = 1;
            this.p5_pbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.board_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice_pbx)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p4_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_pbx)).EndInit();
            this.board_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p6_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel board_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox p4_pbx;
        private System.Windows.Forms.PictureBox p3_pbx;
        private System.Windows.Forms.PictureBox p2_pbx;
        private System.Windows.Forms.PictureBox p1_pbx;
        private System.Windows.Forms.PictureBox dice_pbx;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.PictureBox p5_pbx;
        private System.Windows.Forms.PictureBox p6_pbx;
        private System.Windows.Forms.Button btn_roll2;
    }
}

