namespace kontr_2
{
    partial class Form4
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
            this.postcardDataSet = new kontr_2.postcardDataSet();
            this.postcardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postcardTableAdapter = new kontr_2.postcardDataSetTableAdapters.postcardTableAdapter();
            this.tableAdapterManager = new kontr_2.postcardDataSetTableAdapters.TableAdapterManager();
            this.idpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameaddresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaddresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpDataGridViewTextBoxColumn,
            this.nameaddresDataGridViewTextBoxColumn,
            this.emailaddresDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postcardBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // postcardDataSet
            // 
            this.postcardDataSet.DataSetName = "postcardDataSet";
            this.postcardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postcardBindingSource
            // 
            this.postcardBindingSource.DataMember = "postcard";
            this.postcardBindingSource.DataSource = this.postcardDataSet;
            // 
            // postcardTableAdapter
            // 
            this.postcardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.postcardTableAdapter = this.postcardTableAdapter;
            this.tableAdapterManager.UpdateOrder = kontr_2.postcardDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idpDataGridViewTextBoxColumn
            // 
            this.idpDataGridViewTextBoxColumn.DataPropertyName = "id_p";
            this.idpDataGridViewTextBoxColumn.HeaderText = "id_p";
            this.idpDataGridViewTextBoxColumn.Name = "idpDataGridViewTextBoxColumn";
            // 
            // nameaddresDataGridViewTextBoxColumn
            // 
            this.nameaddresDataGridViewTextBoxColumn.DataPropertyName = "name_addres";
            this.nameaddresDataGridViewTextBoxColumn.HeaderText = "name_addres";
            this.nameaddresDataGridViewTextBoxColumn.Name = "nameaddresDataGridViewTextBoxColumn";
            // 
            // emailaddresDataGridViewTextBoxColumn
            // 
            this.emailaddresDataGridViewTextBoxColumn.DataPropertyName = "email_addres";
            this.emailaddresDataGridViewTextBoxColumn.HeaderText = "email_addres";
            this.emailaddresDataGridViewTextBoxColumn.Name = "emailaddresDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 342);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private postcardDataSet postcardDataSet;
        private System.Windows.Forms.BindingSource postcardBindingSource;
        private postcardDataSetTableAdapters.postcardTableAdapter postcardTableAdapter;
        private postcardDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameaddresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaddresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}