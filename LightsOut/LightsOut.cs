using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace LightsOut
{
    public partial class LightsOut : Form
    {
        private readonly Boolean[,] grid;
        private readonly int gridSizeX;
        private readonly int gridSizeY;
        private readonly Color[,] bgColors;

        public LightsOut(int gridSizeX, int gridSizeY)
        {
            grid = new Boolean[gridSizeX + 2, gridSizeY + 2];
            this.gridSizeX = gridSizeX;
            this.gridSizeY = gridSizeY;
            bgColors = new Color[gridSizeX, gridSizeY];

            InitializeComponent();
            InitTable(gridSizeX, gridSizeY);
            InitBackgroundColor(gridSizeX, gridSizeY);
        }

        private void InitTable(int gridSizeX, int gridSizeY)
        {
            tablePanel.ColumnCount = gridSizeX;
            tablePanel.RowCount = gridSizeY;

            for (int i = 0; i < gridSizeX; i++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / gridSizeX));
            }
            for (int j = 0; j < gridSizeY; j++)
            {
                tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / gridSizeY));
            }
        }

        private void InitBackgroundColor(int gridSizeX, int gridSizeY)
        {
            for (int i = 0; i < gridSizeX; i++)
            {
                for (int j = 0; j < gridSizeY; j++)
                {
                    this.bgColors[i, j] = SystemColors.Control;
                }
            }
        }

        private Tuple<int, int> GetRowColIndex(TableLayoutPanel table, Point point)
        {
            if (point.X > table.Width || point.Y > table.Height)
                return null;

            int w = table.Width;
            int h = table.Height;
            int[] widths = table.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = table.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return Tuple.Create(col + 1, row + 1);
        }

        private void UpdateGrid(int x, int y)
        {            
            grid[x, y] = !grid[x, y];
            grid[x + 1, y] = !grid[x + 1, y];
            grid[x - 1, y] = !grid[x - 1, y];
            grid[x, y + 1] = !grid[x, y + 1];
            grid[x, y - 1] = !grid[x, y - 1];

            for (int i = 0; i < gridSizeX; i++)
            {
                for (int j = 0; j < gridSizeY; j++)
                {
                    if(grid[i+1, j+1])
                    {
                        bgColors[i, j] = Color.Green;
                    } 
                    else
                    {
                        bgColors[i, j] = Color.Gray;
                    }
                }
            }
            tablePanel.Refresh();
        }

        private Boolean WinConCheck()
        {
            Boolean isGameWon = true;
            for (int i = 1; i < gridSizeX + 1; i++)
            {
                for (int j = 1; j < gridSizeY + 1; j++)
                {
                    if(!grid[i, j])
                    {
                        isGameWon = false;
                    }
                }
            }
            return isGameWon;
        }

        private void TablePanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using var b = new SolidBrush(bgColors[e.Column, e.Row]);
            e.Graphics.FillRectangle(b, e.CellBounds);

        }

        private void TablePanel_Click(object sender, EventArgs e)
        {
            (int x, int y) = GetRowColIndex(
                tablePanel,
                tablePanel.PointToClient(Cursor.Position));
            UpdateGrid(x, y);
            if (WinConCheck())
            {
                MessageBox.Show("You won!");
                Close();
            }
        }
    }
}
