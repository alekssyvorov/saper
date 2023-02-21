using Saper.Game;
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

namespace Saper
{
    public partial class Form1 : Form
    {
        public const int mapSize = 8;
        public const int cellSize = 50;
        public static int[,] map = new int[mapSize, mapSize];

        public static Button[,] buttons = new Button[mapSize, mapSize];
        public Form1()
        {
            InitializeComponent();
            MapController.Init(this);
        }
    }
}
