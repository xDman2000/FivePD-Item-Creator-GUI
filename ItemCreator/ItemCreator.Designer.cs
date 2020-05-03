namespace ItemCreator
{
    partial class ItemCreator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.rb_IllegalTrue = new System.Windows.Forms.RadioButton();
            this.rb_IllegalFalse = new System.Windows.Forms.RadioButton();
            this.lbl_Multiplier = new System.Windows.Forms.Label();
            this.num_Multiplier = new System.Windows.Forms.NumericUpDown();
            this.gb_IsIllegal = new System.Windows.Forms.GroupBox();
            this.cb_Occurance = new System.Windows.Forms.ComboBox();
            this.lbl_Occurance = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.illegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Multiplier)).BeginInit();
            this.gb_IsIllegal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.illegal,
            this.occurance,
            this.multiplier});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(180, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(381, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(15, 182);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(141, 23);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.Btn_AddItem_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(56, 13);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 19);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name:";
            // 
            // rb_IllegalTrue
            // 
            this.rb_IllegalTrue.AutoSize = true;
            this.rb_IllegalTrue.Checked = true;
            this.rb_IllegalTrue.Location = new System.Drawing.Point(6, 16);
            this.rb_IllegalTrue.Name = "rb_IllegalTrue";
            this.rb_IllegalTrue.Size = new System.Drawing.Size(47, 17);
            this.rb_IllegalTrue.TabIndex = 4;
            this.rb_IllegalTrue.TabStop = true;
            this.rb_IllegalTrue.Text = "True";
            this.rb_IllegalTrue.UseVisualStyleBackColor = true;
            // 
            // rb_IllegalFalse
            // 
            this.rb_IllegalFalse.AutoSize = true;
            this.rb_IllegalFalse.Location = new System.Drawing.Point(6, 39);
            this.rb_IllegalFalse.Name = "rb_IllegalFalse";
            this.rb_IllegalFalse.Size = new System.Drawing.Size(50, 17);
            this.rb_IllegalFalse.TabIndex = 5;
            this.rb_IllegalFalse.Text = "False";
            this.rb_IllegalFalse.UseVisualStyleBackColor = true;
            // 
            // lbl_Multiplier
            // 
            this.lbl_Multiplier.AutoSize = true;
            this.lbl_Multiplier.Location = new System.Drawing.Point(7, 108);
            this.lbl_Multiplier.Name = "lbl_Multiplier";
            this.lbl_Multiplier.Size = new System.Drawing.Size(51, 13);
            this.lbl_Multiplier.TabIndex = 8;
            this.lbl_Multiplier.Text = "Multiplier:";
            // 
            // num_Multiplier
            // 
            this.num_Multiplier.Location = new System.Drawing.Point(56, 106);
            this.num_Multiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Multiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Multiplier.Name = "num_Multiplier";
            this.num_Multiplier.Size = new System.Drawing.Size(50, 20);
            this.num_Multiplier.TabIndex = 9;
            this.num_Multiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gb_IsIllegal
            // 
            this.gb_IsIllegal.Controls.Add(this.rb_IllegalFalse);
            this.gb_IsIllegal.Controls.Add(this.rb_IllegalTrue);
            this.gb_IsIllegal.Location = new System.Drawing.Point(15, 39);
            this.gb_IsIllegal.Name = "gb_IsIllegal";
            this.gb_IsIllegal.Size = new System.Drawing.Size(62, 61);
            this.gb_IsIllegal.TabIndex = 10;
            this.gb_IsIllegal.TabStop = false;
            this.gb_IsIllegal.Text = "Illegal?";
            // 
            // cb_Occurance
            // 
            this.cb_Occurance.FormattingEnabled = true;
            this.cb_Occurance.Location = new System.Drawing.Point(15, 155);
            this.cb_Occurance.Name = "cb_Occurance";
            this.cb_Occurance.Size = new System.Drawing.Size(141, 21);
            this.cb_Occurance.TabIndex = 11;
            // 
            // lbl_Occurance
            // 
            this.lbl_Occurance.AutoSize = true;
            this.lbl_Occurance.Location = new System.Drawing.Point(12, 139);
            this.lbl_Occurance.Name = "lbl_Occurance";
            this.lbl_Occurance.Size = new System.Drawing.Size(156, 13);
            this.lbl_Occurance.TabIndex = 12;
            this.lbl_Occurance.Text = "Where should this item appear?";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // illegal
            // 
            this.illegal.HeaderText = "Illegal?";
            this.illegal.Name = "illegal";
            this.illegal.ReadOnly = true;
            this.illegal.Width = 60;
            // 
            // occurance
            // 
            this.occurance.HeaderText = "Occurance";
            this.occurance.Name = "occurance";
            this.occurance.ReadOnly = true;
            // 
            // multiplier
            // 
            this.multiplier.HeaderText = "Multiplier";
            this.multiplier.Name = "multiplier";
            this.multiplier.ReadOnly = true;
            this.multiplier.Width = 60;
            // 
            // ItemCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.lbl_Occurance);
            this.Controls.Add(this.cb_Occurance);
            this.Controls.Add(this.gb_IsIllegal);
            this.Controls.Add(this.num_Multiplier);
            this.Controls.Add(this.lbl_Multiplier);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ItemCreator";
            this.Text = "Item Creator";
            this.Load += new System.EventHandler(this.ItemCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Multiplier)).EndInit();
            this.gb_IsIllegal.ResumeLayout(false);
            this.gb_IsIllegal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.RadioButton rb_IllegalTrue;
        private System.Windows.Forms.RadioButton rb_IllegalFalse;
        private System.Windows.Forms.Label lbl_Multiplier;
        private System.Windows.Forms.NumericUpDown num_Multiplier;
        private System.Windows.Forms.GroupBox gb_IsIllegal;
        private System.Windows.Forms.ComboBox cb_Occurance;
        private System.Windows.Forms.Label lbl_Occurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn illegal;
        private System.Windows.Forms.DataGridViewTextBoxColumn occurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplier;
    }
}

