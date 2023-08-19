namespace descuentoEnCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorCompra = int.Parse(textBox1.Text);
            double desc = 0;
            double valorFinal = 0;

            if (valorCompra > 100)
            {
                desc = valorCompra * 0.05;

            }
            else if (valorCompra >= 150)
            {
                desc = valorCompra * 0.1;

            }
            else if (valorCompra >= 200)
            {
                desc = valorCompra * 0.15;
            }

            valorFinal = valorCompra - desc;

            label3.Text = "Descuento $" + desc.ToString();
            label4.Text = "Valor Total $" + valorFinal.ToString();

            textBox1.ResetText();
        }
    }
}