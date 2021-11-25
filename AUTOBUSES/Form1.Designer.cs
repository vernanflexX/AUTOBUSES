namespace AUTOBUSES
{
    partial class SISTEMA_DE_CONTROL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.asgRUTA = new System.Windows.Forms.Button();
            this.aggCHOFER = new System.Windows.Forms.Button();
            this.aggAUTOBUS = new System.Windows.Forms.Button();
            this.aggRUTA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.actualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // asgRUTA
            // 
            this.asgRUTA.Location = new System.Drawing.Point(47, 238);
            this.asgRUTA.Name = "asgRUTA";
            this.asgRUTA.Size = new System.Drawing.Size(95, 48);
            this.asgRUTA.TabIndex = 0;
            this.asgRUTA.Text = "ASIGNAR RUTA";
            this.asgRUTA.UseVisualStyleBackColor = true;
            this.asgRUTA.Click += new System.EventHandler(this.asgRUTA_Click);
            // 
            // aggCHOFER
            // 
            this.aggCHOFER.Location = new System.Drawing.Point(163, 238);
            this.aggCHOFER.Name = "aggCHOFER";
            this.aggCHOFER.Size = new System.Drawing.Size(95, 48);
            this.aggCHOFER.TabIndex = 3;
            this.aggCHOFER.Text = "AGREGAR CHOFER";
            this.aggCHOFER.UseVisualStyleBackColor = true;
            this.aggCHOFER.Click += new System.EventHandler(this.aggCHOFER_Click);
            // 
            // aggAUTOBUS
            // 
            this.aggAUTOBUS.Location = new System.Drawing.Point(278, 237);
            this.aggAUTOBUS.Name = "aggAUTOBUS";
            this.aggAUTOBUS.Size = new System.Drawing.Size(95, 49);
            this.aggAUTOBUS.TabIndex = 7;
            this.aggAUTOBUS.Text = "AGREGAR AUTOBUS";
            this.aggAUTOBUS.UseVisualStyleBackColor = true;
            this.aggAUTOBUS.Click += new System.EventHandler(this.aggAUTOBUS_Click);
            // 
            // aggRUTA
            // 
            this.aggRUTA.Location = new System.Drawing.Point(388, 237);
            this.aggRUTA.Name = "aggRUTA";
            this.aggRUTA.Size = new System.Drawing.Size(95, 49);
            this.aggRUTA.TabIndex = 8;
            this.aggRUTA.Text = "AGREGAR RUTA";
            this.aggRUTA.UseVisualStyleBackColor = true;
            this.aggRUTA.Click += new System.EventHandler(this.aggRUTA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "TRABAJOS ASIGNADOS";
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(386, 56);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(125, 29);
            this.actualizar.TabIndex = 10;
            this.actualizar.Text = "REFRESCAR";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 126);
            this.dataGridView1.TabIndex = 11;
            // 
            // SISTEMA_DE_CONTROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(537, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aggRUTA);
            this.Controls.Add(this.aggAUTOBUS);
            this.Controls.Add(this.aggCHOFER);
            this.Controls.Add(this.asgRUTA);
            this.Name = "SISTEMA_DE_CONTROL";
            this.Text = "SISTEMA DE CONTROL DE AUTOBUSES";
            this.Load += new System.EventHandler(this.SISTEMA_DE_CONTROL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button asgRUTA;
        private System.Windows.Forms.Button aggCHOFER;
        private System.Windows.Forms.Button aggAUTOBUS;
        private System.Windows.Forms.Button aggRUTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

