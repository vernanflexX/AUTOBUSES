﻿namespace AUTOBUSES
{
    partial class CHOFERES
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNOMBRE = new System.Windows.Forms.TextBox();
            this.textAPELLIDO = new System.Windows.Forms.TextBox();
            this.textCEDULA = new System.Windows.Forms.TextBox();
            this.aggCHOFER = new System.Windows.Forms.Button();
            this.textFECHA = new System.Windows.Forms.DateTimePicker();
            this.btnCLEAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 146);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESEA AGREGAR OTRO CHOFER?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "APELLIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA DE NACIMIENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CEDULA";
            // 
            // textNOMBRE
            // 
            this.textNOMBRE.Location = new System.Drawing.Point(55, 316);
            this.textNOMBRE.Name = "textNOMBRE";
            this.textNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.textNOMBRE.TabIndex = 6;
            // 
            // textAPELLIDO
            // 
            this.textAPELLIDO.Location = new System.Drawing.Point(181, 316);
            this.textAPELLIDO.Name = "textAPELLIDO";
            this.textAPELLIDO.Size = new System.Drawing.Size(100, 20);
            this.textAPELLIDO.TabIndex = 7;
            // 
            // textCEDULA
            // 
            this.textCEDULA.Location = new System.Drawing.Point(530, 316);
            this.textCEDULA.Name = "textCEDULA";
            this.textCEDULA.Size = new System.Drawing.Size(100, 20);
            this.textCEDULA.TabIndex = 9;
            // 
            // aggCHOFER
            // 
            this.aggCHOFER.Location = new System.Drawing.Point(402, 391);
            this.aggCHOFER.Name = "aggCHOFER";
            this.aggCHOFER.Size = new System.Drawing.Size(101, 38);
            this.aggCHOFER.TabIndex = 10;
            this.aggCHOFER.Text = "AGREGAR";
            this.aggCHOFER.UseVisualStyleBackColor = true;
            this.aggCHOFER.Click += new System.EventHandler(this.aggCHOFER_Click);
            // 
            // textFECHA
            // 
            this.textFECHA.Location = new System.Drawing.Point(303, 316);
            this.textFECHA.Name = "textFECHA";
            this.textFECHA.Size = new System.Drawing.Size(200, 20);
            this.textFECHA.TabIndex = 11;
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Location = new System.Drawing.Point(541, 391);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(101, 38);
            this.btnCLEAR.TabIndex = 12;
            this.btnCLEAR.Text = "LIMPIAR CAMPOS";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // CHOFERES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.textFECHA);
            this.Controls.Add(this.aggCHOFER);
            this.Controls.Add(this.textCEDULA);
            this.Controls.Add(this.textAPELLIDO);
            this.Controls.Add(this.textNOMBRE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CHOFERES";
            this.Text = "CHOFERES";
            this.Load += new System.EventHandler(this.CHOFERES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNOMBRE;
        private System.Windows.Forms.TextBox textAPELLIDO;
        private System.Windows.Forms.TextBox textCEDULA;
        private System.Windows.Forms.Button aggCHOFER;
        private System.Windows.Forms.DateTimePicker textFECHA;
        private System.Windows.Forms.Button btnCLEAR;
    }
}