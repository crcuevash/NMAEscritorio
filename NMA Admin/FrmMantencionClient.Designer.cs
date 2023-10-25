namespace NMA_Admin
{
    partial class FrmMantencionClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantencionClient));
            this.btnNuevoClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientes = new NMA_Admin.Clientes();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new NMA_Admin.ClientesTableAdapters.CLIENTETableAdapter();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAREGISTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoClient
            // 
            this.btnNuevoClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoClient.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoClient.Image")));
            this.btnNuevoClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoClient.Location = new System.Drawing.Point(199, 376);
            this.btnNuevoClient.Name = "btnNuevoClient";
            this.btnNuevoClient.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNuevoClient.Size = new System.Drawing.Size(157, 46);
            this.btnNuevoClient.TabIndex = 4;
            this.btnNuevoClient.Text = "        Nuevo Cliente";
            this.btnNuevoClient.UseVisualStyleBackColor = true;
            this.btnNuevoClient.Click += new System.EventHandler(this.btnNuevoClient_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(576, 376);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "        Eliminar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(392, 376);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(157, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "        Editar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.eMPRESADataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.uSUARIODataGridViewTextBoxColumn,
            this.cONTRASENADataGridViewTextBoxColumn,
            this.fECHAREGISTRODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 311);
            this.dataGridView1.TabIndex = 7;
            // 
            // clientes
            // 
            this.clientes.DataSetName = "Clientes";
            this.clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.clientes;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            // 
            // eMPRESADataGridViewTextBoxColumn
            // 
            this.eMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA";
            this.eMPRESADataGridViewTextBoxColumn.HeaderText = "EMPRESA";
            this.eMPRESADataGridViewTextBoxColumn.Name = "eMPRESADataGridViewTextBoxColumn";
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            // 
            // uSUARIODataGridViewTextBoxColumn
            // 
            this.uSUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.Name = "uSUARIODataGridViewTextBoxColumn";
            // 
            // cONTRASENADataGridViewTextBoxColumn
            // 
            this.cONTRASENADataGridViewTextBoxColumn.DataPropertyName = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.HeaderText = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.Name = "cONTRASENADataGridViewTextBoxColumn";
            // 
            // fECHAREGISTRODataGridViewTextBoxColumn
            // 
            this.fECHAREGISTRODataGridViewTextBoxColumn.DataPropertyName = "FECHA_REGISTRO";
            this.fECHAREGISTRODataGridViewTextBoxColumn.HeaderText = "FECHA_REGISTRO";
            this.fECHAREGISTRODataGridViewTextBoxColumn.Name = "fECHAREGISTRODataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "CLIENTES";
            // 
            // FrmMantencionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevoClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantencionClient";
            this.Text = "FrmMantencionClient";
            this.Load += new System.EventHandler(this.FrmMantencionClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Clientes clientes;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private ClientesTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASENADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAREGISTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}