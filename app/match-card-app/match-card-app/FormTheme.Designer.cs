namespace dino
{
    partial class FormTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheme));
            this.tb_theme_name = new System.Windows.Forms.TextBox();
            this.l_theme_name = new System.Windows.Forms.Label();
            this.b_new = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.lb_cards = new System.Windows.Forms.ListBox();
            this.gb_cards = new System.Windows.Forms.GroupBox();
            this.pb_image_preview = new System.Windows.Forms.PictureBox();
            this.b_save = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.gb_cards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_theme_name
            // 
            this.tb_theme_name.Location = new System.Drawing.Point(55, 12);
            this.tb_theme_name.Name = "tb_theme_name";
            this.tb_theme_name.Size = new System.Drawing.Size(210, 20);
            this.tb_theme_name.TabIndex = 0;
            // 
            // l_theme_name
            // 
            this.l_theme_name.AutoSize = true;
            this.l_theme_name.Location = new System.Drawing.Point(12, 15);
            this.l_theme_name.Name = "l_theme_name";
            this.l_theme_name.Size = new System.Drawing.Size(37, 13);
            this.l_theme_name.TabIndex = 1;
            this.l_theme_name.Text = "Tema:";
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
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // b_edit
            // 
            this.b_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_edit.Enabled = false;
            this.b_edit.Location = new System.Drawing.Point(87, 402);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(75, 23);
            this.b_edit.TabIndex = 5;
            this.b_edit.Text = "Editar";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_delete
            // 
            this.b_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_delete.Enabled = false;
            this.b_delete.Location = new System.Drawing.Point(169, 402);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 6;
            this.b_delete.Text = "Apagar";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
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
            this.lb_cards.SelectedIndexChanged += new System.EventHandler(this.lb_cards_SelectedIndexChanged);
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
            // pb_image_preview
            // 
            this.pb_image_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_image_preview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb_image_preview.Location = new System.Drawing.Point(271, 12);
            this.pb_image_preview.Name = "pb_image_preview";
            this.pb_image_preview.Size = new System.Drawing.Size(671, 413);
            this.pb_image_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image_preview.TabIndex = 5;
            this.pb_image_preview.TabStop = false;
            // 
            // b_save
            // 
            this.b_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_save.Enabled = false;
            this.b_save.Location = new System.Drawing.Point(867, 446);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 6;
            this.b_save.Text = "Guardar";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_card_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Enabled = false;
            this.b_cancel.Location = new System.Drawing.Point(786, 446);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 7;
            this.b_cancel.Text = "Cancelar";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_card_Click);
            // 
            // FormTheme
            // 
            this.AcceptButton = this.b_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(954, 481);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.pb_image_preview);
            this.Controls.Add(this.gb_cards);
            this.Controls.Add(this.l_theme_name);
            this.Controls.Add(this.tb_theme_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 520);
            this.Name = "FormTheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações do Tema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
            this.gb_cards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_theme_name;
        private System.Windows.Forms.Label l_theme_name;
        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.ListBox lb_cards;
        private System.Windows.Forms.GroupBox gb_cards;
        private System.Windows.Forms.PictureBox pb_image_preview;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_cancel;
    }
}