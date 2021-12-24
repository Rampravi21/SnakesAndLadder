using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadderApp
{
    public partial class Form1 : Form
    {
        int flag = 0;
        int x = 20, y=423, diceValue,p=0;
        int bx = 20, by = 423,q = 0;

        bool green = false,yellow = false;
        //bool red = false;
        //bool blue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                btn_roll2.Enabled = false;
            }
            p5_pbx.Visible = false;
            p6_pbx.Visible = false;
            dice_pbx.Image = Image.FromFile(@"C:\Users\Sai\source\repos\SnakesAndLadderApp\Resources\dice.png");
            dice_pbx.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_roll_Click(object sender, EventArgs e)
        { 
            diceValue = RollDiceLogic.Rolldice(dice_pbx);
            lbl_number.Text = diceValue.ToString();

            if (green == true)
            {

               p =   RollDiceLogic.Move(ref x, ref y,p,diceValue, p5_pbx);
            
            }

            if ( green == false)
            {
                p5_pbx.Visible = true;
                p1_pbx.Visible = false;
                green = true;
                p5_pbx.Location = new Point(x, y);
                p++;
               
            }

            if(p==100)
            {
                MessageBox.Show("Win");
                btn_roll.Visible = false;
            }

            p = RollDiceLogic.Snakebite(ref x, ref y, p, p5_pbx);
            p = RollDiceLogic.Ladder(ref x, ref y, p, p5_pbx);

            if (diceValue == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                btn_roll.Enabled = false;
                btn_roll2.Enabled = true;
            }
        }

        private void btn_roll2_Click(object sender, EventArgs e)
        {
            diceValue = RollDiceLogic.Rolldice(dice_pbx);
            lbl_number.Text = diceValue.ToString();
            if (yellow == true)
            {

                q = RollDiceLogic.Move(ref bx, ref by, q, diceValue, p6_pbx);

            }

            if (yellow == false)
            {
                p6_pbx.Visible = true;
                p2_pbx.Visible = false;
                yellow = true;
                p6_pbx.Location = new Point(x, y);
                q++;

            }

            if (q == 100)
            {
                MessageBox.Show("Win");
                btn_roll2.Visible = false;
            }

            q = RollDiceLogic.Snakebite(ref bx, ref by, q, p6_pbx);
            q = RollDiceLogic.Ladder(ref bx, ref by, q, p6_pbx);

            if (diceValue == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                btn_roll2.Enabled = false;
                btn_roll.Enabled = true;
            }
        }

    }
}
