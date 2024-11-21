namespace Tabla_multiplicar
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void LabelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void LabelPregunta_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.MuestraTabla();
        }

        private void MuestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxNum.Text);
            string tabla = "";
            for (int i = 0; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
                
            }
            this.richTextBoxResultados.AppendText(tabla);
        }
    }
}
