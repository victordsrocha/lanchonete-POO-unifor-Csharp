﻿namespace Lanchonete.telas {
    partial class CadastroItemPedido {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.valorUniTextBox = new System.Windows.Forms.TextBox();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Confirmarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do item";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(84, 106);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(139, 37);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(139, 63);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 4;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(397, 77);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.ReadOnly = true;
            this.categoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoriaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.quantidadeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 253);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Item para pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor unitário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estoque atual";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(397, 51);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 11;
            // 
            // valorUniTextBox
            // 
            this.valorUniTextBox.Location = new System.Drawing.Point(397, 103);
            this.valorUniTextBox.Name = "valorUniTextBox";
            this.valorUniTextBox.ReadOnly = true;
            this.valorUniTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorUniTextBox.TabIndex = 12;
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.Location = new System.Drawing.Point(397, 129);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.ReadOnly = true;
            this.estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.estoqueTextBox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Confirmarbutton);
            this.groupBox2.Location = new System.Drawing.Point(282, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 253);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmação";
            // 
            // Confirmarbutton
            // 
            this.Confirmarbutton.Location = new System.Drawing.Point(86, 147);
            this.Confirmarbutton.Name = "Confirmarbutton";
            this.Confirmarbutton.Size = new System.Drawing.Size(75, 23);
            this.Confirmarbutton.TabIndex = 5;
            this.Confirmarbutton.Text = "Confirmar";
            this.Confirmarbutton.UseVisualStyleBackColor = true;
            // 
            // CadastroItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 275);
            this.Controls.Add(this.estoqueTextBox);
            this.Controls.Add(this.valorUniTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CadastroItemPedido";
            this.Text = "Cadastro de item para pedido";
            this.Load += new System.EventHandler(this.CadastroItemPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox valorUniTextBox;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Confirmarbutton;
    }
}