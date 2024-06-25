using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager;

namespace _2048WinFormsApp
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            LoadGameStatistics();
        }

        private void LoadGameStatistics()
        {
            dataGridView.DataSource = DatabaseHelper.ReadAllRecords();
        }
    }
}


