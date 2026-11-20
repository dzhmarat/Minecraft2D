namespace Minecraft2D
{
    public partial class Form1 : Form
    {
        Tile[,] map = new Tile[200, 150];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < 150; j++)
                {
                    map[i, j] = new Tile("void", i, j);
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (CreateMenu.Visible)
            {
                CreateMenu.Visible = false;
            }
            else
            {
                CreateMenu.Visible = true;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < 150; j++)
                {
                    Brush brush;
                    if (map[i, j].Block == "void")
                    {
                        brush = Brushes.Gray;
                    }
                    else if (map[i, j].Block == "water")
                    {
                        brush = Brushes.Blue;
                    }
                    else
                    {
                        brush = Brushes.Brown;
                    }
                    g.FillRectangle(brush, i * 3, j * 3, 3, 3);
                }
            }
        }

        private void TrueCreate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TextX.Text);
            int y = int.Parse(TextY.Text);
            int length = int.Parse(TextLength.Text);
            int height = int.Parse(TextHeight.Text);
            if (x < 0 || y < 0 || x >= 200 || y >= 150) return;
            if (x + length > 200)
            {
                length = 200 - x;
            }
            if (y + height > 150)
            {
                height = 150 - y;
            }
            string type;
            if (TypeGrass.Checked)
            {
                type = "grass";
                for (int i = x; i < x + length; i++)
                {
                    for (int j = y; j < y + height; j++)
                    {
                        if (map[i, j].Block == "water")
                        {
                            map[i, j].Block = type;
                        }
                    }
                }
            }
            else
            {
                type = "water";
                for (int i = x; i < x + length; i++)
                {
                    for(int j = y; j < y + height; j++)
                    {
                        map[i, j].Block = type;
                    }
                }
            }
            //map[x, y].Block = type;
            Invalidate();
        }
    }
}
