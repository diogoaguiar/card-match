namespace dino
{
    partial class FormThemeSet
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
            this.tb_category_name = new System.Windows.Forms.TextBox();
            this.l_theme_name = new System.Windows.Forms.Label();
            this.b_new = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.lb_cards = new System.Windows.Forms.ListBox();
            this.gb_cards = new System.Windows.Forms.GroupBox();
            this.panel_set_category = new System.Windows.Forms.Panel();
            this.l_card_number = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.b_image = new System.Windows.Forms.Button();
            this.l_image_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_save = new System.Windows.Forms.Button();
            this.gb_cards.SuspendLayout();
            this.panel_set_category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_category_name
            // 
            this.tb_category_name.Location = new System.Drawing.Point(52, 12);
            this.tb_category_name.Name = "tb_category_name";
            this.tb_category_name.Size = new System.Drawing.Size(213, 20);
            this.tb_category_name.TabIndex = 0;
            // 
            // l_theme_name
            // 
            this.l_theme_name.AutoSize = true;
            this.l_theme_name.Location = new System.Drawing.Point(12, 15);
            this.l_theme_name.Name = "l_theme_name";
            this.l_theme_name.Size = new System.Drawing.Size(34, 13);
            this.l_theme_name.TabIndex = 1;
            this.l_theme_name.Text = "Tema";
            // 
            // b_new
            // 
            this.b_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_new.Location = new System.Drawing.Point(6, 402);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(75, 23);
            this.b_new.TabIndex = 4;
            this.b_new.Text = "Novo";
            this.b_new.UseVisualStyleBackColor = true;
            // 
            // b_edit
            // 
            this.b_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_edit.Location = new System.Drawing.Point(87, 402);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(75, 23);
            this.b_edit.TabIndex = 5;
            this.b_edit.Text = "Editar";
            this.b_edit.UseVisualStyleBackColor = true;
            // 
            // b_delete
            // 
            this.b_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_delete.Location = new System.Drawing.Point(169, 402);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 6;
            this.b_delete.Text = "Apagar";
            this.b_delete.UseVisualStyleBackColor = true;
            // 
            // lb_cards
            // 
            this.lb_cards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_cards.FormattingEnabled = true;
            this.lb_cards.Location = new System.Drawing.Point(6, 19);
            this.lb_cards.Name = "lb_cards";
            this.lb_cards.Size = new System.Drawing.Size(238, 368);
            this.lb_cards.TabIndex = 5;
            // 
            // gb_cards
            // 
            this.gb_cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_cards.Controls.Add(this.b_delete);
            this.gb_cards.Controls.Add(this.lb_cards);
            this.gb_cards.Controls.Add(this.b_edit);
            this.gb_cards.Controls.Add(this.b_new);
            this.gb_cards.Location = new System.Drawing.Point(15, 38);
            this.gb_cards.Name = "gb_cards";
            this.gb_cards.Size = new System.Drawing.Size(250, 431);
            this.gb_cards.TabIndex = 5;
            this.gb_cards.TabStop = false;
            this.gb_cards.Text = "Cartões";
            // 
            // panel_set_category
            // 
            this.panel_set_category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set_category.Controls.Add(this.b_save);
            this.panel_set_category.Controls.Add(this.pictureBox1);
            this.panel_set_category.Controls.Add(this.l_image_name);
            this.panel_set_category.Controls.Add(this.b_image);
            this.panel_set_category.Controls.Add(this.comboBox1);
            this.panel_set_category.Controls.Add(this.l_card_number);
            this.panel_set_category.Location = new System.Drawing.Point(271, 12);
            this.panel_set_category.Name = "panel_set_category";
            this.panel_set_category.Size = new System.Drawing.Size(671, 457);
            this.panel_set_category.TabIndex = 6;
            // 
            // l_card_number
            // 
            this.l_card_number.AutoSize = true;
            this.l_card_number.Location = new System.Drawing.Point(3, 7);
            this.l_card_number.Name = "l_card_number";
            this.l_card_number.Size = new System.Drawing.Size(38, 13);
            this.l_card_number.TabIndex = 0;
            this.l_card_number.Text = "Cartão";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // b_image
            // 
            this.b_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_image.Location = new System.Drawing.Point(593, 2);
            this.b_image.Name = "b_image";
            this.b_image.Size = new System.Drawing.Size(75, 23);
            this.b_image.TabIndex = 3;
            this.b_image.Text = "Imagem ...";
            this.b_image.UseVisualStyleBackColor = true;
            // 
            // l_image_name
            // 
            this.l_image_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_image_name.Location = new System.Drawing.Point(305, 7);
            this.l_image_name.Name = "l_image_name";
            this.l_image_name.Size = new System.Drawing.Size(282, 18);
            this.l_image_name.TabIndex = 4;
            this.l_image_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 390);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // b_save
            // 
            this.b_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_save.Location = new System.Drawing.Point(593, 428);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 6;
            this.b_save.Text = "Guardar";
            this.b_save.UseVisualStyleBackColor = true;
            // 
            // FormThemeSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 481);
            this.Controls.Add(this.panel_set_category);
            this.Controls.Add(this.gb_cards);
            this.Controls.Add(this.l_theme_name);
            this.Controls.Add(this.tb_category_name);
            this.MinimumSize = new System.Drawing.Size(970, 520);
            this.Name = "FormThemeSet";
            this.Text = "[Category]";
            this.gb_cards.ResumeLayout(false);
            this.panel_set_category.ResumeLayout(false);
            this.panel_set_category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_category_name;
        private System.Windows.Forms.Label l_theme_name;
        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.ListBox lb_cards;
        private System.Windows.Forms.GroupBox gb_cards;
        private System.Windows.Forms.Panel panel_set_category;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_image_name;
        private System.Windows.Forms.Button b_image;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label l_card_number;
    }
}