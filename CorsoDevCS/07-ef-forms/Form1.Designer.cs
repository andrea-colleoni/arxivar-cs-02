namespace _07_ef_forms
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estensioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popolazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.regioneDataGridViewTextBoxColumn,
            this.estensioneDataGridViewTextBoxColumn,
            this.popolazioneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cittaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // regioneDataGridViewTextBoxColumn
            // 
            this.regioneDataGridViewTextBoxColumn.DataPropertyName = "Regione";
            this.regioneDataGridViewTextBoxColumn.HeaderText = "Regione";
            this.regioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regioneDataGridViewTextBoxColumn.Name = "regioneDataGridViewTextBoxColumn";
            this.regioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // estensioneDataGridViewTextBoxColumn
            // 
            this.estensioneDataGridViewTextBoxColumn.DataPropertyName = "Estensione";
            this.estensioneDataGridViewTextBoxColumn.HeaderText = "Estensione";
            this.estensioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estensioneDataGridViewTextBoxColumn.Name = "estensioneDataGridViewTextBoxColumn";
            this.estensioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // popolazioneDataGridViewTextBoxColumn
            // 
            this.popolazioneDataGridViewTextBoxColumn.DataPropertyName = "Popolazione";
            this.popolazioneDataGridViewTextBoxColumn.HeaderText = "Popolazione";
            this.popolazioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.popolazioneDataGridViewTextBoxColumn.Name = "popolazioneDataGridViewTextBoxColumn";
            this.popolazioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cittaBindingSource
            // 
            this.cittaBindingSource.DataSource = typeof(_07_ef_forms.Citta);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estensioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popolazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cittaBindingSource;
        private System.Windows.Forms.Button button1;
    }
}

