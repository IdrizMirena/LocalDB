namespace Datababse_System_School
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label emriPlotLabel;
            System.Windows.Forms.Label emailiLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label nr_TelefonitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabelaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Datababse_System_School.Database1DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabelaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.emriPlotTextBox = new System.Windows.Forms.TextBox();
            this.emailiTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.nr_TelefonitTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabelaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaTableAdapter = new Datababse_System_School.Database1DataSetTableAdapters.TabelaTableAdapter();
            this.tableAdapterManager = new Datababse_System_School.Database1DataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            emriPlotLabel = new System.Windows.Forms.Label();
            emailiLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            nr_TelefonitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingNavigator)).BeginInit();
            this.tabelaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(72, 321);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // emriPlotLabel
            // 
            emriPlotLabel.AutoSize = true;
            emriPlotLabel.BackColor = System.Drawing.Color.Transparent;
            emriPlotLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emriPlotLabel.Location = new System.Drawing.Point(58, 363);
            emriPlotLabel.Name = "emriPlotLabel";
            emriPlotLabel.Size = new System.Drawing.Size(69, 17);
            emriPlotLabel.TabIndex = 3;
            emriPlotLabel.Text = "Emri Plot:";
            // 
            // emailiLabel
            // 
            emailiLabel.AutoSize = true;
            emailiLabel.BackColor = System.Drawing.Color.Transparent;
            emailiLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailiLabel.Location = new System.Drawing.Point(62, 402);
            emailiLabel.Name = "emailiLabel";
            emailiLabel.Size = new System.Drawing.Size(50, 17);
            emailiLabel.TabIndex = 5;
            emailiLabel.Text = "Emaili:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresaLabel.Location = new System.Drawing.Point(62, 484);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(54, 17);
            adresaLabel.TabIndex = 7;
            adresaLabel.Text = "Adresa:";
            // 
            // nr_TelefonitLabel
            // 
            nr_TelefonitLabel.AutoSize = true;
            nr_TelefonitLabel.BackColor = System.Drawing.Color.Transparent;
            nr_TelefonitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_TelefonitLabel.Location = new System.Drawing.Point(41, 444);
            nr_TelefonitLabel.Name = "nr_TelefonitLabel";
            nr_TelefonitLabel.Size = new System.Drawing.Size(86, 17);
            nr_TelefonitLabel.TabIndex = 9;
            nr_TelefonitLabel.Text = "Nr Telefonit:";
            // 
            // tabelaBindingNavigator
            // 
            this.tabelaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaBindingNavigator.BindingSource = this.tabelaBindingSource;
            this.tabelaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabelaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaBindingNavigatorSaveItem});
            this.tabelaBindingNavigator.Location = new System.Drawing.Point(0, 625);
            this.tabelaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaBindingNavigator.Name = "tabelaBindingNavigator";
            this.tabelaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tabelaBindingNavigator.Size = new System.Drawing.Size(1108, 25);
            this.tabelaBindingNavigator.TabIndex = 0;
            this.tabelaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tabelaBindingSource
            // 
            this.tabelaBindingSource.DataMember = "Tabela";
            this.tabelaBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabelaBindingNavigatorSaveItem
            // 
            this.tabelaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaBindingNavigatorSaveItem.Image")));
            this.tabelaBindingNavigatorSaveItem.Name = "tabelaBindingNavigatorSaveItem";
            this.tabelaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabelaBindingNavigatorSaveItem.Text = "Save Data";
            this.tabelaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaBindingSource, "Id", true));
            this.idTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.idTextBox.Location = new System.Drawing.Point(133, 321);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(252, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // emriPlotTextBox
            // 
            this.emriPlotTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emriPlotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaBindingSource, "EmriPlot", true));
            this.emriPlotTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.emriPlotTextBox.Location = new System.Drawing.Point(133, 360);
            this.emriPlotTextBox.Name = "emriPlotTextBox";
            this.emriPlotTextBox.Size = new System.Drawing.Size(252, 20);
            this.emriPlotTextBox.TabIndex = 4;
            // 
            // emailiTextBox
            // 
            this.emailiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaBindingSource, "Emaili", true));
            this.emailiTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.emailiTextBox.Location = new System.Drawing.Point(133, 399);
            this.emailiTextBox.Name = "emailiTextBox";
            this.emailiTextBox.Size = new System.Drawing.Size(252, 20);
            this.emailiTextBox.TabIndex = 6;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaBindingSource, "Adresa", true));
            this.adresaTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.adresaTextBox.Location = new System.Drawing.Point(133, 481);
            this.adresaTextBox.Multiline = true;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(252, 69);
            this.adresaTextBox.TabIndex = 8;
            // 
            // nr_TelefonitTextBox
            // 
            this.nr_TelefonitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr_TelefonitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaBindingSource, "Nr_Telefonit", true));
            this.nr_TelefonitTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nr_TelefonitTextBox.Location = new System.Drawing.Point(133, 441);
            this.nr_TelefonitTextBox.Name = "nr_TelefonitTextBox";
            this.nr_TelefonitTextBox.Size = new System.Drawing.Size(252, 20);
            this.nr_TelefonitTextBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Datababse_System_School.Properties.Resources.BGT_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(44, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tabelaDataGridView
            // 
            this.tabelaDataGridView.AutoGenerateColumns = false;
            this.tabelaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabelaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tabelaDataGridView.DataSource = this.tabelaBindingSource;
            this.tabelaDataGridView.Location = new System.Drawing.Point(520, 111);
            this.tabelaDataGridView.Name = "tabelaDataGridView";
            this.tabelaDataGridView.Size = new System.Drawing.Size(541, 501);
            this.tabelaDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmriPlot";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmriPlot";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Emaili";
            this.dataGridViewTextBoxColumn3.HeaderText = "Emaili";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nr_Telefonit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nr_Telefonit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabelaTableAdapter
            // 
            this.tabelaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabelaTableAdapter = this.tabelaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Datababse_System_School.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.ControlBox = false;
            this.Controls.Add(this.tabelaDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(emriPlotLabel);
            this.Controls.Add(this.emriPlotTextBox);
            this.Controls.Add(emailiLabel);
            this.Controls.Add(this.emailiTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(nr_TelefonitLabel);
            this.Controls.Add(this.nr_TelefonitTextBox);
            this.Controls.Add(this.tabelaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Databaza lokale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingNavigator)).EndInit();
            this.tabelaBindingNavigator.ResumeLayout(false);
            this.tabelaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tabelaBindingSource;
        private Database1DataSetTableAdapters.TabelaTableAdapter tabelaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabelaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox emriPlotTextBox;
        private System.Windows.Forms.TextBox emailiTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox nr_TelefonitTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tabelaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

