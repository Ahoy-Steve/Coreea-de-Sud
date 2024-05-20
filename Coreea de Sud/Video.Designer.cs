
namespace Coreea_de_Sud
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.ListaFilme = new System.Windows.Forms.ListBox();
            this.cautaFisier = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(254, 12);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(1318, 837);
            this.wmp.TabIndex = 0;
            // 
            // ListaFilme
            // 
            this.ListaFilme.FormattingEnabled = true;
            this.ListaFilme.Location = new System.Drawing.Point(12, 12);
            this.ListaFilme.Name = "ListaFilme";
            this.ListaFilme.Size = new System.Drawing.Size(236, 784);
            this.ListaFilme.TabIndex = 1;
            this.ListaFilme.SelectedIndexChanged += new System.EventHandler(this.ListaFilme_SelectedIndexChanged);
            // 
            // cautaFisier
            // 
            this.cautaFisier.FileName = "openFileDialog1";
            this.cautaFisier.FileOk += new System.ComponentModel.CancelEventHandler(this.cautaFisier_FileOk);
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ListaFilme);
            this.Controls.Add(this.wmp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Video_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.ListBox ListaFilme;
        private System.Windows.Forms.OpenFileDialog cautaFisier;
    }
}