namespace Bicycles
{
    partial class bicyclesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bicyclesForm));
            this.bicycleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.bicycleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bicycleDataGridView = new System.Windows.Forms.DataGridView();
            this.bicycleTypeComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amortizationTypeComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bicycleTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amortizationTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amortizationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingNavigator)).BeginInit();
            this.bicycleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bicycleBindingNavigator
            // 
            this.bicycleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bicycleBindingNavigator.BindingSource = this.bicycleBindingSource;
            this.bicycleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bicycleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bicycleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bicycleBindingNavigatorSaveItem});
            this.bicycleBindingNavigator.Location = new System.Drawing.Point(8, 8);
            this.bicycleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bicycleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bicycleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bicycleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bicycleBindingNavigator.Name = "bicycleBindingNavigator";
            this.bicycleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bicycleBindingNavigator.Size = new System.Drawing.Size(631, 25);
            this.bicycleBindingNavigator.TabIndex = 2;
            this.bicycleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bicycleBindingNavigatorSaveItem
            // 
            this.bicycleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bicycleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bicycleBindingNavigatorSaveItem.Image")));
            this.bicycleBindingNavigatorSaveItem.Name = "bicycleBindingNavigatorSaveItem";
            this.bicycleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bicycleBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bicycleBindingNavigatorSaveItem.Click += new System.EventHandler(this.bicycleBindingNavigatorSaveItem_Click);
            // 
            // bicycleDataGridView
            // 
            this.bicycleDataGridView.AutoGenerateColumns = false;
            this.bicycleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bicycleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.priceColumn,
            this.bicycleTypeColumn,
            this.amortizationTypeColumn});
            this.bicycleDataGridView.DataSource = this.bicycleBindingSource;
            this.bicycleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bicycleDataGridView.Location = new System.Drawing.Point(8, 33);
            this.bicycleDataGridView.Name = "bicycleDataGridView";
            this.bicycleDataGridView.Size = new System.Drawing.Size(631, 295);
            this.bicycleDataGridView.TabIndex = 2;
            // 
            // bicycleTypeComboBox
            // 
            this.bicycleTypeComboBox.DataPropertyName = "BicycleType";
            this.bicycleTypeComboBox.HeaderText = "Тип";
            this.bicycleTypeComboBox.Name = "bicycleTypeComboBox";
            this.bicycleTypeComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bicycleTypeComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // amortizationTypeComboBox
            // 
            this.amortizationTypeComboBox.DataPropertyName = "AmortizationType";
            this.amortizationTypeComboBox.HeaderText = "Амортизация";
            this.amortizationTypeComboBox.Name = "amortizationTypeComboBox";
            this.amortizationTypeComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amortizationTypeComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bicycleTypeColumn
            // 
            this.bicycleTypeColumn.DataPropertyName = "BicycleTypeId";
            this.bicycleTypeColumn.DataSource = this.bicycleTypeBindingSource;
            this.bicycleTypeColumn.DisplayMember = "Name";
            this.bicycleTypeColumn.HeaderText = "Тип";
            this.bicycleTypeColumn.Name = "bicycleTypeColumn";
            this.bicycleTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bicycleTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bicycleTypeColumn.ValueMember = "Id";
            // 
            // amortizationTypeColumn
            // 
            this.amortizationTypeColumn.DataPropertyName = "AmortizationTypeId";
            this.amortizationTypeColumn.DataSource = this.amortizationTypeBindingSource;
            this.amortizationTypeColumn.DisplayMember = "Name";
            this.amortizationTypeColumn.HeaderText = "Амортизация";
            this.amortizationTypeColumn.Name = "amortizationTypeColumn";
            this.amortizationTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amortizationTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.amortizationTypeColumn.ValueMember = "Id";
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "Price";
            this.priceColumn.HeaderText = "Цена";
            this.priceColumn.Name = "priceColumn";
            // 
            // bicycleTypeBindingSource
            // 
            this.bicycleTypeBindingSource.DataSource = typeof(Bicycles.BicycleType);
            // 
            // amortizationTypeBindingSource
            // 
            this.amortizationTypeBindingSource.DataSource = typeof(Bicycles.AmortizationType);
            // 
            // bicycleBindingSource
            // 
            this.bicycleBindingSource.DataSource = typeof(Bicycles.Bicycle);
            // 
            // bicyclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 336);
            this.Controls.Add(this.bicycleDataGridView);
            this.Controls.Add(this.bicycleBindingNavigator);
            this.Name = "bicyclesForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог велосипедов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bicyclesForm_FormClosing);
            this.Load += new System.EventHandler(this.bicyclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingNavigator)).EndInit();
            this.bicycleBindingNavigator.ResumeLayout(false);
            this.bicycleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizationTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bicycleBindingSource;
        private System.Windows.Forms.BindingNavigator bicycleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bicycleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bicycleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amortizationColumn;
        private System.Windows.Forms.BindingSource bicycleTypeBindingSource;
        private System.Windows.Forms.BindingSource amortizationTypeBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn bicycleTypeComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn amortizationTypeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bicycleTypeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn amortizationTypeColumn;
    }
}

