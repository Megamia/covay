using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GO_Game
{
    public partial class Form2 : Form
    {
        private noticeWinner winner;
        private int NextCurrent = 0;
        private int currentPlayer = 1;
        private Form1 form1;
        private int moved;
        private int[,] chessMoved = new int[14, 14];
        private int[,] chessMovedTemp = new int[14, 14];
        private PictureBox[,] btn = new PictureBox[14, 14];
        private int[] Chainremoved = new int[288];
        private int[,] Khi = new int[14, 14];
        /*private int Khi*/
        public Form2()
        {
            InitializeComponent();
            drawChessBoard();
            for (int i = 0; i < 14; i += 13)
            {
                for (int j = 0; j < 14; j += 13)
                {
                    chessMoved[i, j] = 2;
                }
            }
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    chessMoved[i, j] = 0;
                }
            }

        }

        public void defaultChessMove()
        {
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    btn[i, j].Image = null;
                }
            }
        }
        public void SwitchTurn()
        {
            for (int i = 0; i < 14; i += 13)
            {
                for (int j = 0; j < 14; j += 13)
                {
                    chessMoved[i, j] = currentPlayer;
                }
            }
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }

        public bool MakeMove(int row, int col)
        {
            NextCurrent = 0;
            if (chessMoved[row, col] == 0)
            {
                chessMoved[row, col] = currentPlayer;
                SwitchTurn();
                if (currentPlayer == 2)
                {
                    pictureBoxCurrentTurn.Image = Properties.Resources.blackrock;
                    LabelCurrentTurn.Text = label2.Text;
                }
                else
                {
                    pictureBoxCurrentTurn.Image = Properties.Resources.whiterock;
                    LabelCurrentTurn.Text = label3.Text;
                }
                return true;
            }
            return false;
        }

        public int GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public int GetNotCurrentPlayer()
        {
            return (currentPlayer == 1) ? 2 : 1;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void drawChessBoard()
        {
            PictureBox btnold = new PictureBox() { Width = 0, Location = new Point(28, 31) };
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j <= 13; j++)
                {

                    btn[i, j] = new PictureBox()
                    {
                        Width = 30,
                        Height = 30,
                        Location = new Point(btnold.Location.X + btnold.Width + 4, btnold.Location.Y),
                    };
                    btn[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    panel1.Controls.Add(btn[i, j]);
                    btnold = btn[i, j];
                    btn[i, j].Tag = new Point(i, j);
                    btn[i, j].Click += PictureBox_Click;
                    /*btn.MouseHover += PictureBox_Hover;
                    btn.MouseMove += PictureBox_Move;*/
                    /*if (chessMoved[i, j] == 0)
                    {
                        btn[i, j].Image = Properties.Resources.chosewhite_4x;
                    }
                    else if (chessMoved[i, j] == 1)
                    {
                        btn[i, j].Image = Properties.Resources.Asset_2_4x;
                    }
                    else if (chessMoved[i, j] == 2)
                    {
                        btn[i, j].Image = Properties.Resources.Asset_3_4x;
                    }*/
                }
                btnold.Location = new Point(28, btnold.Location.Y + btnold.Width + 3);
                btnold.Width = 0;
                btnold.Height = 0;
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Point position = (Point)((PictureBox)sender).Tag;
            /*MessageBox.Show($"Clicked on Row: {position.X}, Column: {position.Y}");*/
            if (MakeMove(position.X, position.Y) == true) {
                if (GetCurrentPlayer() == 1)
                {
                    pictureBox.Image = Properties.Resources.blackrock;
                    chessMoved[position.X, position.Y] = 1;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.whiterock;
                    chessMoved[position.X, position.Y] = 2;
                }
                xuLyAnQuan();
            }
        }

        public void xuLyAnQuan()
        {

            FindShape();
            HaiKhi();
            BaKhi();
        }

        private void HaiKhi()
        {

            if (GetCurrentPlayer() == chessMoved[1, 1] && (chessMoved[1, 2] == GetNotCurrentPlayer() && chessMoved[2, 1] == GetNotCurrentPlayer()))
            {
                btn[1, 1].Image = null;
            }
            if (GetCurrentPlayer() == chessMoved[1, 12] && (chessMoved[1, 11] == GetNotCurrentPlayer() && chessMoved[2, 12] == GetNotCurrentPlayer()))
            {
                btn[1, 12].Image = null;
            }
            if (GetCurrentPlayer() == chessMoved[12, 1] && (chessMoved[11, 1] == GetNotCurrentPlayer() && chessMoved[12, 2] == GetNotCurrentPlayer()))
            {
                btn[12, 1].Image = null;
            }
            if (GetCurrentPlayer() == chessMoved[12, 12] && (chessMoved[12, 11] == GetNotCurrentPlayer() && chessMoved[11, 12] == GetNotCurrentPlayer()))
            {
                btn[12, 12].Image = null;
            }
        }

        private void BaKhi()
        {
            for (int i = 2; i < 12; i++)
            {
                for (int j = 2; j < 12; j++)
                {
                    if (GetCurrentPlayer() == chessMoved[1, j] && (chessMoved[i, j + 1] == GetNotCurrentPlayer() && chessMoved[i, j - 1] == GetNotCurrentPlayer() && chessMoved[i + 1, j] == GetNotCurrentPlayer()))
                    {
                        btn[i, j].Image = null;
                    }
                    if (GetCurrentPlayer() == chessMoved[i, 1] && (chessMoved[i + 1, j] == GetNotCurrentPlayer() && chessMoved[i - 1, j] == GetNotCurrentPlayer() && chessMoved[i, j + 1] == GetNotCurrentPlayer()))
                    {
                        btn[i, j].Image = null;
                    }
                    if (GetCurrentPlayer() == chessMoved[12, j] && (chessMoved[i - 1, j] == GetNotCurrentPlayer() && chessMoved[i, j - 1] == GetNotCurrentPlayer() && chessMoved[i, j + 1] == GetNotCurrentPlayer()))
                    {
                        btn[i, j].Image = null;
                    }
                    if (GetCurrentPlayer() == chessMoved[i, 12] && (chessMoved[i, j - 1] == GetNotCurrentPlayer() && chessMoved[i - 1, j] == GetNotCurrentPlayer() && chessMoved[i + 1, j] == GetNotCurrentPlayer()))
                    {
                        btn[i, j].Image = null;
                    }
                }
            }
        }

        private void FindShape()
        {
            List<List<Tuple<int, int>>> clusters = FindClustersOfTwos(chessMoved);

            foreach (var cluster in clusters)
            {
                List<Tuple<int, int>> libertiesCoordinates = GetLibertiesCoordinates(chessMoved, cluster);
                int count = libertiesCoordinates.Count;
                foreach (var position in libertiesCoordinates)
                {
                    if (GetCurrentPlayer() == chessMoved[position.Item1, position.Item2])
                    {
                        count--;
                    }
                }
                if (count == 0)
                {
                    foreach (var position in cluster)
                    {
                        chessMoved[position.Item1, position.Item2] = 0;
                        btn[position.Item1, position.Item2].Image = null;
                    }
                }
            }
        }

        static List<Tuple<int, int>> GetLibertiesCoordinates(int[,] chessMoved, List<Tuple<int, int>> cluster)
        {
            List<Tuple<int, int>> libertiesCoordinates = new List<Tuple<int, int>>();

            foreach (var position in cluster)
            {
                int row = position.Item1;
                int col = position.Item2;

                CheckAndAddLiberty(chessMoved, libertiesCoordinates, row - 1, col);
                CheckAndAddLiberty(chessMoved, libertiesCoordinates, row + 1, col);
                CheckAndAddLiberty(chessMoved, libertiesCoordinates, row, col - 1);
                CheckAndAddLiberty(chessMoved, libertiesCoordinates, row, col + 1);
            }

            return libertiesCoordinates;
        }

        static void CheckAndAddLiberty(int[,] chessMoved, List<Tuple<int, int>> libertiesCoordinates, int row, int col)
        {
            if (IsValidPosition(chessMoved, row, col) && chessMoved[row, col] == 0)
            {
                libertiesCoordinates.Add(Tuple.Create(row, col));
            }
        }

        static bool IsValidPosition(int[,] chessMoved, int row, int col)
        {
            return row >= 0 && row < chessMoved.GetLength(0) && col >= 0 && col < chessMoved.GetLength(1);
        }

        private List<List<Tuple<int, int>>> FindClustersOfTwos(int[,] chessMoved)
        {
            int rows = chessMoved.GetLength(0);
            int cols = chessMoved.GetLength(1);

            List<List<Tuple<int, int>>> clusters = new List<List<Tuple<int, int>>>();
            bool[,] visited = new bool[rows, cols];

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (chessMoved[i, j] == GetNotCurrentPlayer() && !visited[i, j])
                    {
                        List<Tuple<int, int>> cluster = new List<Tuple<int, int>>();
                        ExploreCluster(chessMoved, visited, i, j, cluster);
                        clusters.Add(cluster);
                    }
                }
            }

            return clusters;
        }

        static void ExploreCluster(int[,] chessMoved, bool[,] visited, int row, int col, List<Tuple<int, int>> cluster)
        {
            int rows = chessMoved.GetLength(0);
            int cols = chessMoved.GetLength(1);

            if (row < 0 || row >= rows || col < 0 || col >= cols || visited[row, col] || chessMoved[row, col] != 2)
                return;

            visited[row, col] = true;
            cluster.Add(Tuple.Create(row, col));

            // Duyệt qua tất cả các ô lân cận
            ExploreCluster(chessMoved, visited, row - 1, col, cluster);
            ExploreCluster(chessMoved, visited, row + 1, col, cluster);
            ExploreCluster(chessMoved, visited, row, col - 1, cluster);
            ExploreCluster(chessMoved, visited, row, col + 1, cluster);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public enum GameState
        {
            InProgress,
            Player1Wins,
            Player2Wins,
            Draw
        }

        public GameState CheckWinCondition()
        {
            if (CheckPlayerWin(1, chessMoved))
            {
                return GameState.Player1Wins;
            }

            if (CheckPlayerWin(2, chessMoved))
            {
                return GameState.Player2Wins;
            }

            if (IsBoardFull(chessMoved))
            {
                return GameState.Draw;
            }

            return GameState.InProgress;
        }

        private static bool CheckPlayerWin(int player, int[,] board)
        {
            for (int row = 0; row < 14; row++)
            {
                bool win = true;
                for (int col = 0; col < 14; col++)
                {
                    if (board[row, col] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win)
                {
                    return true;
                }
            }

            for (int col = 0; col < 14; col++)
            {
                bool win = true;
                for (int row = 0; row < 14; row++)
                {
                    if (board[row, col] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win)
                {
                    return true;
                }
            }
            bool diagonalWin1 = true;
            bool diagonalWin2 = true;

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i, i] != player)
                {
                    diagonalWin1 = false;
                }

                if (board[i, board.Length - 1 - i] != player)
                {
                    diagonalWin2 = false;
                }
            }

            return diagonalWin1 || diagonalWin2;
        }

        private static bool IsBoardFull(int[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (board[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i += 13)
            {
                for (int j = 0; j < 14; j += 13)
                {
                    chessMoved[i, j] = 2;
                }
            }
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    chessMoved[i, j] = 0;
                }
            }
            defaultChessMove();
            currentPlayer = 1;
            pictureBoxCurrentTurn.Image = Properties.Resources.whiterock;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_volumn_Click(object sender, EventArgs e)
        {
            NextCurrent++;
            SwitchTurn();
            if (currentPlayer == 2)
            {
                pictureBoxCurrentTurn.Image = Properties.Resources.blackrock;
                LabelCurrentTurn.Text = label2.Text;
            }
            else
            {
                pictureBoxCurrentTurn.Image = Properties.Resources.whiterock;
                LabelCurrentTurn.Text = label3.Text;
            }
            if(NextCurrent == 2)
            {
                checkWin();
            }
        }

        public void checkWin()
        {

            int den = 0;
            int trang = 0;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    if (chessMoved[i, j] == 1)
                    {
                        trang++;
                    }
                    else if (chessMoved[i, j] == 2)
                    {
                        den++;
                    }
                }
            }
            if (trang > den)
            {
                NoticeWinner(label2, this);
            }
            else if (trang < den)
            {
                NoticeWinner(label3, this);
            }
            else if (trang == den)
            {
                Label tie = new Label();
                tie.Text = "It's Tie";
                NoticeWinner(tie, this);
            }
        }

        public void NoticeWinner(Label win, Form2 f2)
        {
            this.Hide();
            winner = new noticeWinner();
            winner.Show();
            winner.SetForm1Reference(win, this);
        }

        private void Go_Home_Click(object sender, EventArgs e)
        {
            form1.ShowForm1();
            this.Close();
        }

        public void SetForm1Reference(Form1 f1)
        {
            form1 = f1;
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {

        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {

        }
    }
}