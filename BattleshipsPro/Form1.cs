using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipsPro
{
    public partial class Form1 : Form
    {
        public int[,] board1 = new int[10, 10];
        public int[,] board2 = new int[10, 10];

        public bool gameStarted;
        public bool player1turn;



        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBoards();
            VisualizeBoards();
        }

        private void StartGame()
        {
            board1 = new int[10, 10];
            board2 = new int[10, 10];

            LoadBoards();
            VisualizeBoards();

            StartButton.Visible = false;
            player1turn = true;
            gameStarted = true;

            VisualBoard2.Enabled = true;
            
            turnLabel.Visible = true;
            turnLabel.Text = "Player1 Turn";
        }

        private void LoadBoards()
        {
            for (int size = 1; size <= 4; size++) 
            {
                int quantity = size == 1 ? 4 : size == 2 ? 3 : size == 3 ? 2 : 1; 

                for (int i = 0; i < quantity; i++) 
                {
                    PlaceShip(board1, rand, size);
                    PlaceShip(board2, rand, size);
                }
            }
        }

        private void VisualizeBoards()
        {
            foreach (DataGridViewRow row in VisualBoard1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; 
                    cell.Value = null;                
                }
            }

            foreach (DataGridViewRow row2 in VisualBoard2.Rows)
            {
                foreach (DataGridViewCell cell2 in row2.Cells)
                {
                    cell2.Style.BackColor = Color.White;
                    cell2.Value = null;
                }
            }

   
            InitializeGridView(VisualBoard1);
            InitializeGridView(VisualBoard2);

            VisualBoard1.CellPainting += (s, e) => DrawConnectedBorder(e, board1);
            VisualBoard1.CellPainting += (s, e) => DrawShootedShips(e, board1);
            VisualBoard1.Refresh();

            VisualBoard2.CellPainting += (s, e) => DrawConnectedBorder(e, board2);
            VisualBoard2.CellPainting += (s, e) => DrawShootedShips(e, board2);
            VisualBoard2.Refresh();

   
            VisualBoard1.GridColor = Color.DeepSkyBlue;

            VisualBoard2.GridColor = Color.DeepSkyBlue;


            turnLabel.Visible = false;

        }

        private void DrawShootedShips(DataGridViewCellPaintingEventArgs e, int[,] board)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;

            using (Brush blueBrush = new SolidBrush(Color.White))
            {
                Rectangle cellRect = new Rectangle(
                    e.CellBounds.Left + 1,
                    e.CellBounds.Top + 1,
                    e.CellBounds.Width - 2,
                    e.CellBounds.Height - 2
                );
                e.Graphics.FillRectangle(blueBrush, cellRect);
            }

            if (board[x, y] == -2)
            {
                Pen redPen = new Pen(Color.Blue, 2);
                e.Graphics.DrawLine(redPen, e.CellBounds.Left + 5, e.CellBounds.Top + 5, e.CellBounds.Right - 5, e.CellBounds.Bottom - 5);
                e.Graphics.DrawLine(redPen, e.CellBounds.Left + 5, e.CellBounds.Bottom - 5, e.CellBounds.Right - 5, e.CellBounds.Top + 5);
            }

        }

        private void DrawConnectedBorder(DataGridViewCellPaintingEventArgs e, int[,] board)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;


            if (x < 0 || y < 0 || board[x, y] != -2)
                return;

            using (Brush blueBrush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(blueBrush, e.CellBounds);
            }

            if (x < 0 || y < 0 || board[x, y] != -2)
                return;

            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.CellBounds);

            using (Brush blueBrush = new SolidBrush(Color.White))
            {
                Rectangle cellRect = new Rectangle(
                    e.CellBounds.Left + 1,
                    e.CellBounds.Top + 1,
                    e.CellBounds.Width - 2,
                    e.CellBounds.Height - 2
                );
                e.Graphics.FillRectangle(blueBrush, cellRect);
            }

            Pen bluePen = new Pen(Color.White, 2);


            if (y > 0 && board[x, y - 1] == -2)
            {
                e.Graphics.DrawLine(bluePen, e.CellBounds.Left + 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Top);
            }


            if (y < 9 && board[x, y + 1] == -2)
            {
                e.Graphics.DrawLine(bluePen, e.CellBounds.Left + 1, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
            }

     
            if (x > 0 && board[x - 1, y] == -2)
            {
                e.Graphics.DrawLine(bluePen, e.CellBounds.Left, e.CellBounds.Top + 1, e.CellBounds.Left, e.CellBounds.Bottom - 1);
            }

           
            if (x < 9 && board[x + 1, y] == -2)
            {
                e.Graphics.DrawLine(bluePen, e.CellBounds.Right - 1, e.CellBounds.Top + 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
            }


         
            e.Handled = true;
        }

        private void InitializeGridView(DataGridView gridView)
        {
            gridView.ColumnCount = 10;
            gridView.RowCount = 10;

            foreach (DataGridViewColumn col in gridView.Columns)
            {
                col.Width = 50;
            }

            foreach (DataGridViewRow row in gridView.Rows)
            {
                row.Height = 50;
            }
            gridView.ReadOnly = true;
            gridView.AllowUserToResizeRows = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToOrderColumns = false;
            gridView.Enabled = false;
            gridView.RowHeadersVisible = false;
            gridView.ColumnHeadersVisible = false;
            gridView.ScrollBars = ScrollBars.None;


            gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridView.ClearSelection();  

            gridView.DefaultCellStyle.SelectionBackColor = gridView.DefaultCellStyle.BackColor;
            gridView.DefaultCellStyle.SelectionForeColor = gridView.DefaultCellStyle.ForeColor;


        }

        static void PlaceShip(int[,] board, Random rand, int sizeOfShip)
        {
            bool placed = false;

            while (!placed)
            {
                int x = rand.Next(0, 10);
                int y = rand.Next(0, 10);
                bool vert = rand.Next(0, 2) == 0;

                if (Placeable(board, x, y, sizeOfShip, vert))
                {
                    for (int i = 0; i < sizeOfShip; i++)
                    {
                        if (vert)
                            board[x + i, y] = 1;
                        else
                            board[x, y + i] = 1;
                    }
                    placed = true;
                }
            }
        }

        static bool Placeable(int[,] board, int x, int y, int sizeOfShip, bool vert)
        {
            for (int i = 0; i < sizeOfShip; i++)
            {
                int nx = vert ? x + i : x;
                int ny = vert ? y : y + i;

                if (nx < 0 || nx >= 10 || ny < 0 || ny >= 10)
                    return false;

                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        int sx = nx + dx;
                        int sy = ny + dy;

                        if (sx >= 0 && sx < 10 && sy >= 0 && sy < 10 && board[sx, sy] == 1)
                            return false;
                    }
                }
            }
            return true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void VisualBoard1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gameStarted && !player1turn)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;

                if (columnIndex >= 0 && rowIndex >= 0)
                {

                    VisualBoard1.ClearSelection();


                    if (board1[columnIndex, rowIndex] == 1)
                    {

                        board1[columnIndex, rowIndex] = -2;

                        bool isSingular = true;
                      
                        for(int dx = -1;dx <= 1;dx++)
                        {
                            for(int dy = -1;dy <= 1; dy++)
                            {
                                if(columnIndex + dx > 9 || rowIndex + dy > 9 || columnIndex + dx < 0 || rowIndex + dy < 0)
                                {
                                    continue;
                                }
                                if (board1[columnIndex + dx, rowIndex + dy] == 1 || board1[columnIndex + dx, rowIndex + dy] == -2)
                                {
                                    isSingular = false; break;
                                }
                            }
                        }

                        if (isSingular)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                for (int dy = -1; dy <= 1; dy++)
                                {
                                    int newX = columnIndex + dx;
                                    int newY = rowIndex + dy;

                                    if (newX >= 0 && newX < 10 && newY >= 0 && newY < 10) 
                                    {
                                        VisualBoard1.Rows[newY].Cells[newX].Style.BackColor = Color.LightGray;
                                        VisualBoard1.Rows[newY].Cells[newX].Value = "•";
                                        board1[newX, newY] = -1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            int[,] directions = { { 1, 1 }, { 1, -1 }, { -1, -1 }, { -1, 1 } };

                            for (int i = 0; i < directions.GetLength(0); i++)
                            {
                                int newX = columnIndex + directions[i, 0];
                                int newY = rowIndex + directions[i, 1];

                                if (newX >= 0 && newX < 10 && newY >= 0 && newY < 10) 
                                {
                                    VisualBoard1.Rows[newY].Cells[newX].Style.BackColor = Color.LightGray;
                                    VisualBoard1.Rows[newY].Cells[newX].Value = "•";
                                    board1[newX, newY] = -1;
                                }
                            }
                        }
                    }
                    else if (board1[columnIndex, rowIndex] == 0)
                    {

                        VisualBoard1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.LightGray;
                        VisualBoard1.Rows[rowIndex].Cells[columnIndex].Value = "•";

                        VisualBoard1.Enabled = false;
                        VisualBoard2.Enabled = true;

                        player1turn = true;
                        turnLabel.Text = "Player1 Turn";

                        board1[columnIndex, rowIndex] = -1;
                    }


                }

                for (int i = 0; i < board1.GetLength(0); i++)
                {
                    for(int j = 0; j < board1.GetLength(1); j++) 
                    {

                        if (board1[i,j] == 1)
                        {
                            return;
                        }
                    }
                        
                }

                turnLabel.Text = "Player2 Won!";
                VisualBoard1.Enabled = false;
                VisualBoard2.Enabled = false;
                gameStarted = false;
                StartButton.Visible = true;

            
            }
        }

        private void VisualBoard2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gameStarted && player1turn)
            {
                int columnIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;

                if (columnIndex >= 0 && rowIndex >= 0)
                {

                    VisualBoard2.ClearSelection();


                    if (board2[columnIndex, rowIndex] == 1)
                    {
                        board2[columnIndex, rowIndex] = -2;

                        bool isSingular = true;

                        for (int dx = -1; dx <= 1; dx++)
                        {
                            for (int dy = -1; dy <= 1; dy++)
                            {
                                if (columnIndex + dx > 9 || rowIndex + dy > 9 || columnIndex + dx < 0 || rowIndex + dy < 0)
                                {
                                    continue;
                                }
                                if (board2[columnIndex + dx, rowIndex + dy] == 1 || board2[columnIndex + dx, rowIndex + dy] == -2)
                                {
                                    isSingular = false; break;
                                }
                            }
                        }

                        if (isSingular)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                for (int dy = -1; dy <= 1; dy++)
                                {
                                    int newX = columnIndex + dx;
                                    int newY = rowIndex + dy;

                                    if (newX >= 0 && newX < 10 && newY >= 0 && newY < 10) 
                                    {
                                        VisualBoard2.Rows[newY].Cells[newX].Style.BackColor = Color.LightGray;
                                        VisualBoard2.Rows[newY].Cells[newX].Value = "•";
                                        board2[newX, newY] = -1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            int[,] directions = { { 1, 1 }, { 1, -1 }, { -1, -1 }, { -1, 1 } };

                            for (int i = 0; i < directions.GetLength(0); i++)
                            {
                                int newX = columnIndex + directions[i, 0];
                                int newY = rowIndex + directions[i, 1];

                                if (newX >= 0 && newX < 10 && newY >= 0 && newY < 10)
                                {
                                    VisualBoard2.Rows[newY].Cells[newX].Style.BackColor = Color.LightGray;
                                    VisualBoard2.Rows[newY].Cells[newX].Value = "•";
                                    board2[newX, newY] = -1;
                                }
                            }
                        }
                    }
                    else if (board2[columnIndex, rowIndex] == 0)
                    {

                        VisualBoard2.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.LightGray;
                        VisualBoard2.Rows[rowIndex].Cells[columnIndex].Value = "•";

                        VisualBoard2.Enabled = false;
                        VisualBoard1.Enabled = true;

                        player1turn = false;
                        turnLabel.Text = "Player2 Turn";

                        board2[columnIndex, rowIndex] = -1;
                    }

                }

                for (int i = 0; i < board2.GetLength(0); i++)
                {
                    for (int j = 0; j < board2.GetLength(1); j++)
                    {

                        if (board2[i, j] == 1)
                        {
                            return;
                        }
                    }

                }

                turnLabel.Text = "Player1 Won!";
                VisualBoard1.Enabled = false;
                VisualBoard2.Enabled = false;
                gameStarted = false;
                StartButton.Visible = true;
            }
        }
    }
}
