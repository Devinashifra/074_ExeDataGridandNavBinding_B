
namespace ExersiceDataBinding
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttondata = new System.Windows.Forms.Button();
            this.buttonbinding = new System.Windows.Forms.Button();
            this.picturehome = new System.Windows.Forms.PictureBox();
            this.picturedata = new System.Windows.Forms.PictureBox();
            this.picturebinding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturehome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebinding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(197, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(340, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            // 
            // buttondata
            // 
            this.buttondata.BackColor = System.Drawing.SystemColors.Control;
            this.buttondata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondata.Location = new System.Drawing.Point(115, 374);
            this.buttondata.Name = "buttondata";
            this.buttondata.Size = new System.Drawing.Size(137, 58);
            this.buttondata.TabIndex = 4;
            this.buttondata.Text = "DataGridView";
            this.buttondata.UseVisualStyleBackColor = false;
            this.buttondata.Click += new System.EventHandler(this.buttondata_Click);
            // 
            // buttonbinding
            // 
            this.buttonbinding.BackColor = System.Drawing.SystemColors.Control;
            this.buttonbinding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonbinding.Location = new System.Drawing.Point(361, 374);
            this.buttonbinding.Name = "buttonbinding";
            this.buttonbinding.Size = new System.Drawing.Size(198, 58);
            this.buttonbinding.TabIndex = 5;
            this.buttonbinding.Text = "Binding Navigation";
            this.buttonbinding.UseVisualStyleBackColor = false;
            this.buttonbinding.Click += new System.EventHandler(this.buttonbinding_Click);
            // 
            // picturehome
            // 
            this.picturehome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturehome.Image = ((System.Drawing.Image)(resources.GetObject("picturehome.Image")));
            this.picturehome.Location = new System.Drawing.Point(603, 438);
            this.picturehome.Name = "picturehome";
            this.picturehome.Size = new System.Drawing.Size(63, 62);
            this.picturehome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturehome.TabIndex = 9;
            this.picturehome.TabStop = false;
            this.picturehome.Click += new System.EventHandler(this.picturehome_Click);
            // 
            // picturedata
            // 
            this.picturedata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturedata.Image = ((System.Drawing.Image)(resources.GetObject("picturedata.Image")));
            this.picturedata.Location = new System.Drawing.Point(115, 162);
            this.picturedata.Name = "picturedata";
            this.picturedata.Size = new System.Drawing.Size(164, 174);
            this.picturedata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturedata.TabIndex = 10;
            this.picturedata.TabStop = false;
            this.picturedata.Click += new System.EventHandler(this.picturedata_Click);
            // 
            // picturebinding
            // 
            this.picturebinding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebinding.Image = ((System.Drawing.Image)(resources.GetObject("picturebinding.Image")));
            this.picturebinding.Location = new System.Drawing.Point(375, 162);
            this.picturebinding.Name = "picturebinding";
            this.picturebinding.Size = new System.Drawing.Size(164, 174);
            this.picturebinding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebinding.TabIndex = 11;
            this.picturebinding.TabStop = false;
            this.picturebinding.Click += new System.EventHandler(this.picturebinding_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(687, 512);
            this.Controls.Add(this.picturebinding);
            this.Controls.Add(this.picturedata);
            this.Controls.Add(this.picturehome);
            this.Controls.Add(this.buttonbinding);
            this.Controls.Add(this.buttondata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picturehome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttondata;
        private System.Windows.Forms.Button buttonbinding;
        private System.Windows.Forms.PictureBox picturehome;
        private System.Windows.Forms.PictureBox picturedata;
        private System.Windows.Forms.PictureBox picturebinding;
    }
}