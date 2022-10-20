namespace SimpleBlackjack
{
    partial class PlayerForm
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
            this.players_datagrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.deleteplayer_tab = new System.Windows.Forms.TabPage();
            this.updateplayer_tab = new System.Windows.Forms.TabPage();
            this.delete_lbl = new System.Windows.Forms.Label();
            this.delete_text = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.players_datagrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.deleteplayer_tab.SuspendLayout();
            this.updateplayer_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // players_datagrid
            // 
            this.players_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.players_datagrid.Location = new System.Drawing.Point(117, 50);
            this.players_datagrid.Name = "players_datagrid";
            this.players_datagrid.RowTemplate.Height = 25;
            this.players_datagrid.Size = new System.Drawing.Size(556, 209);
            this.players_datagrid.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.deleteplayer_tab);
            this.tabControl1.Controls.Add(this.updateplayer_tab);
            this.tabControl1.Location = new System.Drawing.Point(117, 287);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 145);
            this.tabControl1.TabIndex = 1;
            // 
            // deleteplayer_tab
            // 
            this.deleteplayer_tab.Controls.Add(this.delete_btn);
            this.deleteplayer_tab.Controls.Add(this.delete_text);
            this.deleteplayer_tab.Controls.Add(this.delete_lbl);
            this.deleteplayer_tab.Location = new System.Drawing.Point(4, 24);
            this.deleteplayer_tab.Name = "deleteplayer_tab";
            this.deleteplayer_tab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteplayer_tab.Size = new System.Drawing.Size(548, 117);
            this.deleteplayer_tab.TabIndex = 0;
            this.deleteplayer_tab.Text = "Delete";
            this.deleteplayer_tab.UseVisualStyleBackColor = true;
            // 
            // updateplayer_tab
            // 
            this.updateplayer_tab.Controls.Add(this.update_btn);
            this.updateplayer_tab.Controls.Add(this.textBox5);
            this.updateplayer_tab.Controls.Add(this.textBox4);
            this.updateplayer_tab.Controls.Add(this.textBox3);
            this.updateplayer_tab.Controls.Add(this.textBox2);
            this.updateplayer_tab.Controls.Add(this.textBox1);
            this.updateplayer_tab.Controls.Add(this.label5);
            this.updateplayer_tab.Controls.Add(this.label4);
            this.updateplayer_tab.Controls.Add(this.label3);
            this.updateplayer_tab.Controls.Add(this.label2);
            this.updateplayer_tab.Controls.Add(this.label1);
            this.updateplayer_tab.Location = new System.Drawing.Point(4, 24);
            this.updateplayer_tab.Name = "updateplayer_tab";
            this.updateplayer_tab.Padding = new System.Windows.Forms.Padding(3);
            this.updateplayer_tab.Size = new System.Drawing.Size(548, 117);
            this.updateplayer_tab.TabIndex = 1;
            this.updateplayer_tab.Text = "Update";
            this.updateplayer_tab.UseVisualStyleBackColor = true;
            // 
            // delete_lbl
            // 
            this.delete_lbl.AutoSize = true;
            this.delete_lbl.Location = new System.Drawing.Point(6, 13);
            this.delete_lbl.Name = "delete_lbl";
            this.delete_lbl.Size = new System.Drawing.Size(56, 15);
            this.delete_lbl.TabIndex = 0;
            this.delete_lbl.Text = "Player ID:";
            // 
            // delete_text
            // 
            this.delete_text.Location = new System.Drawing.Point(68, 10);
            this.delete_text.Name = "delete_text";
            this.delete_text.Size = new System.Drawing.Size(100, 23);
            this.delete_text.TabIndex = 1;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(32, 51);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "New name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "New score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "New address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "New email:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(308, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 9;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(287, 55);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 10;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.players_datagrid);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.players_datagrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.deleteplayer_tab.ResumeLayout(false);
            this.deleteplayer_tab.PerformLayout();
            this.updateplayer_tab.ResumeLayout(false);
            this.updateplayer_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView players_datagrid;
        private TabControl tabControl1;
        private TabPage deleteplayer_tab;
        private TextBox delete_text;
        private Label delete_lbl;
        private TabPage updateplayer_tab;
        private Button delete_btn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button update_btn;
    }
}