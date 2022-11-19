namespace PetAsService
{
    partial class Frm_Favorito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Favorito));
            this.lstFavorito = new System.Windows.Forms.ListBox();
            this.btnExcluirFavorito = new System.Windows.Forms.Button();
            this.lblTextoFavorito = new System.Windows.Forms.Label();
            this.lblDescFavoritos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirFavoritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picFavorito = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFavorito
            // 
            this.lstFavorito.FormattingEnabled = true;
            this.lstFavorito.ItemHeight = 15;
            this.lstFavorito.Location = new System.Drawing.Point(27, 98);
            this.lstFavorito.Name = "lstFavorito";
            this.lstFavorito.Size = new System.Drawing.Size(213, 274);
            this.lstFavorito.TabIndex = 0;
            this.lstFavorito.SelectedIndexChanged += new System.EventHandler(this.lstFavorito_SelectedIndexChanged);
            this.lstFavorito.DoubleClick += new System.EventHandler(this.lstFavorito_DoubleClick);
            // 
            // btnExcluirFavorito
            // 
            this.btnExcluirFavorito.Location = new System.Drawing.Point(290, 407);
            this.btnExcluirFavorito.Name = "btnExcluirFavorito";
            this.btnExcluirFavorito.Size = new System.Drawing.Size(109, 23);
            this.btnExcluirFavorito.TabIndex = 1;
            this.btnExcluirFavorito.Text = "Excluir Favorito";
            this.btnExcluirFavorito.UseVisualStyleBackColor = true;
            this.btnExcluirFavorito.Click += new System.EventHandler(this.btnExcluirFavorito_Click);
            // 
            // lblTextoFavorito
            // 
            this.lblTextoFavorito.AutoSize = true;
            this.lblTextoFavorito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextoFavorito.Location = new System.Drawing.Point(188, 30);
            this.lblTextoFavorito.Name = "lblTextoFavorito";
            this.lblTextoFavorito.Size = new System.Drawing.Size(52, 21);
            this.lblTextoFavorito.TabIndex = 2;
            this.lblTextoFavorito.Text = "label1";
            // 
            // lblDescFavoritos
            // 
            this.lblDescFavoritos.AutoSize = true;
            this.lblDescFavoritos.Location = new System.Drawing.Point(105, 57);
            this.lblDescFavoritos.Name = "lblDescFavoritos";
            this.lblDescFavoritos.Size = new System.Drawing.Size(38, 15);
            this.lblDescFavoritos.TabIndex = 3;
            this.lblDescFavoritos.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFavoritoToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirFavoritoToolStripMenuItem
            // 
            this.exibirFavoritoToolStripMenuItem.Name = "exibirFavoritoToolStripMenuItem";
            this.exibirFavoritoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.exibirFavoritoToolStripMenuItem.Text = "Exibir Favorito";
            this.exibirFavoritoToolStripMenuItem.Click += new System.EventHandler(this.exibirFavoritoToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encerrarToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            this.encerrarToolStripMenuItem.Click += new System.EventHandler(this.encerrarToolStripMenuItem_Click);
            // 
            // picFavorito
            // 
            this.picFavorito.Location = new System.Drawing.Point(273, 154);
            this.picFavorito.Name = "picFavorito";
            this.picFavorito.Size = new System.Drawing.Size(155, 134);
            this.picFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFavorito.TabIndex = 5;
            this.picFavorito.TabStop = false;
            // 
            // Frm_Favorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 445);
            this.Controls.Add(this.picFavorito);
            this.Controls.Add(this.lblDescFavoritos);
            this.Controls.Add(this.lblTextoFavorito);
            this.Controls.Add(this.btnExcluirFavorito);
            this.Controls.Add(this.lstFavorito);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Favorito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista dos Favoritos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstFavorito;
        private Button btnExcluirFavorito;
        private Label lblTextoFavorito;
        private Label lblDescFavoritos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exibirFavoritoToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private PictureBox picFavorito;
    }
}