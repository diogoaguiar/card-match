namespace dino
{
    partial class FormCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCard));
            this.l_name = new System.Windows.Forms.Label();
            this.l_tag = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_tag = new System.Windows.Forms.ComboBox();
            this.l_image = new System.Windows.Forms.Label();
            this.b_image = new System.Windows.Forms.Button();
            this.l_image_name = new System.Windows.Forms.Label();
            this.pb_image_preview = new System.Windows.Forms.PictureBox();
            this.b_save = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.ofd_image = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(12, 15);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(38, 13);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "Nome:";
            // 
            // l_tag
            // 
            this.l_tag.AutoSize = true;
            this.l_tag.Location = new System.Drawing.Point(12, 41);
            this.l_tag.Name = "l_tag";
            this.l_tag.Size = new System.Drawing.Size(29, 13);
            this.l_tag.TabIndex = 1;
            this.l_tag.Text = "Tag:";
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.Location = new System.Drawing.Point(101, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(197, 20);
            this.tb_name.TabIndex = 3;
            // 
            // cb_tag
            // 
            this.cb_tag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_tag.FormattingEnabled = true;
            this.cb_tag.Location = new System.Drawing.Point(101, 38);
            this.cb_tag.Name = "cb_tag";
            this.cb_tag.Size = new System.Drawing.Size(197, 21);
            this.cb_tag.TabIndex = 6;
            // 
            // l_image
            // 
            this.l_image.AutoSize = true;
            this.l_image.Location = new System.Drawing.Point(12, 70);
            this.l_image.Name = "l_image";
            this.l_image.Size = new System.Drawing.Size(47, 13);
            this.l_image.TabIndex = 7;
            this.l_image.Text = "Imagem:";
            // 
            // b_image
            // 
            this.b_image.Location = new System.Drawing.Point(101, 65);
            this.b_image.Name = "b_image";
            this.b_image.Size = new System.Drawing.Size(75, 23);
            this.b_image.TabIndex = 8;
            this.b_image.Text = "Escolher...";
            this.b_image.UseVisualStyleBackColor = true;
            this.b_image.Click += new System.EventHandler(this.b_image_Click);
            // 
            // l_image_name
            // 
            this.l_image_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_image_name.Location = new System.Drawing.Point(182, 70);
            this.l_image_name.Name = "l_image_name";
            this.l_image_name.Size = new System.Drawing.Size(116, 18);
            this.l_image_name.TabIndex = 9;
            // 
            // pb_image_preview
            // 
            this.pb_image_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_image_preview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb_image_preview.Location = new System.Drawing.Point(15, 94);
            this.pb_image_preview.Name = "pb_image_preview";
            this.pb_image_preview.Size = new System.Drawing.Size(283, 152);
            this.pb_image_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image_preview.TabIndex = 10;
            this.pb_image_preview.TabStop = false;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(227, 256);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 11;
            this.b_save.Text = "Guardar";
            this.b_save.UseVisualStyleBackColor = true;
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(146, 256);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 12;
            this.b_cancel.Text = "Cancelar";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // ofd_image
            // 
            this.ofd_image.Filter = "Images | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            // 
            // FormCard
            // 
            this.AcceptButton = this.b_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.pb_image_preview);
            this.Controls.Add(this.l_image_name);
            this.Controls.Add(this.b_image);
            this.Controls.Add(this.l_image);
            this.Controls.Add(this.cb_tag);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.l_tag);
            this.Controls.Add(this.l_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "FormCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações do Cartão";
            this.Load += new System.EventHandler(this.FormCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_tag;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_tag;
        private System.Windows.Forms.Label l_image;
        private System.Windows.Forms.Button b_image;
        private System.Windows.Forms.Label l_image_name;
        private System.Windows.Forms.PictureBox pb_image_preview;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.OpenFileDialog ofd_image;
    }
}