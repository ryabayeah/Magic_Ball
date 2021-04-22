using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        bool yes_no = false;

        Dictionary<int, string> answers = new Dictionary<int, string>
        {
            {0, "It is certain"},
            {1, "It is decidedly so"},
            {2, "Without a doubt "},
            {3, "Yes — definitely"},
            {4, "You may rely on it"},

            {5, "As I see it, yes"},
            {6, "Most likely"},
            {7, "Outlook good"},
            {8, "Signs point to yes"},
            {9, "Yes"},

            {10, "Reply hazy, try again"},
            {11, "Ask again later"},
            {12, "Better not tell you now"},
            {13, "Cannot predict now"},
            {14, "Concentrate and ask again"},

            {15, "Don’t count on it"},
            {16, "My reply is no"},
            {17, "My sources say no"},
            {18, "Outlook not so good"},
            {19, "Very doubtful"}
        };
        Dictionary<int, double> menya_zastavil_nikita = new Dictionary<int, double>
        {
            {0,  0.1},
            {1,  0.016},
            {2,  0.016},
            {3,  0.05},
            {4,  0.016},

            {5,  0.016},
            {6,  0.1 },
            {7,  0.016},
            {8,  0.016},
            {9,  0.1},

            {10, 0.1 },
            {11, 0.024},
            {12, 0.1},
            {13, 0.016},
            {14, 0.016},

            {15, 0.1 },
            {16, 0.016},
            {17, 0.15},
            {18, 0.016},
            {19, 0.016}
        };

        Dictionary<int, Color> colors = new Dictionary<int, Color>
        {
            {0,  Color.Blue},
            {1,  Color.Blue},
            {2,  Color.Blue},
            {3,  Color.Blue},
            {4,  Color.Blue},
            {5,  Color.Green},
            {6,  Color.Green},
            {7,  Color.Green },
            {8,  Color.Green },
            {9,  Color.Green   },
            {10, Color.Yellow },
            {11, Color.Yellow },
            {12, Color.Yellow },
            {13, Color.Yellow },
            {14, Color.Yellow },
            {15, Color.Red },
            {16, Color.Red  },
            {17, Color.Red  },
            {18, Color.Red },
            {19, Color.Red }
        };
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Switch to: Yes-No";
            label1.Visible = numericYes.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(yes_no);
            if (question1.Text != "")
            {
                if (yes_no)
                {
                    Random rand = new Random();
                    yes_no = true;
                    var e_boi = rand.NextDouble() < (double)numericYes.Value;
                    random1.Text = e_boi ? "Yes" : "No";
                    random1.BackColor = e_boi ? Color.Green : Color.Red;
                }
                else
                {
                    Random rand = new Random();

                    double A = rand.NextDouble();

                        for (int k = 0; k <= 19; k++)
                        {
                            A -= menya_zastavil_nikita[k];
                            if (A <= 0) { random1.Text = answers[k]; random1.BackColor = colors[k]; break; }
                        };
                };
            }
            else { random1.Text = "Where is the question??"; };

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Switch to: Yes-No")
            {
                yes_no = true;
                random1.Text = "";
                random1.BackColor = Color.White;
                label1.Visible = numericYes.Visible = true;
                button1.Text = "Switch to: Magic Ball";
            }
            else
            {
                label1.Visible = numericYes.Visible = false;
                yes_no = false;
                random1.BackColor = Color.White;
                random1.Text = "";
                button1.Text = "Switch to: Yes-No";
            };
        }
    }
}
