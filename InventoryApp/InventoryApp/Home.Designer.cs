namespace InventoryApp
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manGrid = new System.Windows.Forms.DataGridView();
            this.mID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinView = new System.Windows.Forms.DataGridView();
            this.prodIDJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodTypeJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodModelJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manIDJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mStateJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCategoryJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 100);
            this.panel1.TabIndex = 66;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(603, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Home";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(152)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(1298, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(436, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.No;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.button4.Location = new System.Drawing.Point(350, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(331, 230);
            this.button4.TabIndex = 64;
            this.button4.Text = "Products";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.button3.Location = new System.Drawing.Point(350, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 230);
            this.button3.TabIndex = 63;
            this.button3.Text = "Orders";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.button1.Location = new System.Drawing.Point(30, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 230);
            this.button1.TabIndex = 61;
            this.button1.Text = "Payments";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.button2.Location = new System.Drawing.Point(30, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 230);
            this.button2.TabIndex = 62;
            this.button2.Text = "Manufacturers";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productGrid
            // 
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodID,
            this.prodType,
            this.prodModel,
            this.prodPrice,
            this.manID});
            this.productGrid.Location = new System.Drawing.Point(739, 329);
            this.productGrid.Name = "productGrid";
            this.productGrid.Size = new System.Drawing.Size(538, 153);
            this.productGrid.TabIndex = 67;
            this.productGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodID
            // 
            this.prodID.HeaderText = "Product ID";
            this.prodID.Name = "prodID";
            // 
            // prodType
            // 
            this.prodType.HeaderText = "Product Type";
            this.prodType.Name = "prodType";
            // 
            // prodModel
            // 
            this.prodModel.HeaderText = "Product Model";
            this.prodModel.Name = "prodModel";
            // 
            // prodPrice
            // 
            this.prodPrice.HeaderText = "Product Price";
            this.prodPrice.Name = "prodPrice";
            // 
            // manID
            // 
            this.manID.HeaderText = "Manufacturer ID";
            this.manID.Name = "manID";
            // 
            // manGrid
            // 
            this.manGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mID,
            this.mName,
            this.mState,
            this.mCategory});
            this.manGrid.Location = new System.Drawing.Point(791, 488);
            this.manGrid.Name = "manGrid";
            this.manGrid.Size = new System.Drawing.Size(443, 120);
            this.manGrid.TabIndex = 68;
            // 
            // mID
            // 
            this.mID.HeaderText = "Manufacturer ID";
            this.mID.Name = "mID";
            // 
            // mName
            // 
            this.mName.HeaderText = "Manufacturer Name";
            this.mName.Name = "mName";
            // 
            // mState
            // 
            this.mState.HeaderText = "Manufacturer State";
            this.mState.Name = "mState";
            // 
            // mCategory
            // 
            this.mCategory.HeaderText = "Manufacturer Category";
            this.mCategory.Name = "mCategory";
            // 
            // joinView
            // 
            this.joinView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDJoin,
            this.prodTypeJoin,
            this.prodModelJoin,
            this.prodPriceJoin,
            this.manIDJoin,
            this.mIDJoin,
            this.mNameJoin,
            this.mStateJoin,
            this.mCategoryJoin});
            this.joinView.Location = new System.Drawing.Point(739, 173);
            this.joinView.Name = "joinView";
            this.joinView.Size = new System.Drawing.Size(538, 150);
            this.joinView.TabIndex = 69;
            this.joinView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // prodIDJoin
            // 
            this.prodIDJoin.HeaderText = "Product ID";
            this.prodIDJoin.Name = "prodIDJoin";
            // 
            // prodTypeJoin
            // 
            this.prodTypeJoin.HeaderText = "Type";
            this.prodTypeJoin.Name = "prodTypeJoin";
            // 
            // prodModelJoin
            // 
            this.prodModelJoin.HeaderText = "Model";
            this.prodModelJoin.Name = "prodModelJoin";
            // 
            // prodPriceJoin
            // 
            this.prodPriceJoin.HeaderText = "Price";
            this.prodPriceJoin.Name = "prodPriceJoin";
            // 
            // manIDJoin
            // 
            this.manIDJoin.HeaderText = "Man ID";
            this.manIDJoin.Name = "manIDJoin";
            // 
            // mIDJoin
            // 
            this.mIDJoin.HeaderText = "Manufacturer ID";
            this.mIDJoin.Name = "mIDJoin";
            // 
            // mNameJoin
            // 
            this.mNameJoin.HeaderText = "Manufacturer";
            this.mNameJoin.Name = "mNameJoin";
            // 
            // mStateJoin
            // 
            this.mStateJoin.HeaderText = "State";
            this.mStateJoin.Name = "mStateJoin";
            // 
            // mCategoryJoin
            // 
            this.mCategoryJoin.HeaderText = "Category";
            this.mCategoryJoin.Name = "mCategoryJoin";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(942, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 42);
            this.button5.TabIndex = 70;
            this.button5.Text = "Inner Join Product and Manufacturer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1329, 631);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.joinView);
            this.Controls.Add(this.manGrid);
            this.Controls.Add(this.productGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn manID;
        private System.Windows.Forms.DataGridView manGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mState;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCategory;
        private System.Windows.Forms.DataGridView joinView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodTypeJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodModelJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn manIDJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStateJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCategoryJoin;
    }
}