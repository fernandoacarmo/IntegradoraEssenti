namespace ManutencaoVTEX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnObterParcelas = new System.Windows.Forms.Button();
            this.btnObterNSU = new System.Windows.Forms.Button();
            this.numeroPedidoEcommerce = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDescriptografarEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailCriptografado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailDescriptografado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NSUAntigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NSUNovo = new System.Windows.Forms.TextBox();
            this.btnDescriptografarCadastro = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPedido = new System.Windows.Forms.Label();
            this.btnDownloadPedido = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPedidoDownload = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(794, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnObterParcelas
            // 
            this.btnObterParcelas.Location = new System.Drawing.Point(12, 12);
            this.btnObterParcelas.Name = "btnObterParcelas";
            this.btnObterParcelas.Size = new System.Drawing.Size(231, 27);
            this.btnObterParcelas.TabIndex = 1;
            this.btnObterParcelas.Text = "Obter parcelas não geradas";
            this.btnObterParcelas.UseVisualStyleBackColor = true;
            this.btnObterParcelas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnObterNSU
            // 
            this.btnObterNSU.Location = new System.Drawing.Point(12, 89);
            this.btnObterNSU.Name = "btnObterNSU";
            this.btnObterNSU.Size = new System.Drawing.Size(230, 27);
            this.btnObterNSU.TabIndex = 2;
            this.btnObterNSU.Text = "Obter NSU";
            this.btnObterNSU.UseVisualStyleBackColor = true;
            this.btnObterNSU.Click += new System.EventHandler(this.button3_Click);
            // 
            // numeroPedidoEcommerce
            // 
            this.numeroPedidoEcommerce.Location = new System.Drawing.Point(388, 90);
            this.numeroPedidoEcommerce.Name = "numeroPedidoEcommerce";
            this.numeroPedidoEcommerce.Size = new System.Drawing.Size(181, 22);
            this.numeroPedidoEcommerce.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(249, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(635, 27);
            this.progressBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(257, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número do pedido:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDescriptografarEmail
            // 
            this.btnDescriptografarEmail.Location = new System.Drawing.Point(12, 167);
            this.btnDescriptografarEmail.Name = "btnDescriptografarEmail";
            this.btnDescriptografarEmail.Size = new System.Drawing.Size(230, 27);
            this.btnDescriptografarEmail.TabIndex = 7;
            this.btnDescriptografarEmail.Text = "Descriptografar e-mail";
            this.btnDescriptografarEmail.UseVisualStyleBackColor = true;
            this.btnDescriptografarEmail.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(243, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-Mail criptografado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmailCriptografado
            // 
            this.EmailCriptografado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailCriptografado.Location = new System.Drawing.Point(388, 169);
            this.EmailCriptografado.Name = "EmailCriptografado";
            this.EmailCriptografado.Size = new System.Drawing.Size(495, 22);
            this.EmailCriptografado.TabIndex = 8;
            this.EmailCriptografado.Text = "0A8CDC4C20F748CEB2595137BB76A997@CT.VTEX.COM.BR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(281, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-Mail retorno:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmailDescriptografado
            // 
            this.EmailDescriptografado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailDescriptografado.Enabled = false;
            this.EmailDescriptografado.Location = new System.Drawing.Point(388, 197);
            this.EmailDescriptografado.Name = "EmailDescriptografado";
            this.EmailDescriptografado.ReadOnly = true;
            this.EmailDescriptografado.Size = new System.Drawing.Size(494, 22);
            this.EmailDescriptografado.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(298, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "NSU antigo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NSUAntigo
            // 
            this.NSUAntigo.Enabled = false;
            this.NSUAntigo.Location = new System.Drawing.Point(388, 117);
            this.NSUAntigo.Name = "NSUAntigo";
            this.NSUAntigo.ReadOnly = true;
            this.NSUAntigo.Size = new System.Drawing.Size(181, 22);
            this.NSUAntigo.TabIndex = 12;
            this.NSUAntigo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(620, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "NSU novo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NSUNovo
            // 
            this.NSUNovo.Enabled = false;
            this.NSUNovo.Location = new System.Drawing.Point(702, 117);
            this.NSUNovo.Name = "NSUNovo";
            this.NSUNovo.ReadOnly = true;
            this.NSUNovo.Size = new System.Drawing.Size(181, 22);
            this.NSUNovo.TabIndex = 14;
            this.NSUNovo.TabStop = false;
            // 
            // btnDescriptografarCadastro
            // 
            this.btnDescriptografarCadastro.Location = new System.Drawing.Point(12, 232);
            this.btnDescriptografarCadastro.Name = "btnDescriptografarCadastro";
            this.btnDescriptografarCadastro.Size = new System.Drawing.Size(230, 27);
            this.btnDescriptografarCadastro.TabIndex = 16;
            this.btnDescriptografarCadastro.Text = "Descriptografar e-mail (cadastro)";
            this.btnDescriptografarCadastro.UseVisualStyleBackColor = true;
            this.btnDescriptografarCadastro.Click += new System.EventHandler(this.button5_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(249, 232);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(635, 27);
            this.progressBar2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(113, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Número do pedido:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPedido.Location = new System.Drawing.Point(248, 42);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(96, 17);
            this.labelPedido.TabIndex = 19;
            this.labelPedido.Text = "00000000000";
            this.labelPedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDownloadPedido
            // 
            this.btnDownloadPedido.Location = new System.Drawing.Point(12, 292);
            this.btnDownloadPedido.Name = "btnDownloadPedido";
            this.btnDownloadPedido.Size = new System.Drawing.Size(230, 27);
            this.btnDownloadPedido.TabIndex = 20;
            this.btnDownloadPedido.Text = "Download pedido";
            this.btnDownloadPedido.UseVisualStyleBackColor = true;
            this.btnDownloadPedido.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(257, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Número do pedido:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPedidoDownload
            // 
            this.txtPedidoDownload.Location = new System.Drawing.Point(388, 292);
            this.txtPedidoDownload.Name = "txtPedidoDownload";
            this.txtPedidoDownload.Size = new System.Drawing.Size(494, 22);
            this.txtPedidoDownload.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(385, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Utilizar a chave, exemplo:  SHP-674800144517-01";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 386);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPedidoDownload);
            this.Controls.Add(this.btnDownloadPedido);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnDescriptografarCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NSUNovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NSUAntigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailDescriptografado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailCriptografado);
            this.Controls.Add(this.btnDescriptografarEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numeroPedidoEcommerce);
            this.Controls.Add(this.btnObterNSU);
            this.Controls.Add(this.btnObterParcelas);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Manutenção da VTex";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnObterParcelas;
        private System.Windows.Forms.Button btnObterNSU;
        private System.Windows.Forms.TextBox numeroPedidoEcommerce;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDescriptografarEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailCriptografado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailDescriptografado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NSUAntigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NSUNovo;
        private System.Windows.Forms.Button btnDescriptografarCadastro;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Button btnDownloadPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPedidoDownload;
        private System.Windows.Forms.Label label8;
    }
}

