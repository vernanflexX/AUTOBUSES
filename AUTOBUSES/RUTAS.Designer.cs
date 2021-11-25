namespace AUTOBUSES
{
    partial class RUTAS
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
            this.aggRUTA = new System.Windows.Forms.Button();
            this.textRUTA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(521, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // aggRUTA
            // 
            this.aggRUTA.Location = new System.Drawing.Point(248, 338);
            this.aggRUTA.Name = "aggRUTA";
            this.aggRUTA.Size = new System.Drawing.Size(124, 36);
            this.aggRUTA.TabIndex = 1;
            this.aggRUTA.Text = "AGREGAR";
            this.aggRUTA.UseVisualStyleBackColor = true;
            this.aggRUTA.Click += new System.EventHandler(this.aggRUTA_Click);
            // 
            // textRUTA
            // 
            this.textRUTA.Location = new System.Drawing.Point(260, 312);
            this.textRUTA.Name = "textRUTA";
            this.textRUTA.Size = new System.Drawing.Size(100, 20);
            this.textRUTA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "DESEA AGREGAR UNA NUEVA RUTA??";
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Location = new System.Drawing.Point(494, 372);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(107, 41);
            this.btnCLEAR.TabIndex = 4;
            this.btnCLEAR.Text = "LIMPIAR CAMPOS";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RUTA";
            // 
            // RUTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRUTA);
            this.Controls.Add(this.aggRUTA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RUTAS";
            this.Text = "RUTAS";
            this.Load += new System.EventHandler(this.RUTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button aggRUTA;
        private System.Windows.Forms.TextBox textRUTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Label label3;
    }
}