using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKRPGCharGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verzia:1.0\nAplikáciu vytvoril: Timotej Jurášek \nRok 2016\nAplikácia bola súčasťou ročníkového projektu na FMFI UK");
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterCreationDialog ccd = new CharacterCreationDialog();
            ccd.Show();
        }
    }
}
