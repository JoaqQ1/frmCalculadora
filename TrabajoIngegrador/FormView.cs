using Entidades;
using System.Text;
namespace TrabajoIngegrador
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(this.textBox1.Text, out double result1) && double.TryParse(this.textBox2.Text, out double result2)))
            {
                MessageBox.Show("Debe ingresar un numero en los 2 casilleros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                StringBuilder rst = new StringBuilder();
                Numeracion primerOperador = new Numeracion(result1, ESistemas.Decimal);
                Numeracion segundoOperador = new Numeracion(result2, ESistemas.Decimal);
                Operacion operacio = new Operacion(primerOperador, segundoOperador);
                if (!(char.TryParse(this.comboBoxOperadores.Text, out char operador)))
                {
                    MessageBox.Show("Debe ingresar un operador para hacer la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    operador = char.Parse(this.comboBoxOperadores.Text);
                    Numeracion resultado = operacio.Operar(operador);
                    lblResult.Text = resultado.Valor;
                    //MessageBox.Show(resultado.Valor, "Resultado en decimal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(resultado.ConvertirA(ESistemas.Binario), "Resultado en binario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void FormView_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Resultado:");
            this.lblResult.Text = sb.ToString();
            //this.comboBoxOperadores.Items[0];

        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro de que quiere cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!(respuesta == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOperadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}