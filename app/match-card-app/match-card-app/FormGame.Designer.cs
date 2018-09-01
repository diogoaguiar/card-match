namespace dino
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_screen = new System.Windows.Forms.PictureBox();
            this.pb_dino = new System.Windows.Forms.PictureBox();
            this.tlp_holder = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_dino_result = new System.Windows.Forms.TableLayoutPanel();
            this.pb_result = new System.Windows.Forms.PictureBox();
            this.b_certo = new System.Windows.Forms.Button();
            this.b_errado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dino)).BeginInit();
            this.tlp_holder.SuspendLayout();
            this.tlp_dino_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close.BackColor = System.Drawing.Color.Transparent;
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(603, 12);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // pb_screen
            // 
            this.pb_screen.BackColor = System.Drawing.Color.Transparent;
            this.pb_screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_screen.Location = new System.Drawing.Point(157, 10);
            this.pb_screen.Margin = new System.Windows.Forms.Padding(10);
            this.pb_screen.Name = "pb_screen";
            this.pb_screen.Size = new System.Drawing.Size(449, 285);
            this.pb_screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_screen.TabIndex = 1;
            this.pb_screen.TabStop = false;
            // 
            // pb_dino
            // 
            this.pb_dino.BackColor = System.Drawing.Color.Transparent;
            this.pb_dino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_dino.Image = global::dino.Properties.Resources.dino_no_background;
            this.pb_dino.Location = new System.Drawing.Point(10, 103);
            this.pb_dino.Margin = new System.Windows.Forms.Padding(10);
            this.pb_dino.Name = "pb_dino";
            this.pb_dino.Size = new System.Drawing.Size(121, 186);
            this.pb_dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_dino.TabIndex = 2;
            this.pb_dino.TabStop = false;
            // 
            // tlp_holder
            // 
            this.tlp_holder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_holder.BackColor = System.Drawing.Color.Transparent;
            this.tlp_holder.ColumnCount = 2;
            this.tlp_holder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.86364F));
            this.tlp_holder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.13636F));
            this.tlp_holder.Controls.Add(this.tlp_dino_result, 0, 0);
            this.tlp_holder.Controls.Add(this.pb_screen, 1, 0);
            this.tlp_holder.Location = new System.Drawing.Point(12, 43);
            this.tlp_holder.Name = "tlp_holder";
            this.tlp_holder.RowCount = 1;
            this.tlp_holder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_holder.Size = new System.Drawing.Size(616, 305);
            this.tlp_holder.TabIndex = 3;
            // 
            // tlp_dino_result
            // 
            this.tlp_dino_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_dino_result.ColumnCount = 1;
            this.tlp_dino_result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_dino_result.Controls.Add(this.pb_dino, 0, 1);
            this.tlp_dino_result.Controls.Add(this.pb_result, 0, 0);
            this.tlp_dino_result.Location = new System.Drawing.Point(3, 3);
            this.tlp_dino_result.Name = "tlp_dino_result";
            this.tlp_dino_result.RowCount = 2;
            this.tlp_dino_result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.10368F));
            this.tlp_dino_result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.89632F));
            this.tlp_dino_result.Size = new System.Drawing.Size(141, 299);
            this.tlp_dino_result.TabIndex = 8;
            // 
            // pb_result
            // 
            this.pb_result.BackColor = System.Drawing.Color.Transparent;
            this.pb_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_result.Image = global::dino.Properties.Resources.wrong1;
            this.pb_result.Location = new System.Drawing.Point(3, 3);
            this.pb_result.Name = "pb_result";
            this.pb_result.Size = new System.Drawing.Size(135, 87);
            this.pb_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_result.TabIndex = 5;
            this.pb_result.TabStop = false;
            this.pb_result.Visible = false;
            // 
            // b_certo
            // 
            this.b_certo.Location = new System.Drawing.Point(12, 12);
            this.b_certo.Name = "b_certo";
            this.b_certo.Size = new System.Drawing.Size(75, 23);
            this.b_certo.TabIndex = 6;
            this.b_certo.Text = "Certo";
            this.b_certo.UseVisualStyleBackColor = true;
            this.b_certo.Click += new System.EventHandler(this.b_certo_Click);
            // 
            // b_errado
            // 
            this.b_errado.Location = new System.Drawing.Point(93, 12);
            this.b_errado.Name = "b_errado";
            this.b_errado.Size = new System.Drawing.Size(75, 23);
            this.b_errado.TabIndex = 7;
            this.b_errado.Text = "Errado";
            this.b_errado.UseVisualStyleBackColor = true;
            this.b_errado.Click += new System.EventHandler(this.b_errado_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.ControlBox = false;
            this.Controls.Add(this.b_errado);
            this.Controls.Add(this.b_certo);
            this.Controls.Add(this.tlp_holder);
            this.Controls.Add(this.pb_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dino)).EndInit();
            this.tlp_holder.ResumeLayout(false);
            this.tlp_dino_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_screen;
        private System.Windows.Forms.PictureBox pb_dino;
        private System.Windows.Forms.TableLayoutPanel tlp_holder;
        private System.Windows.Forms.PictureBox pb_result;
        private System.Windows.Forms.Button b_certo;
        private System.Windows.Forms.Button b_errado;
        private System.Windows.Forms.TableLayoutPanel tlp_dino_result;
    }
}