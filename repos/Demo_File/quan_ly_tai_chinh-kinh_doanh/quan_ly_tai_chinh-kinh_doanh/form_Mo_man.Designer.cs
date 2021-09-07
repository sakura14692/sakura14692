
namespace quan_ly_tai_chinh_kinh_doanh
{
    partial class form_Mo_man
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
            this.components = new System.ComponentModel.Container();
            this.labelControl_Dem_thoi_gian = new DevExpress.XtraEditors.LabelControl();
            this.timer_form_Mo_man = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl_Gioi_thieu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl_Dem_thoi_gian
            // 
            this.labelControl_Dem_thoi_gian.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Dem_thoi_gian.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelControl_Dem_thoi_gian.Appearance.Options.UseFont = true;
            this.labelControl_Dem_thoi_gian.Appearance.Options.UseForeColor = true;
            this.labelControl_Dem_thoi_gian.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_Dem_thoi_gian.Location = new System.Drawing.Point(789, 668);
            this.labelControl_Dem_thoi_gian.Name = "labelControl_Dem_thoi_gian";
            this.labelControl_Dem_thoi_gian.Size = new System.Drawing.Size(188, 29);
            this.labelControl_Dem_thoi_gian.TabIndex = 0;
            this.labelControl_Dem_thoi_gian.Text = "00";
            // 
            // timer_form_Mo_man
            // 
            this.timer_form_Mo_man.Interval = 300;
            this.timer_form_Mo_man.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::quan_ly_tai_chinh_kinh_doanh.Properties.Resources.logo4;
            this.pictureBox1.Location = new System.Drawing.Point(789, 492);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl_Gioi_thieu
            // 
            this.labelControl_Gioi_thieu.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Gioi_thieu.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.labelControl_Gioi_thieu.Appearance.Options.UseFont = true;
            this.labelControl_Gioi_thieu.Appearance.Options.UseForeColor = true;
            this.labelControl_Gioi_thieu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_Gioi_thieu.LineVisible = true;
            this.labelControl_Gioi_thieu.Location = new System.Drawing.Point(15, 43);
            this.labelControl_Gioi_thieu.Name = "labelControl_Gioi_thieu";
            this.labelControl_Gioi_thieu.Size = new System.Drawing.Size(962, 60);
            this.labelControl_Gioi_thieu.TabIndex = 2;
            // 
            // form_Mo_man
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = global::quan_ly_tai_chinh_kinh_doanh.Properties.Resources.planet_space_and_stars;
            this.ClientSize = new System.Drawing.Size(1002, 701);
            this.Controls.Add(this.labelControl_Gioi_thieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl_Dem_thoi_gian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Mo_man";
            this.Text = "form_Mo_man";
            this.Load += new System.EventHandler(this.form_Mo_man_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl_Dem_thoi_gian;
        private System.Windows.Forms.Timer timer_form_Mo_man;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl_Gioi_thieu;
    }
}