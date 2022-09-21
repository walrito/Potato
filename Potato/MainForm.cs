using System;
using System.Drawing;
using System.Windows.Forms;

namespace Potato
{
    public partial class MainForm : Form
    {
        private static Random r;
        private bool firstRoll;
        private string firstRollLoc;
        private int destinyPoints;
        private int potatoPoints;
        private int orcPoints;
        private int orcRemovalCost;
        private PictureBox[] pbDestiny;
        private PictureBox[] pbPotatoes;
        private PictureBox[] pbOrcs;

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetAllValues();
        }

        private void ResetAllValues()
        {
            r = new Random();
            firstRoll = true;
            firstRollLoc = "";
            destinyPoints = 0;
            potatoPoints = 0;
            orcPoints = 0;
            orcRemovalCost = 1;
            pbDestiny = new PictureBox[10] { pbDestiny1, pbDestiny2, pbDestiny3, pbDestiny4, pbDestiny5, pbDestiny6, pbDestiny7, pbDestiny8, pbDestiny9, pbDestiny10 };
            pbPotatoes = new PictureBox[10] { pbPotatoes1, pbPotatoes2, pbPotatoes3, pbPotatoes4, pbPotatoes5, pbPotatoes6, pbPotatoes7, pbPotatoes8, pbPotatoes9, pbPotatoes10 };
            pbOrcs = new PictureBox[10] { pbOrcs1, pbOrcs2, pbOrcs3, pbOrcs4, pbOrcs5, pbOrcs6, pbOrcs7, pbOrcs8, pbOrcs9, pbOrcs10 };
            UpdateValues(0, 0, 0);
            lblFirstRoll.Text = "Roll the die to get started!";
            lblSecondRoll.Text = "";
            orcRemovalCost = 1;
            lblOrcRemovalCost.Text = $"Remove {orcRemovalCost} POTATO to remove 1 ORC";
            pbDie.Image = null;
        }

        private void btnRollDie_Click(object sender, EventArgs e)
        {
            if (firstRoll)
            {
                switch (RollDie())
                {
                    case 1:
                    case 2:
                        lblFirstRoll.Text = "In the garden...";
                        lblSecondRoll.Text = "Roll die to continue.";
                        firstRoll = false;
                        firstRollLoc = "Garden";
                        break;
                    case 3:
                    case 4:
                        lblFirstRoll.Text = "A knock at the door...";
                        lblSecondRoll.Text = "Roll die to continue.";
                        firstRollLoc = "Door";
                        firstRoll = false;
                        break;
                    case 5:
                    case 6:
                        lblFirstRoll.Text = "The world becomes a darker, more dangerous place.";
                        lblSecondRoll.Text = "From now on, removing ORC costs an additional POTATO (this is cumulative).";
                        orcRemovalCost += 1;
                        lblOrcRemovalCost.Text = $"Remove {orcRemovalCost} POTATO to remove 1 ORC";
                        firstRoll = true;
                        break;
                    default:
                        lblFirstRoll.Text = "";
                        firstRoll = true;
                        break;
                }
            }
            else
            {
                switch (firstRollLoc)
                {
                    case "Garden":
                        switch (RollDie())
                        {
                            case 1:
                                lblSecondRoll.Text = "You happily root about all day in your garden.\n\r(+1 POTATOES)";
                                UpdateValues(0, 1, 0);
                                break;
                            case 2:
                                lblSecondRoll.Text = "You narrowly avoid a visitor by hiding in a potato sack.\n\r(+1 DESTINY, +1 POTATOES)";
                                UpdateValues(1, 1, 0);
                                break;
                            case 3:
                                lblSecondRoll.Text = "A hooded stranger lingers outside your farm.\n\r(+1 DESTINY, +1 ORCS)";
                                UpdateValues(1, 0, 1);
                                break;
                            case 4:
                                lblSecondRoll.Text = "Your field is ravaged in the night by unseen enemies.\n\r(-1 POTATOES, +1 ORCS)";
                                UpdateValues(0, -1, 1);
                                break;
                            case 5:
                                lblSecondRoll.Text = "You trade potatoes for other delicioius foodstuffs.\n\r(-1 POTATOES)";
                                UpdateValues(0, -1, 0);
                                break;
                            case 6:
                                lblSecondRoll.Text = "You burrow into a bumper crop of potatoes. Do you cry with joy? Possibly.\n\r(+2 POTATOES)";
                                UpdateValues(0, 2, 0);
                                break;
                            default:
                                lblFirstRoll.Text = "";
                                break;
                        }
                        break;
                    case "Door":
                        switch (RollDie())
                        {
                            case 1:
                                lblSecondRoll.Text = "A distant cousin. They are after your potatoes. They may snitch on you.\n\r(+1 ORCS)";
                                UpdateValues(0, 0, 1);
                                break;
                            case 2:
                                lblSecondRoll.Text = "A dwarven stranger. You refuse them entry. Ghastly creatures.\n\r(+1 DESTINY)";
                                UpdateValues(1, 0, 0);
                                break;
                            case 3:
                                lblSecondRoll.Text = "A wizard strolls by. You pointedly draw the curtains.\n\r(+1 DESTINY, +1 ORCS)";
                                UpdateValues(1, 0, 1);
                                break;
                            case 4:
                                lblSecondRoll.Text = "There are rumours of war in the reaches. You eat some potatoes.\n\r(-1 POTATOES, +2 ORCS)";
                                UpdateValues(0, -1, 2);
                                break;
                            case 5:
                                lblSecondRoll.Text = "It's an elf. They are not serious people.\n\r(+1 DESTINY)";
                                UpdateValues(1, 0, 0);
                                break;
                            case 6:
                                lblSecondRoll.Text = "It's a sack of potatoes from a generous neighbour. You really must remember to pay them a visit one of these years.\n\r(+2 POTATOES)";
                                UpdateValues(0, 2, 0);
                                break;
                            default:
                                lblFirstRoll.Text = "";
                                break;
                        }
                        break;
                    default:
                        lblFirstRoll.Text = "";
                        lblSecondRoll.Text = "";
                        firstRoll = true;
                        break;
                }
                firstRoll = true;
            }
        }

