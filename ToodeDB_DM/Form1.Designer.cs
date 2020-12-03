namespace ToodeDB_DM
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
            this.Toode = new System.Windows.Forms.TextBox();
            this.Kogus = new System.Windows.Forms.TextBox();
            this.Hind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lisa = new System.Windows.Forms.Button();
            this.Uuenda = new System.Windows.Forms.Button();
            this.Kustuta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toodedDataSet = new ToodeDB_DM.ToodedDataSet();
            this.toodetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodetableTableAdapter = new ToodeDB_DM.ToodedDataSetTableAdapters.ToodetableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toodenimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Toode
            // 
            this.Toode.Location = new System.Drawing.Point(186, 81);
            this.Toode.Name = "Toode";
            this.Toode.Size = new System.Drawing.Size(100, 20);
            this.Toode.TabIndex = 0;
            // 
            // Kogus
            // 
            this.Kogus.Location = new System.Drawing.Point(186, 134);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(100, 20);
            this.Kogus.TabIndex = 1;
            // 
            // Hind
            // 
            this.Hind.Location = new System.Drawing.Point(186, 193);
            this.Hind.Name = "Hind";
            this.Hind.Size = new System.Drawing.Size(100, 20);
            this.Hind.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kogus";
            // 
            // Lisa
            // 
            this.Lisa.Location = new System.Drawing.Point(48, 246);
            this.Lisa.Name = "Lisa";
            this.Lisa.Size = new System.Drawing.Size(75, 23);
            this.Lisa.TabIndex = 6;
            this.Lisa.Text = "Lisa uus";
            this.Lisa.UseVisualStyleBackColor = true;
            this.Lisa.Click += new System.EventHandler(this.Lisa_Click);
            // 
            // Uuenda
            // 
            this.Uuenda.Location = new System.Drawing.Point(48, 293);
            this.Uuenda.Name = "Uuenda";
            this.Uuenda.Size = new System.Drawing.Size(75, 23);
            this.Uuenda.TabIndex = 7;
            this.Uuenda.Text = "Uuenda";
            this.Uuenda.UseVisualStyleBackColor = true;
            // 
            // Kustuta
            // 
            this.Kustuta.Location = new System.Drawing.Point(48, 347);
            this.Kustuta.Name = "Kustuta";
            this.Kustuta.Size = new System.Drawing.Size(75, 23);
            this.Kustuta.TabIndex = 8;
            this.Kustuta.Text = "Kustuta";
            this.Kustuta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.toodenimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(310, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 132);
            this.dataGridView1.TabIndex = 9;
            // 
            // toodedDataSet
            // 
            this.toodedDataSet.DataSetName = "ToodedDataSet";
            this.toodedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodetableBindingSource
            // 
            this.toodetableBindingSource.DataMember = "Toodetable";
            this.toodetableBindingSource.DataSource = this.toodedDataSet;
            // 
            // toodetableTableAdapter
            // 
            this.toodetableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toodenimetusDataGridViewTextBoxColumn
            // 
            this.toodenimetusDataGridViewTextBoxColumn.DataPropertyName = "Toodenimetus";
            this.toodenimetusDataGridViewTextBoxColumn.HeaderText = "Toodenimetus";
            this.toodenimetusDataGridViewTextBoxColumn.Name = "toodenimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "Kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "Kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Kustuta);
            this.Controls.Add(this.Uuenda);
            this.Controls.Add(this.Lisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hind);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.Toode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toode;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.TextBox Hind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Lisa;
        private System.Windows.Forms.Button Uuenda;
        private System.Windows.Forms.Button Kustuta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToodedDataSet toodedDataSet;
        private System.Windows.Forms.BindingSource toodetableBindingSource;
        private ToodedDataSetTableAdapters.ToodetableTableAdapter toodetableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toodenimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
    }
}

