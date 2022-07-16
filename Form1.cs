namespace Triângulo
{
    public partial class TRIÂNGULOS : Form
    {
        public TRIÂNGULOS()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                double L1, L2, L3;
                L1 = Convert.ToDouble(txbLado1.Text);
                L2 = Convert.ToDouble(txbLado2.Text);
                L3 = Convert.ToDouble(txbLado3.Text);

                if((L1+L2>=L3) && (L1 + L3 >= L2) && (L2 + L3 >= L1))
                {
                    if(L1==L2 && L2==L3 && L3 == L1)
                    {
                        lblResult.Text = "Triângulo Equilátero";
                    }
                    else if(L1==L2 || L2==L3 || L3 == L1)
                    {
                        lblResult.Text = "Triângulo Isósceles";
                    }
                    else if(L1!=L2 && L2!=L3 && L3 != L1)
                    {
                        lblResult.Text = "Triângulo Escaleno";
                    }
                       
                }
                else
                {
                    lblResult.Text = "Não é um triângulo";
                }
            }
            catch
            {
                lblResult.Text = "Error!";
                MessageBox.Show("Insira valores numéricos válidos!", "Erro");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbLado1.Text = "";
            txbLado2.Text = "";
            txbLado3.Text = "";
           
        }
    }
}