        private int RollDie()
        {
            int dieRoll = r.Next(1, 7);
            switch (dieRoll)
            {
                case 1:
                    pbDie.Image = Properties.Resources.one;
                    break;
                case 2:
                    pbDie.Image = Properties.Resources.two;
                    break;
                case 3:
                    pbDie.Image = Properties.Resources.three;
                    break;
                case 4:
                    pbDie.Image = Properties.Resources.four;
                    break;
                case 5:
                    pbDie.Image = Properties.Resources.five;
                    break;
                case 6:
                    pbDie.Image = Properties.Resources.six;
                    break;
                default:
                    pbDie.Image = null;
                    break;
            }
            return dieRoll;
        }

        private void UpdateValues(int destiny, int potato, int orc)
        {
            destinyPoints += destiny;
            potatoPoints += potato;
            orcPoints += orc;

            if (destinyPoints < 0) { destinyPoints = 0; }
            if (potatoPoints < 0) { potatoPoints = 0; }
            if (orcPoints < 0) { orcPoints = 0; }

            foreach (PictureBox pb in pbDestiny)
            {
                pb.BackColor = int.Parse(pb.Name.Remove(0, 9)) <= destinyPoints ? SystemColors.ControlDark : SystemColors.Control;
            }

            foreach (PictureBox pb in pbPotatoes)
            {
                pb.BackColor = int.Parse(pb.Name.Remove(0, 10)) <= potatoPoints ? SystemColors.ControlDark : SystemColors.Control;
            }

            foreach (PictureBox pb in pbOrcs)
            {
                pb.BackColor = int.Parse(pb.Name.Remove(0, 6)) <= orcPoints ? SystemColors.ControlDark : SystemColors.Control;
            }

            CheckGameStatus();
        }

        private void CheckGameStatus()
        {
            if (potatoPoints >= 10)
            {
                MessageBox.Show("You have enough potatoes that you can go underground and not return to the surface until the danger is past. You nestle down into your burrow and enjoy your well earned rest.", "Game over");
                ResetAllValues();
            }
            else if (orcPoints >= 10)
            {
                MessageBox.Show("Orcs finally find your potato farm. Alas, orcs are not so interested in potatoes as they are in eating you, and you end up in a cookpot.", "Game over");
                ResetAllValues();
            }
            else if (destinyPoints >= 10)
            {
                MessageBox.Show("An interfering bard or wizard turns up at your doorstep with a quest, and you are whisked away against your will on an adventure.", "Game over");
                ResetAllValues();
            }
        }

        private void btnRemoveOrc_Click(object sender, EventArgs e)
        {
            if (orcPoints == 0)
            {
                MessageBox.Show("No ORCS to remove. You get to keep your POTATOES.");
            }
            else if (potatoPoints > orcRemovalCost)
            {
                UpdateValues(0, -orcRemovalCost, -1);
            }
            else
            {
                MessageBox.Show("Not enough POTATOES to remove ORCS.");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetAllValues();
        }
    }
}