namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Button[,] chessBoard;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateBoard();
        }

        private void CreateBoard()
        {
            int titleSize = 90;

            chessBoard = new Button[8, 8];
            Panel panel = new Panel();
            panel.Size = new Size(900, 900);
            panel.Location = new Point(0, 0);
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var button = new Button();
                    button.Size = new Size(titleSize,titleSize);
                    button.Location = new Point(titleSize * i, titleSize * j);

                    if ((i + j) % 2 == 0)
                    {
                        button.BackColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.Gold;
                    }
                    
                    button.Tag = new Point(i, j);
                    
                    chessBoard[i, j] = button;
                    panel.Controls.Add(button);
                }
            }
            Controls.Add(panel);
        }
    }
}