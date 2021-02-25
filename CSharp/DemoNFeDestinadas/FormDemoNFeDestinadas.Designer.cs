
namespace DemoNFeDestinadas
{
    partial class FormNFeDestinadas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlNotas = new System.Windows.Forms.TabControl();
            this.tabPageJSON = new System.Windows.Forms.TabPage();
            this.txtJSON = new System.Windows.Forms.RichTextBox();
            this.tabPageGrid = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.txtNrNotas = new System.Windows.Forms.TextBox();
            this.lblNrNotas = new System.Windows.Forms.Label();
            this.lblNrPaginas = new System.Windows.Forms.Label();
            this.txtNrPaginas = new System.Windows.Forms.TextBox();
            this.dtgViewNotas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConsultarNFeDestinadas = new System.Windows.Forms.Button();
            this.lblTokenSH = new System.Windows.Forms.Label();
            this.lblCpfCnpjSH = new System.Windows.Forms.Label();
            this.txtTokenSH = new System.Windows.Forms.TextBox();
            this.txtCpfCnpjSH = new System.Windows.Forms.TextBox();
            this.txtCpfCnpjDestinario = new System.Windows.Forms.TextBox();
            this.lblCpfCnpjDestinatario = new System.Windows.Forms.Label();
            this.lblNrProtocolo = new System.Windows.Forms.Label();
            this.txtNrProtocolo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControlNotas.SuspendLayout();
            this.tabPageJSON.SuspendLayout();
            this.tabPageGrid.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewNotas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlNotas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 11;
            // 
            // tabControlNotas
            // 
            this.tabControlNotas.Controls.Add(this.tabPageJSON);
            this.tabControlNotas.Controls.Add(this.tabPageGrid);
            this.tabControlNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNotas.Location = new System.Drawing.Point(0, 0);
            this.tabControlNotas.Name = "tabControlNotas";
            this.tabControlNotas.SelectedIndex = 0;
            this.tabControlNotas.Size = new System.Drawing.Size(784, 461);
            this.tabControlNotas.TabIndex = 0;
            // 
            // tabPageJSON
            // 
            this.tabPageJSON.Controls.Add(this.txtJSON);
            this.tabPageJSON.Location = new System.Drawing.Point(4, 22);
            this.tabPageJSON.Name = "tabPageJSON";
            this.tabPageJSON.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJSON.Size = new System.Drawing.Size(776, 435);
            this.tabPageJSON.TabIndex = 0;
            this.tabPageJSON.Text = "Retorno JSON";
            this.tabPageJSON.UseVisualStyleBackColor = true;
            // 
            // txtJSON
            // 
            this.txtJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJSON.Location = new System.Drawing.Point(3, 3);
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.Size = new System.Drawing.Size(770, 429);
            this.txtJSON.TabIndex = 0;
            this.txtJSON.Text = "";
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.Controls.Add(this.dtgViewNotas);
            this.tabPageGrid.Controls.Add(this.panel3);
            this.tabPageGrid.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrid.Size = new System.Drawing.Size(776, 435);
            this.tabPageGrid.TabIndex = 1;
            this.tabPageGrid.Text = "Retorno Convertido (Notas)";
            this.tabPageGrid.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMensagem);
            this.panel3.Controls.Add(this.lblSituacao);
            this.panel3.Controls.Add(this.txtMensagem);
            this.panel3.Controls.Add(this.txtSituacao);
            this.panel3.Controls.Add(this.txtNrNotas);
            this.panel3.Controls.Add(this.lblNrNotas);
            this.panel3.Controls.Add(this.lblNrPaginas);
            this.panel3.Controls.Add(this.txtNrPaginas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 58);
            this.panel3.TabIndex = 0;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(117, 10);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Mensagem";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(5, 10);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(117, 26);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(345, 20);
            this.txtMensagem.TabIndex = 3;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(5, 26);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(104, 20);
            this.txtSituacao.TabIndex = 1;
            // 
            // txtNrNotas
            // 
            this.txtNrNotas.Location = new System.Drawing.Point(473, 26);
            this.txtNrNotas.Name = "txtNrNotas";
            this.txtNrNotas.Size = new System.Drawing.Size(64, 20);
            this.txtNrNotas.TabIndex = 5;
            // 
            // lblNrNotas
            // 
            this.lblNrNotas.AutoSize = true;
            this.lblNrNotas.Location = new System.Drawing.Point(473, 10);
            this.lblNrNotas.Name = "lblNrNotas";
            this.lblNrNotas.Size = new System.Drawing.Size(64, 13);
            this.lblNrNotas.TabIndex = 4;
            this.lblNrNotas.Text = "Nr de Notas";
            // 
            // lblNrPaginas
            // 
            this.lblNrPaginas.AutoSize = true;
            this.lblNrPaginas.Location = new System.Drawing.Point(543, 10);
            this.lblNrPaginas.Name = "lblNrPaginas";
            this.lblNrPaginas.Size = new System.Drawing.Size(74, 13);
            this.lblNrPaginas.TabIndex = 6;
            this.lblNrPaginas.Text = "Nr de Páginas";
            // 
            // txtNrPaginas
            // 
            this.txtNrPaginas.Location = new System.Drawing.Point(543, 26);
            this.txtNrPaginas.Name = "txtNrPaginas";
            this.txtNrPaginas.Size = new System.Drawing.Size(74, 20);
            this.txtNrPaginas.TabIndex = 7;
            // 
            // dtgViewNotas
            // 
            this.dtgViewNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgViewNotas.Location = new System.Drawing.Point(3, 61);
            this.dtgViewNotas.Name = "dtgViewNotas";
            this.dtgViewNotas.ReadOnly = true;
            this.dtgViewNotas.Size = new System.Drawing.Size(770, 371);
            this.dtgViewNotas.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConsultarNFeDestinadas);
            this.panel2.Controls.Add(this.lblTokenSH);
            this.panel2.Controls.Add(this.lblCpfCnpjSH);
            this.panel2.Controls.Add(this.txtTokenSH);
            this.panel2.Controls.Add(this.txtCpfCnpjSH);
            this.panel2.Controls.Add(this.txtCpfCnpjDestinario);
            this.panel2.Controls.Add(this.lblCpfCnpjDestinatario);
            this.panel2.Controls.Add(this.lblNrProtocolo);
            this.panel2.Controls.Add(this.txtNrProtocolo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnConsultarNFeDestinadas
            // 
            this.btnConsultarNFeDestinadas.Location = new System.Drawing.Point(9, 54);
            this.btnConsultarNFeDestinadas.Name = "btnConsultarNFeDestinadas";
            this.btnConsultarNFeDestinadas.Size = new System.Drawing.Size(140, 23);
            this.btnConsultarNFeDestinadas.TabIndex = 8;
            this.btnConsultarNFeDestinadas.Text = "Consultar NFe Destinadas";
            this.btnConsultarNFeDestinadas.UseVisualStyleBackColor = true;
            this.btnConsultarNFeDestinadas.Click += new System.EventHandler(this.btnConsultarNFeDestinadas_Click);
            // 
            // lblTokenSH
            // 
            this.lblTokenSH.AutoSize = true;
            this.lblTokenSH.Location = new System.Drawing.Point(121, 10);
            this.lblTokenSH.Name = "lblTokenSH";
            this.lblTokenSH.Size = new System.Drawing.Size(117, 13);
            this.lblTokenSH.TabIndex = 2;
            this.lblTokenSH.Text = "Token Software House";
            // 
            // lblCpfCnpjSH
            // 
            this.lblCpfCnpjSH.AutoSize = true;
            this.lblCpfCnpjSH.Location = new System.Drawing.Point(9, 10);
            this.lblCpfCnpjSH.Name = "lblCpfCnpjSH";
            this.lblCpfCnpjSH.Size = new System.Drawing.Size(107, 13);
            this.lblCpfCnpjSH.TabIndex = 0;
            this.lblCpfCnpjSH.Text = "Cnpj Software House";
            // 
            // txtTokenSH
            // 
            this.txtTokenSH.Location = new System.Drawing.Point(121, 26);
            this.txtTokenSH.Name = "txtTokenSH";
            this.txtTokenSH.Size = new System.Drawing.Size(237, 20);
            this.txtTokenSH.TabIndex = 3;
            // 
            // txtCpfCnpjSH
            // 
            this.txtCpfCnpjSH.Location = new System.Drawing.Point(9, 26);
            this.txtCpfCnpjSH.Name = "txtCpfCnpjSH";
            this.txtCpfCnpjSH.Size = new System.Drawing.Size(104, 20);
            this.txtCpfCnpjSH.TabIndex = 1;
            // 
            // txtCpfCnpjDestinario
            // 
            this.txtCpfCnpjDestinario.Location = new System.Drawing.Point(365, 26);
            this.txtCpfCnpjDestinario.Name = "txtCpfCnpjDestinario";
            this.txtCpfCnpjDestinario.Size = new System.Drawing.Size(104, 20);
            this.txtCpfCnpjDestinario.TabIndex = 5;
            // 
            // lblCpfCnpjDestinatario
            // 
            this.lblCpfCnpjDestinatario.AutoSize = true;
            this.lblCpfCnpjDestinatario.Location = new System.Drawing.Point(365, 10);
            this.lblCpfCnpjDestinatario.Name = "lblCpfCnpjDestinatario";
            this.lblCpfCnpjDestinatario.Size = new System.Drawing.Size(106, 13);
            this.lblCpfCnpjDestinatario.TabIndex = 4;
            this.lblCpfCnpjDestinatario.Text = "Cpf Cnpj Destinatário";
            // 
            // lblNrProtocolo
            // 
            this.lblNrProtocolo.AutoSize = true;
            this.lblNrProtocolo.Location = new System.Drawing.Point(477, 10);
            this.lblNrProtocolo.Name = "lblNrProtocolo";
            this.lblNrProtocolo.Size = new System.Drawing.Size(110, 13);
            this.lblNrProtocolo.TabIndex = 6;
            this.lblNrProtocolo.Text = "Nr Protocolo Consulta";
            // 
            // txtNrProtocolo
            // 
            this.txtNrProtocolo.Location = new System.Drawing.Point(477, 26);
            this.txtNrProtocolo.Name = "txtNrProtocolo";
            this.txtNrProtocolo.Size = new System.Drawing.Size(157, 20);
            this.txtNrProtocolo.TabIndex = 7;
            // 
            // FormNFeDestinadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormNFeDestinadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo NFe Destinadas";
            this.panel1.ResumeLayout(false);
            this.tabControlNotas.ResumeLayout(false);
            this.tabPageJSON.ResumeLayout(false);
            this.tabPageGrid.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewNotas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConsultarNFeDestinadas;
        private System.Windows.Forms.Label lblTokenSH;
        private System.Windows.Forms.Label lblCpfCnpjSH;
        private System.Windows.Forms.TextBox txtTokenSH;
        private System.Windows.Forms.TextBox txtCpfCnpjSH;
        private System.Windows.Forms.TextBox txtCpfCnpjDestinario;
        private System.Windows.Forms.Label lblCpfCnpjDestinatario;
        private System.Windows.Forms.Label lblNrProtocolo;
        private System.Windows.Forms.TextBox txtNrProtocolo;
        private System.Windows.Forms.TabControl tabControlNotas;
        private System.Windows.Forms.TabPage tabPageJSON;
        private System.Windows.Forms.RichTextBox txtJSON;
        private System.Windows.Forms.TabPage tabPageGrid;
        private System.Windows.Forms.DataGridView dtgViewNotas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.TextBox txtNrNotas;
        private System.Windows.Forms.Label lblNrNotas;
        private System.Windows.Forms.Label lblNrPaginas;
        private System.Windows.Forms.TextBox txtNrPaginas;
    }
}

