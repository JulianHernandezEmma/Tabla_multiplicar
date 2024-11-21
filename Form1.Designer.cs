namespace Tabla_multiplicar
{
    partial class PanelPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTitulo = new Label();
            LabelPregunta = new Label();
            textBoxNum = new TextBox();
            buttonConfirmar = new Button();
            richTextBoxResultados = new RichTextBox();
            pictureBox1 = new PictureBox();
            MyNameIs = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.BackColor = Color.FromArgb(0, 100, 255);
            LabelTitulo.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(12, 9);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(421, 52);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Tabla de Multiplicar";
            LabelTitulo.Click += LabelTitulo_Click;
            // 
            // LabelPregunta
            // 
            LabelPregunta.AutoSize = true;
            LabelPregunta.BackColor = Color.FromArgb(0, 100, 255);
            LabelPregunta.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPregunta.Location = new Point(12, 82);
            LabelPregunta.Name = "LabelPregunta";
            LabelPregunta.Size = new Size(384, 23);
            LabelPregunta.TabIndex = 1;
            LabelPregunta.Text = "¿Qué tabla de multiplicar quieres?";
            LabelPregunta.Click += LabelPregunta_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = Color.White;
            textBoxNum.Location = new Point(15, 122);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(381, 27);
            textBoxNum.TabIndex = 2;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.White;
            buttonConfirmar.Cursor = Cursors.Hand;
            buttonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonConfirmar.Location = new Point(139, 159);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(128, 29);
            buttonConfirmar.TabIndex = 3;
            buttonConfirmar.Text = "VER TABLA";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Lucida Handwriting", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(461, 65);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(275, 328);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.yo;
            pictureBox1.Location = new Point(101, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 224);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MyNameIs
            // 
            MyNameIs.AutoSize = true;
            MyNameIs.BackColor = Color.Silver;
            MyNameIs.Location = new Point(460, 398);
            MyNameIs.Name = "MyNameIs";
            MyNameIs.Size = new Size(277, 20);
            MyNameIs.TabIndex = 6;
            MyNameIs.Text = "Alumno: Julián Emmanuel Hernández 3A";
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 120, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(MyNameIs);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBoxResultados);
            Controls.Add(buttonConfirmar);
            Controls.Add(textBoxNum);
            Controls.Add(LabelPregunta);
            Controls.Add(LabelTitulo);
            Name = "PanelPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitulo;
        private Label LabelPregunta;
        private TextBox textBoxNum;
        private Button buttonConfirmar;
        private RichTextBox richTextBoxResultados;
        private PictureBox pictureBox1;
        private Label MyNameIs;
    }
}
