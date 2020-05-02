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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.illegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.rb_True = new System.Windows.Forms.RadioButton();
            this.rb_False = new System.Windows.Forms.RadioButton();
            this.lbl_Multiplier = new System.Windows.Forms.Label();
            this.num_Multiplier = new System.Windows.Forms.NumericUpDown();
            this.gb_Illegal = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Multiplier)).BeginInit();
            this.gb_Illegal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.illegal,
            this.multiplier});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(170, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(281, 450);
            this.dataGridView1.TabIndex = 0;
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
            // multiplier
            // 
            this.multiplier.HeaderText = "Multiplier";
            this.multiplier.Name = "multiplier";
            this.multiplier.ReadOnly = true;
            this.multiplier.Width = 60;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(15, 132);
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
            // rb_True
            // 
            this.rb_True.AutoSize = true;
            this.rb_True.Checked = true;
            this.rb_True.Location = new System.Drawing.Point(6, 16);
            this.rb_True.Name = "rb_True";
            this.rb_True.Size = new System.Drawing.Size(47, 17);
            this.rb_True.TabIndex = 4;
            this.rb_True.TabStop = true;
            this.rb_True.Text = "True";
            this.rb_True.UseVisualStyleBackColor = true;
            // 
            // rb_False
            // 
            this.rb_False.AutoSize = true;
            this.rb_False.Location = new System.Drawing.Point(6, 39);
            this.rb_False.Name = "rb_False";
            this.rb_False.Size = new System.Drawing.Size(50, 17);
            this.rb_False.TabIndex = 5;
            this.rb_False.Text = "False";
            this.rb_False.UseVisualStyleBackColor = true;
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
            // gb_Illegal
            // 
            this.gb_Illegal.Controls.Add(this.rb_False);
            this.gb_Illegal.Controls.Add(this.rb_True);
            this.gb_Illegal.Location = new System.Drawing.Point(15, 39);
            this.gb_Illegal.Name = "gb_Illegal";
            this.gb_Illegal.Size = new System.Drawing.Size(62, 61);
            this.gb_Illegal.TabIndex = 10;
            this.gb_Illegal.TabStop = false;
            this.gb_Illegal.Text = "Illegal?";
            // 
            // ItemCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.gb_Illegal);
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
            this.gb_Illegal.ResumeLayout(false);
            this.gb_Illegal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn illegal;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplier;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.RadioButton rb_True;
        private System.Windows.Forms.RadioButton rb_False;
        private System.Windows.Forms.Label lbl_Multiplier;
        private System.Windows.Forms.NumericUpDown num_Multiplier;
        private System.Windows.Forms.GroupBox gb_Illegal;
    }
}

