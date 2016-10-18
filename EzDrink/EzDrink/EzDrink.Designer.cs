namespace EzDrink
{
    partial class EzDrink
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._drinkTabControl = new System.Windows.Forms.TabControl();
            this._orderSystem = new System.Windows.Forms.TabPage();
            this._ezDrinkTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._checkOutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._checkOutButton = new System.Windows.Forms.Button();
            this._totalPriceLabel = new System.Windows.Forms.Label();
            this._temperature = new System.Windows.Forms.GroupBox();
            this._temperatureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._noIce = new System.Windows.Forms.Button();
            this._normalIce = new System.Windows.Forms.Button();
            this._lessIce = new System.Windows.Forms.Button();
            this._hot = new System.Windows.Forms.Button();
            this._drinkItem = new System.Windows.Forms.GroupBox();
            this._drinkView = new System.Windows.Forms.DataGridView();
            this._drinkSelectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sugar = new System.Windows.Forms.GroupBox();
            this._sugarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._lessSugar = new System.Windows.Forms.Button();
            this._noSugar = new System.Windows.Forms.Button();
            this._normalSugar = new System.Windows.Forms.Button();
            this._halfSugar = new System.Windows.Forms.Button();
            this._ingredient = new System.Windows.Forms.GroupBox();
            this._drinkAdditionView = new System.Windows.Forms.DataGridView();
            this._additionButton = new DataGridViewDisableButtonColumn();
            this._additionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderList = new System.Windows.Forms.GroupBox();
            this._orderView = new System.Windows.Forms.DataGridView();
            this._orderDrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderAddition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this._menuStrip.SuspendLayout();
            this._drinkTabControl.SuspendLayout();
            this._orderSystem.SuspendLayout();
            this._ezDrinkTableLayoutPanel.SuspendLayout();
            this._checkOutTableLayoutPanel.SuspendLayout();
            this._temperature.SuspendLayout();
            this._temperatureTableLayoutPanel.SuspendLayout();
            this._drinkItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkView)).BeginInit();
            this._sugar.SuspendLayout();
            this._sugarTableLayoutPanel.SuspendLayout();
            this._ingredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionView)).BeginInit();
            this._orderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderView)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this._menuStrip.Size = new System.Drawing.Size(1326, 33);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            this._exitToolStripMenuItem.Text = "Exit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // _drinkTabControl
            // 
            this._drinkTabControl.Controls.Add(this._orderSystem);
            this._drinkTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this._drinkTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkTabControl.Location = new System.Drawing.Point(0, 33);
            this._drinkTabControl.Margin = new System.Windows.Forms.Padding(4);
            this._drinkTabControl.Name = "_drinkTabControl";
            this._drinkTabControl.SelectedIndex = 0;
            this._drinkTabControl.Size = new System.Drawing.Size(1326, 659);
            this._drinkTabControl.TabIndex = 1;
            // 
            // _orderSystem
            // 
            this._orderSystem.Controls.Add(this._ezDrinkTableLayoutPanel);
            this._orderSystem.Location = new System.Drawing.Point(4, 28);
            this._orderSystem.Margin = new System.Windows.Forms.Padding(4);
            this._orderSystem.Name = "_orderSystem";
            this._orderSystem.Padding = new System.Windows.Forms.Padding(4);
            this._orderSystem.Size = new System.Drawing.Size(1318, 627);
            this._orderSystem.TabIndex = 0;
            this._orderSystem.Text = "點餐系統";
            this._orderSystem.UseVisualStyleBackColor = true;
            // 
            // _ezDrinkTableLayoutPanel
            // 
            this._ezDrinkTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ezDrinkTableLayoutPanel.ColumnCount = 5;
            this._ezDrinkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this._ezDrinkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this._ezDrinkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._ezDrinkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this._ezDrinkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._ezDrinkTableLayoutPanel.Controls.Add(this._checkOutTableLayoutPanel, 4, 4);
            this._ezDrinkTableLayoutPanel.Controls.Add(this._temperature, 2, 3);
            this._ezDrinkTableLayoutPanel.Controls.Add(this._drinkItem, 0, 0);
            this._ezDrinkTableLayoutPanel.Controls.Add(this._sugar, 2, 1);
            this._ezDrinkTableLayoutPanel.Controls.Add(this._ingredient, 2, 0);
            this._ezDrinkTableLayoutPanel.Controls.Add(this._orderList, 4, 0);
            this._ezDrinkTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._ezDrinkTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this._ezDrinkTableLayoutPanel.Name = "_ezDrinkTableLayoutPanel";
            this._ezDrinkTableLayoutPanel.RowCount = 5;
            this._ezDrinkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._ezDrinkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._ezDrinkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._ezDrinkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._ezDrinkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._ezDrinkTableLayoutPanel.Size = new System.Drawing.Size(1314, 611);
            this._ezDrinkTableLayoutPanel.TabIndex = 2;
            // 
            // _checkOutTableLayoutPanel
            // 
            this._checkOutTableLayoutPanel.ColumnCount = 2;
            this._checkOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._checkOutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._checkOutTableLayoutPanel.Controls.Add(this._checkOutButton, 1, 0);
            this._checkOutTableLayoutPanel.Controls.Add(this._totalPriceLabel, 0, 0);
            this._checkOutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._checkOutTableLayoutPanel.Location = new System.Drawing.Point(791, 537);
            this._checkOutTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this._checkOutTableLayoutPanel.Name = "_checkOutTableLayoutPanel";
            this._checkOutTableLayoutPanel.RowCount = 1;
            this._checkOutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._checkOutTableLayoutPanel.Size = new System.Drawing.Size(519, 70);
            this._checkOutTableLayoutPanel.TabIndex = 1;
            // 
            // _checkOutButton
            // 
            this._checkOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._checkOutButton.Location = new System.Drawing.Point(381, 4);
            this._checkOutButton.Margin = new System.Windows.Forms.Padding(4);
            this._checkOutButton.Name = "_checkOutButton";
            this._checkOutButton.Size = new System.Drawing.Size(134, 62);
            this._checkOutButton.TabIndex = 1;
            this._checkOutButton.Text = "結帳";
            this._checkOutButton.UseVisualStyleBackColor = true;
            this._checkOutButton.Click += new System.EventHandler(this.ClickCheckOutButton);
            // 
            // _totalPriceLabel
            // 
            this._totalPriceLabel.AutoSize = true;
            this._totalPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._totalPriceLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._totalPriceLabel.Location = new System.Drawing.Point(4, 0);
            this._totalPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._totalPriceLabel.Name = "_totalPriceLabel";
            this._totalPriceLabel.Size = new System.Drawing.Size(355, 70);
            this._totalPriceLabel.TabIndex = 2;
            this._totalPriceLabel.Text = "總價：";
            this._totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _temperature
            // 
            this._temperature.Controls.Add(this._temperatureTableLayoutPanel);
            this._temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperature.Location = new System.Drawing.Point(384, 461);
            this._temperature.Margin = new System.Windows.Forms.Padding(4);
            this._temperature.Name = "_temperature";
            this._temperature.Padding = new System.Windows.Forms.Padding(4);
            this._ezDrinkTableLayoutPanel.SetRowSpan(this._temperature, 2);
            this._temperature.Size = new System.Drawing.Size(386, 146);
            this._temperature.TabIndex = 1;
            this._temperature.TabStop = false;
            this._temperature.Text = "溫度";
            // 
            // _temperatureTableLayoutPanel
            // 
            this._temperatureTableLayoutPanel.ColumnCount = 3;
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.909091F));
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.81818F));
            this._temperatureTableLayoutPanel.Controls.Add(this._noIce, 2, 2);
            this._temperatureTableLayoutPanel.Controls.Add(this._normalIce, 0, 0);
            this._temperatureTableLayoutPanel.Controls.Add(this._lessIce, 0, 2);
            this._temperatureTableLayoutPanel.Controls.Add(this._hot, 2, 0);
            this._temperatureTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperatureTableLayoutPanel.Location = new System.Drawing.Point(4, 26);
            this._temperatureTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this._temperatureTableLayoutPanel.Name = "_temperatureTableLayoutPanel";
            this._temperatureTableLayoutPanel.RowCount = 3;
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this._temperatureTableLayoutPanel.Size = new System.Drawing.Size(378, 116);
            this._temperatureTableLayoutPanel.TabIndex = 5;
            // 
            // _noIce
            // 
            this._noIce.Location = new System.Drawing.Point(205, 67);
            this._noIce.Margin = new System.Windows.Forms.Padding(4);
            this._noIce.Name = "_noIce";
            this._noIce.Size = new System.Drawing.Size(147, 39);
            this._noIce.TabIndex = 3;
            this._noIce.Text = "去冰";
            this._noIce.UseVisualStyleBackColor = true;
            this._noIce.Click += new System.EventHandler(this.ClickNoIce);
            // 
            // _normalIce
            // 
            this._normalIce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._normalIce.Location = new System.Drawing.Point(28, 10);
            this._normalIce.Margin = new System.Windows.Forms.Padding(4);
            this._normalIce.Name = "_normalIce";
            this._normalIce.Size = new System.Drawing.Size(147, 38);
            this._normalIce.TabIndex = 0;
            this._normalIce.Text = "正常";
            this._normalIce.UseVisualStyleBackColor = true;
            this._normalIce.Click += new System.EventHandler(this.ClickNormalIce);
            // 
            // _lessIce
            // 
            this._lessIce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lessIce.Location = new System.Drawing.Point(28, 67);
            this._lessIce.Margin = new System.Windows.Forms.Padding(4);
            this._lessIce.Name = "_lessIce";
            this._lessIce.Size = new System.Drawing.Size(147, 39);
            this._lessIce.TabIndex = 2;
            this._lessIce.Text = "少冰";
            this._lessIce.UseVisualStyleBackColor = true;
            this._lessIce.Click += new System.EventHandler(this.ClickLessIce);
            // 
            // _hot
            // 
            this._hot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._hot.Location = new System.Drawing.Point(205, 10);
            this._hot.Margin = new System.Windows.Forms.Padding(4);
            this._hot.Name = "_hot";
            this._hot.Size = new System.Drawing.Size(147, 38);
            this._hot.TabIndex = 1;
            this._hot.Text = "溫熱";
            this._hot.UseVisualStyleBackColor = true;
            this._hot.Click += new System.EventHandler(this.ClickHot);
            // 
            // _drinkItem
            // 
            this._drinkItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkItem.Controls.Add(this._drinkView);
            this._drinkItem.Location = new System.Drawing.Point(4, 4);
            this._drinkItem.Margin = new System.Windows.Forms.Padding(4);
            this._drinkItem.Name = "_drinkItem";
            this._drinkItem.Padding = new System.Windows.Forms.Padding(4);
            this._ezDrinkTableLayoutPanel.SetRowSpan(this._drinkItem, 5);
            this._drinkItem.Size = new System.Drawing.Size(359, 603);
            this._drinkItem.TabIndex = 0;
            this._drinkItem.TabStop = false;
            this._drinkItem.Text = "飲料";
            // 
            // _drinkView
            // 
            this._drinkView.AllowUserToAddRows = false;
            this._drinkView.AllowUserToDeleteRows = false;
            this._drinkView.AllowUserToResizeColumns = false;
            this._drinkView.AllowUserToResizeRows = false;
            this._drinkView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this._drinkView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkSelectButton,
            this._drinkName,
            this._drinkPrice});
            this._drinkView.Location = new System.Drawing.Point(3, 27);
            this._drinkView.Margin = new System.Windows.Forms.Padding(4);
            this._drinkView.Name = "_drinkView";
            this._drinkView.ReadOnly = true;
            this._drinkView.RowHeadersVisible = false;
            this._drinkView.RowTemplate.Height = 24;
            this._drinkView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._drinkView.Size = new System.Drawing.Size(351, 572);
            this._drinkView.TabIndex = 0;
            this._drinkView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkViewCellContent);
            // 
            // _drinkSelectButton
            // 
            this._drinkSelectButton.FillWeight = 40F;
            this._drinkSelectButton.HeaderText = "";
            this._drinkSelectButton.Name = "_drinkSelectButton";
            this._drinkSelectButton.ReadOnly = true;
            // 
            // _drinkName
            // 
            this._drinkName.FillWeight = 90F;
            this._drinkName.HeaderText = "名稱";
            this._drinkName.Name = "_drinkName";
            this._drinkName.ReadOnly = true;
            // 
            // _drinkPrice
            // 
            this._drinkPrice.FillWeight = 78F;
            this._drinkPrice.HeaderText = "價格";
            this._drinkPrice.Name = "_drinkPrice";
            this._drinkPrice.ReadOnly = true;
            // 
            // _sugar
            // 
            this._sugar.Controls.Add(this._sugarTableLayoutPanel);
            this._sugar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugar.Location = new System.Drawing.Point(384, 309);
            this._sugar.Margin = new System.Windows.Forms.Padding(4);
            this._sugar.Name = "_sugar";
            this._sugar.Padding = new System.Windows.Forms.Padding(4);
            this._ezDrinkTableLayoutPanel.SetRowSpan(this._sugar, 2);
            this._sugar.Size = new System.Drawing.Size(386, 144);
            this._sugar.TabIndex = 3;
            this._sugar.TabStop = false;
            this._sugar.Text = "甜度";
            // 
            // _sugarTableLayoutPanel
            // 
            this._sugarTableLayoutPanel.ColumnCount = 3;
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.909091F));
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.81818F));
            this._sugarTableLayoutPanel.Controls.Add(this._lessSugar, 0, 2);
            this._sugarTableLayoutPanel.Controls.Add(this._noSugar, 2, 2);
            this._sugarTableLayoutPanel.Controls.Add(this._normalSugar, 0, 0);
            this._sugarTableLayoutPanel.Controls.Add(this._halfSugar, 2, 0);
            this._sugarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarTableLayoutPanel.Location = new System.Drawing.Point(4, 26);
            this._sugarTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this._sugarTableLayoutPanel.Name = "_sugarTableLayoutPanel";
            this._sugarTableLayoutPanel.RowCount = 3;
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this._sugarTableLayoutPanel.Size = new System.Drawing.Size(378, 114);
            this._sugarTableLayoutPanel.TabIndex = 4;
            // 
            // _lessSugar
            // 
            this._lessSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lessSugar.Location = new System.Drawing.Point(28, 66);
            this._lessSugar.Margin = new System.Windows.Forms.Padding(4);
            this._lessSugar.Name = "_lessSugar";
            this._lessSugar.Size = new System.Drawing.Size(147, 38);
            this._lessSugar.TabIndex = 2;
            this._lessSugar.Text = "微糖";
            this._lessSugar.UseVisualStyleBackColor = true;
            this._lessSugar.Click += new System.EventHandler(this.ClickLessSugar);
            // 
            // _noSugar
            // 
            this._noSugar.Location = new System.Drawing.Point(205, 66);
            this._noSugar.Margin = new System.Windows.Forms.Padding(4);
            this._noSugar.Name = "_noSugar";
            this._noSugar.Size = new System.Drawing.Size(147, 38);
            this._noSugar.TabIndex = 3;
            this._noSugar.Text = "無糖";
            this._noSugar.UseVisualStyleBackColor = true;
            this._noSugar.Click += new System.EventHandler(this.ClickNoSugar);
            // 
            // _normalSugar
            // 
            this._normalSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._normalSugar.Location = new System.Drawing.Point(28, 13);
            this._normalSugar.Margin = new System.Windows.Forms.Padding(4);
            this._normalSugar.Name = "_normalSugar";
            this._normalSugar.Size = new System.Drawing.Size(147, 34);
            this._normalSugar.TabIndex = 0;
            this._normalSugar.Text = "正常";
            this._normalSugar.UseVisualStyleBackColor = true;
            this._normalSugar.Click += new System.EventHandler(this.ClickNormalSugar);
            // 
            // _halfSugar
            // 
            this._halfSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._halfSugar.Location = new System.Drawing.Point(205, 13);
            this._halfSugar.Margin = new System.Windows.Forms.Padding(4);
            this._halfSugar.Name = "_halfSugar";
            this._halfSugar.Size = new System.Drawing.Size(147, 34);
            this._halfSugar.TabIndex = 1;
            this._halfSugar.Text = "半糖";
            this._halfSugar.UseVisualStyleBackColor = true;
            this._halfSugar.Click += new System.EventHandler(this.ClickHalfSugar);
            // 
            // _ingredient
            // 
            this._ingredient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ingredient.Controls.Add(this._drinkAdditionView);
            this._ingredient.Location = new System.Drawing.Point(384, 4);
            this._ingredient.Margin = new System.Windows.Forms.Padding(4);
            this._ingredient.Name = "_ingredient";
            this._ingredient.Padding = new System.Windows.Forms.Padding(4);
            this._ingredient.Size = new System.Drawing.Size(386, 297);
            this._ingredient.TabIndex = 2;
            this._ingredient.TabStop = false;
            this._ingredient.Text = "加料";
            // 
            // _drinkAdditionView
            // 
            this._drinkAdditionView.AllowUserToAddRows = false;
            this._drinkAdditionView.AllowUserToDeleteRows = false;
            this._drinkAdditionView.AllowUserToResizeColumns = false;
            this._drinkAdditionView.AllowUserToResizeRows = false;
            this._drinkAdditionView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkAdditionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkAdditionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._additionButton,
            this._additionName,
            this._additionPrice});
            this._drinkAdditionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionView.Location = new System.Drawing.Point(4, 26);
            this._drinkAdditionView.Margin = new System.Windows.Forms.Padding(4);
            this._drinkAdditionView.Name = "_drinkAdditionView";
            this._drinkAdditionView.ReadOnly = true;
            this._drinkAdditionView.RowHeadersVisible = false;
            this._drinkAdditionView.RowTemplate.Height = 24;
            this._drinkAdditionView.Size = new System.Drawing.Size(378, 267);
            this._drinkAdditionView.TabIndex = 0;
            this._drinkAdditionView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkAdditionViewCellContent);
            // 
            // _additionButton
            // 
            this._additionButton.FillWeight = 53F;
            this._additionButton.HeaderText = "";
            this._additionButton.Name = "_additionButton";
            this._additionButton.ReadOnly = true;
            // 
            // _additionName
            // 
            this._additionName.HeaderText = "名稱";
            this._additionName.Name = "_additionName";
            this._additionName.ReadOnly = true;
            // 
            // _additionPrice
            // 
            this._additionPrice.FillWeight = 70F;
            this._additionPrice.HeaderText = "價格";
            this._additionPrice.Name = "_additionPrice";
            this._additionPrice.ReadOnly = true;
            // 
            // _orderList
            // 
            this._orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orderList.Controls.Add(this._orderView);
            this._orderList.Location = new System.Drawing.Point(791, 4);
            this._orderList.Margin = new System.Windows.Forms.Padding(4);
            this._orderList.Name = "_orderList";
            this._orderList.Padding = new System.Windows.Forms.Padding(4);
            this._ezDrinkTableLayoutPanel.SetRowSpan(this._orderList, 4);
            this._orderList.Size = new System.Drawing.Size(519, 525);
            this._orderList.TabIndex = 2;
            this._orderList.TabStop = false;
            this._orderList.Text = "點單";
            // 
            // _orderView
            // 
            this._orderView.AllowUserToAddRows = false;
            this._orderView.AllowUserToResizeColumns = false;
            this._orderView.AllowUserToResizeRows = false;
            this._orderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderDrinkName,
            this._orderPrice,
            this._orderSugar,
            this._orderTemperature,
            this._orderAddition,
            this._orderDelete});
            this._orderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderView.Location = new System.Drawing.Point(4, 26);
            this._orderView.Margin = new System.Windows.Forms.Padding(4);
            this._orderView.Name = "_orderView";
            this._orderView.ReadOnly = true;
            this._orderView.RowHeadersVisible = false;
            this._orderView.RowTemplate.Height = 24;
            this._orderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._orderView.Size = new System.Drawing.Size(511, 495);
            this._orderView.TabIndex = 0;
            this._orderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickOrderViewCellContent);
            this._orderView.Click += new System.EventHandler(this.ClickOrderView);
            // 
            // _orderDrinkName
            // 
            this._orderDrinkName.FillWeight = 60F;
            this._orderDrinkName.HeaderText = "飲料名稱";
            this._orderDrinkName.Name = "_orderDrinkName";
            this._orderDrinkName.ReadOnly = true;
            // 
            // _orderPrice
            // 
            this._orderPrice.FillWeight = 50F;
            this._orderPrice.HeaderText = "價格";
            this._orderPrice.Name = "_orderPrice";
            this._orderPrice.ReadOnly = true;
            // 
            // _orderSugar
            // 
            this._orderSugar.FillWeight = 50F;
            this._orderSugar.HeaderText = "甜度";
            this._orderSugar.Name = "_orderSugar";
            this._orderSugar.ReadOnly = true;
            // 
            // _orderTemperature
            // 
            this._orderTemperature.FillWeight = 50F;
            this._orderTemperature.HeaderText = "溫度";
            this._orderTemperature.Name = "_orderTemperature";
            this._orderTemperature.ReadOnly = true;
            // 
            // _orderAddition
            // 
            this._orderAddition.FillWeight = 60F;
            this._orderAddition.HeaderText = "加料";
            this._orderAddition.Name = "_orderAddition";
            this._orderAddition.ReadOnly = true;
            // 
            // _orderDelete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "刪除";
            this._orderDelete.DefaultCellStyle = dataGridViewCellStyle1;
            this._orderDelete.FillWeight = 46F;
            this._orderDelete.HeaderText = "";
            this._orderDelete.Name = "_orderDelete";
            this._orderDelete.ReadOnly = true;
            // 
            // EzDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 692);
            this.Controls.Add(this._drinkTabControl);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1339, 722);
            this.Name = "EzDrink";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "EzDrink";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._drinkTabControl.ResumeLayout(false);
            this._orderSystem.ResumeLayout(false);
            this._ezDrinkTableLayoutPanel.ResumeLayout(false);
            this._checkOutTableLayoutPanel.ResumeLayout(false);
            this._checkOutTableLayoutPanel.PerformLayout();
            this._temperature.ResumeLayout(false);
            this._temperatureTableLayoutPanel.ResumeLayout(false);
            this._drinkItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkView)).EndInit();
            this._sugar.ResumeLayout(false);
            this._sugarTableLayoutPanel.ResumeLayout(false);
            this._ingredient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionView)).EndInit();
            this._orderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.TabControl _drinkTabControl;
        private System.Windows.Forms.TabPage _orderSystem;
        private System.Windows.Forms.GroupBox _orderList;
        private System.Windows.Forms.DataGridView _orderView;
        private System.Windows.Forms.GroupBox _drinkItem;
        private System.Windows.Forms.DataGridView _drinkView;
        private System.Windows.Forms.GroupBox _temperature;
        private System.Windows.Forms.GroupBox _sugar;
        private System.Windows.Forms.GroupBox _ingredient;
        private System.Windows.Forms.DataGridView _drinkAdditionView;
        private System.Windows.Forms.Button _noIce;
        private System.Windows.Forms.Button _lessIce;
        private System.Windows.Forms.Button _hot;
        private System.Windows.Forms.Button _normalIce;
        private System.Windows.Forms.Button _noSugar;
        private System.Windows.Forms.Button _lessSugar;
        private System.Windows.Forms.Button _halfSugar;
        private System.Windows.Forms.Button _normalSugar;
        private System.Windows.Forms.TableLayoutPanel _ezDrinkTableLayoutPanel;
        private System.Windows.Forms.Button _checkOutButton;
        private System.Windows.Forms.TableLayoutPanel _temperatureTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _checkOutTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _sugarTableLayoutPanel;
        private System.Windows.Forms.Label _totalPriceLabel;
        private System.Windows.Forms.DataGridViewButtonColumn _drinkSelectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderDrinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderSugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderAddition;
        private System.Windows.Forms.DataGridViewButtonColumn _orderDelete;
        private DataGridViewDisableButtonColumn _additionButton;
    }
}

