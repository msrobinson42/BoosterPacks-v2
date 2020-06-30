using BoosterPackClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoosterPacks
{
    public partial class Form1 : Form
    {
        IBoosterPackFactory _boosterPackFactory;
        public Form1(IBoosterPackFactory boosterPackFactory)
        {
            _boosterPackFactory = boosterPackFactory;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var booster = _boosterPackFactory.Create();

            MessageBox.Show(booster.ToString());
        }
    }
}
