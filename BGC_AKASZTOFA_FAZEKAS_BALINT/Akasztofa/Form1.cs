using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akasztofa
{
    public partial class Form1 : Form
    {

        string[] letters;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        Graphics g;
        Pen p;
        Pen w;
        Pen r;
        int badTries = 0;
        int lettersFound = 0;
        List<string> triedChar = new List<string>();
        string goTxt = "";
        static List<string> words = new List<string>()
        {
            "almafa", "farmer", "dió", "póló", "ing", "szotyi", "darálthús"
        };

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            letters = words[rnd.Next(words.Count)].ToCharArray().Select(c => c.ToString()).ToArray();
            g = mainCanvas.CreateGraphics();
            p = new Pen(Color.Black, 3);
            r = new Pen(Color.DarkGray, 7);
            w = new Pen(Color.DarkSlateGray, 16);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), 414, 46, 45, 45);
            for (int i = 0; i < letters.Count(); i++)
            {
                e.Graphics.DrawLine(p, 415 + (i * 40), 150, 440 + (i * 40), 150);
            }
        }

        private void tryChar(string tryChar)
        {
            if (!triedChar.Contains(tryChar))
            {
                triedChar.Add(tryChar);
                if(isBad(tryChar))
                    badTry(tryChar);
            }
        }

        private bool isBad(string tryChar)
        {
            bool isgoodtry = true;
            for (int i = 0; i < letters.Length; i++)
            {
                if(letters[i] == tryChar)
                {
                    Font letterFont = new Font("Segoe Print", 25);
                    StringFormat strDraw = new StringFormat();
                    g.DrawString(tryChar,
                        letterFont,
                        Brushes.Black,
                        417 + (i * 40), 105);
                    isgoodtry = false;
                    lettersFound++;
                }
            }
            if(lettersFound == letters.Count())
            {
                goTxt = "Success!";
                goWindow();
            }
            return isgoodtry;
        }

        private void badTry(string badChar)
        {
            badTries++;
            switch (badTries)
            {
                case 1:
                    paintWood1();
                    break;
                case 2:
                    paintWood2();
                    break;
                case 3:
                    paintWood3();
                    break;
                case 4:
                    paintWood4();
                    break;
                case 5:
                    paintRope();
                    break;
                case 6:
                    PaintHead();
                    break;
                case 7:
                    paintBody();
                    break;
                case 8:
                    paintHand1();
                    break;
                case 9:
                    paintHand2();
                    break;
                case 10:
                    paintLeg1();
                    break;
                case 11:
                    paintLeg2();
                    goTxt = "Game Over";
                    break;
                default:
                    break;
            };
                addLabel(badChar);
            if (badTries == 11)
            {
                goWindow();
            }
        }

        private void goWindow()
        {
            g.Dispose();
            Form2 gameoverForm = new Form2(goTxt);
            gameoverForm.ShowDialog();
        }

        private void addLabel(string badChar)
        {    
            Font letterFont = new Font("Segoe Print", 25);
            StringFormat strDraw = new StringFormat();
                g.DrawString(badChar,
                    letterFont,
                    Brushes.DarkSlateGray,
                    (410f + (50 * (int)(badTries % 5))), (250f + (30 * (int)(badTries / 5))));
                g.DrawLine(new Pen(Color.DarkSlateGray, 3), (415 + (50 * (int)(badTries % 5))), (275 + (30 * (int)(badTries / 5))), (435 + (50 * (int)(badTries % 5))), (290 + (30 * (int)(badTries / 5))));
        }

        

        private void PaintHead()
        {
            Brush b = new SolidBrush(Color.White);
            g.FillEllipse(b, 200, 150, 100, 100);
            g.DrawEllipse(p, 200, 150, 100, 100);
            g.DrawLine(p, 235, 170, 250, 185);
            g.DrawLine(p, 250, 170, 235, 185);
            g.DrawLine(p, 265, 180, 280, 195);
            g.DrawLine(p, 280, 180, 265, 195);
            g.DrawCurve(p, new Point[3] {
                new Point(225, 220),
                new Point(250,210),
                new Point(270,225)
            });
        }

        private void paintRope()
        {
            g.DrawLine(r, 250, 50, 250, 150);
        }

        private void paintWood1()
        {
            g.DrawLine(w, 42, 550, 350, 550);
        }

        private void paintWood2()
        {
            g.DrawLine(w, 50, 42, 50, 550);
        }

        private void paintWood3()
        {
            g.DrawLine(w, 50, 50, 255, 50);
        }

        private void paintWood4()
        {
            g.DrawLine(w, 50, 200, 200, 50);
        }

        private void paintBody()
        {
            g.DrawLine(p, 230, 244.2f, 230, 381);
        }

        private void paintHand1()
        {
            g.DrawLine(p, 230, 260, 190, 320);
        }

        private void paintHand2()
        {
            g.DrawLine(p, 230, 260, 270, 320);
        }

        private void paintLeg1()
        {
            g.DrawLine(p, 230, 380, 190, 460);
        }

        private void paintLeg2()
        {
            g.DrawLine(p, 230, 380, 270, 460);
        }

        private void screenSizeChanged(object sender, EventArgs e)
        {
            mainCanvas.Size = this.Size;
        }

        private void boxPressed(object sender, KeyEventArgs e)
        {
                tryChar(inBox.Text);
                inBox.Clear();
        }
    }
}
