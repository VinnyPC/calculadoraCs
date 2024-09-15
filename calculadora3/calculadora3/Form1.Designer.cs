
namespace calculadora3
{
    partial class Form1
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
            lblVisor = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // lblVisor
            // 
            lblVisor.BorderStyle = BorderStyle.FixedSingle;
            lblVisor.Location = new Point(12, 9);
            lblVisor.Name = "lblVisor";
            lblVisor.Size = new Size(404, 70);
            lblVisor.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(34, 164);
            btn1.Name = "btn1";
            btn1.Size = new Size(62, 63);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(126, 164);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 63);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(224, 164);
            btn3.Name = "btn3";
            btn3.Size = new Size(62, 63);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(126, 250);
            btn5.Name = "btn5";
            btn5.Size = new Size(62, 63);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(34, 250);
            btn4.Name = "btn4";
            btn4.Size = new Size(62, 63);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(224, 250);
            btn6.Name = "btn6";
            btn6.Size = new Size(62, 63);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(34, 337);
            btn7.Name = "btn7";
            btn7.Size = new Size(62, 63);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(126, 337);
            btn8.Name = "btn8";
            btn8.Size = new Size(62, 63);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(224, 337);
            btn9.Name = "btn9";
            btn9.Size = new Size(62, 63);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(34, 422);
            btn0.Name = "btn0";
            btn0.Size = new Size(252, 63);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(322, 324);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(73, 101);
            btnSoma.TabIndex = 11;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.Location = new Point(322, 250);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(73, 63);
            btnSubtracao.TabIndex = 12;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicacao.Location = new Point(322, 164);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(73, 63);
            btnMultiplicacao.TabIndex = 13;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivisao.Location = new Point(322, 106);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(73, 39);
            btnDivisao.TabIndex = 14;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(34, 106);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(73, 39);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(322, 441);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(73, 63);
            btnResultado.TabIndex = 16;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 516);
            Controls.Add(btnResultado);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblVisor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btn33_Click(object sender, EventArgs e)
        {
         
        }

        private void btn44_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label lblVisor;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn5;
        private Button btn4;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnResultado;
    }
}
