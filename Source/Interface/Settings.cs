﻿using System;
using System.Windows.Forms;

namespace AbsoluteZero {
    partial class Settings : Form {
        public Settings() {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
        }

        private void StartClick(Object sender, EventArgs e) {
            if ((whiteHuman.Checked || whiteComputer.Checked) && (blackHuman.Checked || blackComputer.Checked)) {
                IPlayer white = whiteHuman.Checked ? new Human() as IPlayer : new Zero();
                IPlayer black = blackHuman.Checked ? new Human() as IPlayer : new Zero();
                if (white is Human && black is Human)
                    Log.HideConsole();

                Restrictions.MoveTime = 3000;
                new Window(new Game(white, black)).Show();
                Visible = false;
                ShowInTaskbar = false;
            } else
                MessageBox.Show("Please select a player for each side. ");
        }
    }
}