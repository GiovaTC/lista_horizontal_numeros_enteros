namespace ListaHorizontalNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 35; i++)
            {
                //Puedes usar label, Button o TextBox. En este caso usamos label
                Label numeroLabel = new Label();
                numeroLabel.BackColor = Color.LightBlue;
                numeroLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                numeroLabel.Text = i.ToString();
                numeroLabel.Width = 40;
                numeroLabel.Height = 40;
                numeroLabel.TextAlign = ContentAlignment.MiddleCenter;
                numeroLabel.BorderStyle = BorderStyle.FixedSingle;
                numeroLabel.Margin = new Padding(5);

                flowLayoutPanelNumeros.Controls.Add(numeroLabel);
            }
        }
    }
}
