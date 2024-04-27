namespace BotaoNao2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OI");

        }

        private void btnNao_MouseEnter(object sender, EventArgs e)
        {            
            int limiteX = this.Width; 
            int limiteY = this.Height;
            int coordenadaX = random.Next(0, limiteX - btnNao.Width);
            int coordenadaY = random.Next(0, limiteY - btnNao.Height);
            btnNao.Location = new Point(coordenadaX, coordenadaY);
        }
    }
}
