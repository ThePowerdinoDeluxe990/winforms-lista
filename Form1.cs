namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            String tiempo = DateTime.Now.ToString();
            this.tiempolbl.Text = "Log time:" + tiempo;

        }



        private void button1_Click(object sender, EventArgs e)
        {
             
            String nombre = textBox1.Text;

            if (nombre == "")
            {
               
                MessageBox.Show("Bad input!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = tabla.Rows.Add();
                tabla.Rows[n].Cells[0].Value = nombre;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
