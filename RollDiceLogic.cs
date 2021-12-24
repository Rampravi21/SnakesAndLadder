using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadderApp
{
    class RollDiceLogic
    {
        public static int Rolldice(PictureBox pxb)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);
            pxb.Image = Image.FromFile(@"C:\Users\Sai\source\repos\SnakesAndLadderApp\Resources\" + dice + ".png");
            return dice;

        }
        public static int Move(ref int x, ref int y, int p, int dice, PictureBox pxb)
        {
            if (dice + p > 100) //101
            {
                MessageBox.Show("Cannot Move the dice");

            }

            else
            {
                for (int i = 0; i < dice; i++)
                {
                    if (p == 10)
                    {
                        x = 604; y = 380;

                    }
                    else if (p >= 11 && p <= 19)
                    {
                        x -= 65;
                    }
                    else if (p == 20)
                    {
                        x = 20; y = 340;
                    }

                    else if (p == 30)
                    {
                        x = 604; y = 290;
                    }
                    else if (p >= 31 && p <= 39)
                    {
                        x -= 65;
                    }
                    else if (p == 40)
                    {
                        x = 20; y = 243;
                    }

                    else if (p == 50)
                    {
                        x = 604; y = 200;
                    }
                    else if (p >= 51 && p <= 59)
                    {
                        x -= 65;
                    }
                    else if (p == 60)
                    {
                        x = 20; y = 153;
                    }
                    else if (p == 70)
                    {
                        x = 604; y = 102;
                    }
                    else if (p >= 71 && p <= 79)
                    {
                        x -= 65;
                    }
                    else if (p == 80)
                    {
                        x = 20; y = 60;
                    }
                    else if (p == 90)
                    {
                        x = 604; y = 10;
                    }
                    else if (p >= 91 && p <= 99)
                    {
                        x -= 65;
                    }
                    else
                    {
                        x += 65;
                    }
                    pxb.Location = new Point(x, y);
                    p++;
                    
                }


            }

            return p;
        }
        public static int Snakebite(ref int x, ref int y, int p, PictureBox pxb)
        {
            if (p == 16)
            {
                x = 351; y = 423; p = 6;

            }

            else if (p == 46)
            {
                x = 280; y = 340; p = 25;


            }

            else if (p == 49)
            {
                x = 606; y = 381; p = 11;


            }

            else if (p == 62)
            {
                x = 75; y = 376; p = 19;


            }

            else if (p == 64)
            {
                x = 11; y = 200; p = 60;


            }

            else if (p == 74)
            {
                x = 479; y = 196; p = 53;


            }

            else if (p == 89)
            {
                x = 472; y = 144; p = 68;


            }

            else if (p == 92)
            {
                x = 472; y = 60; p = 88;
                pxb.Location = new Point(x, y);

            }

            else if (p == 95)
            {
                x = 347; y = 105; p = 75;


            }

            else if (p == 99)
            {
                x = 11; y = 107; p = 80;


            }
            pxb.Location = new Point(x, y);
            return p;
        }
        public static int Ladder(ref int x, ref int y, int p, PictureBox pxb)
        {
            if (p == 2)
            {
                x = 145; y = 287; p = 38;

            }

            else if (p == 7)
            {
                x = 410; y = 372; p = 14;


            }

            else if (p == 8)
            {
                x = 614; y = 286; p = 31;


            }

            else if (p == 15)
            {
                x = 338; y = 340; p = 26;


            }

            else if (p == 21)
            {
                x = 79; y = 240; p = 42;


            }

            else if (p == 28)
            {
                x = 206; y = 60; p = 84;


            }

            else if (p == 36)
            {
                x = 210; y = 239; p = 44;


            }

            else if (p == 51)
            {
                x = 409; y = 155; p = 67;


            }

            else if (p == 71)
            {
                x = 615; y = 10; p = 91;


            }

            else if (p == 78)
            {
                x = 148; y = 10; p = 98;


            }

            else if (p == 87)
            {
                x = 424; y = 10; p = 94;


            }
            pxb.Location = new Point(x, y);
            return p;
        }

    }
}
