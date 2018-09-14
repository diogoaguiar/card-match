namespace dino
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lb_themes = new System.Windows.Forms.ListBox();
            this.b_play = new System.Windows.Forms.Button();
            this.b_new = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.pb_title = new System.Windows.Forms.PictureBox();
            this.cb_com_port = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_themes
            // 
            this.lb_themes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_themes.FormattingEnabled = true;
            this.lb_themes.Location = new System.Drawing.Point(12, 93);
            this.lb_themes.Name = "lb_themes";
            this.lb_themes.Size = new System.Drawing.Size(340, 264);
            this.lb_themes.TabIndex = 1;
            this.lb_themes.SelectedIndexChanged += new System.EventHandler(this.lb_themes_SelectedIndexChanged);
            // 
            // b_play
            // 
            this.b_play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_play.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.b_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_play.ForeColor = System.Drawing.Color.White;
            this.b_play.Location = new System.Drawing.Point(172, 409);
            this.b_play.Name = "b_play";
            this.b_play.Size = new System.Drawing.Size(180, 60);
            this.b_play.TabIndex = 2;
            this.b_play.Text = "Jogar";
            this.b_play.UseVisualStyleBackColor = false;
            this.b_play.Click += new System.EventHandler(this.b_play_Click);
            // 
            // b_new
            // 
            this.b_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_new.Location = new System.Drawing.Point(12, 372);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(75, 23);
            this.b_new.TabIndex = 3;
            this.b_new.Text = "Novo";
            this.b_new.UseVisualStyleBackColor = true;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // b_edit
            // 
            this.b_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_edit.Enabled = false;
            this.b_edit.Location = new System.Drawing.Point(93, 372);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(75, 23);
            this.b_edit.TabIndex = 4;
            this.b_edit.Text = "Editar";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_delete
            // 
            this.b_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_delete.Enabled = false;
            this.b_delete.Location = new System.Drawing.Point(277, 372);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 5;
            this.b_delete.Text = "Apagar";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // pb_title
            // 
            this.pb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_title.Image = global::dino.Properties.Resources.dino_title;
            this.pb_title.Location = new System.Drawing.Point(12, 12);
            this.pb_title.Name = "pb_title";
            this.pb_title.Size = new System.Drawing.Size(340, 75);
            this.pb_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_title.TabIndex = 0;
            this.pb_title.TabStop = false;
            // 
            // cb_com_port
            // 
            this.cb_com_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_com_port.FormattingEnabled = true;
            this.cb_com_port.Location = new System.Drawing.Point(12, 448);
            this.cb_com_port.Name = "cb_com_port";
            this.cb_com_port.Size = new System.Drawing.Size(85, 21);
            this.cb_com_port.TabIndex = 6;
            this.cb_com_port.DropDown += new System.EventHandler(this.cb_com_port_DropDown);
            this.cb_com_port.SelectedIndexChanged += new System.EventHandler(this.cb_com_port_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 481);
            this.Controls.Add(this.cb_com_port);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_new);
            this.Controls.Add(this.b_play);
            this.Controls.Add(this.lb_themes);
            this.Controls.Add(this.pb_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 720);
            this.MinimumSize = new System.Drawing.Size(380, 520);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[AppName]";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_title;
        private System.Windows.Forms.ListBox lb_themes;
        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.Button b_new;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.ComboBox cb_com_port;
    }
}

