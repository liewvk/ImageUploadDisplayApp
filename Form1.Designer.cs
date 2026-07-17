namespace ImageUploadDisplayApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblImageId = new System.Windows.Forms.Label();
            this.txtImageId = new System.Windows.Forms.TextBox();
            this.lblImageTitle = new System.Windows.Forms.Label();
            this.txtImageTitle = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.grpImageControlCenter = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.grpImageControlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(212, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(424, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Image Upload and Display App";
            // 
            // lblImageId
            // 
            this.lblImageId.AutoSize = true;
            this.lblImageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageId.Location = new System.Drawing.Point(32, 71);
            this.lblImageId.Name = "lblImageId";
            this.lblImageId.Size = new System.Drawing.Size(85, 22);
            this.lblImageId.TabIndex = 1;
            this.lblImageId.Text = "Image ID:";
            // 
            // txtImageId
            // 
            this.txtImageId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageId.Location = new System.Drawing.Point(119, 69);
            this.txtImageId.Name = "txtImageId";
            this.txtImageId.Size = new System.Drawing.Size(129, 28);
            this.txtImageId.TabIndex = 2;
            // 
            // lblImageTitle
            // 
            this.lblImageTitle.AutoSize = true;
            this.lblImageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageTitle.Location = new System.Drawing.Point(14, 117);
            this.lblImageTitle.Name = "lblImageTitle";
            this.lblImageTitle.Size = new System.Drawing.Size(103, 22);
            this.lblImageTitle.TabIndex = 1;
            this.lblImageTitle.Text = "Image Title:";
            // 
            // txtImageTitle
            // 
            this.txtImageTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageTitle.Location = new System.Drawing.Point(123, 115);
            this.txtImageTitle.Name = "txtImageTitle";
            this.txtImageTitle.Size = new System.Drawing.Size(129, 28);
            this.txtImageTitle.TabIndex = 2;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagePath.Location = new System.Drawing.Point(268, 77);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(105, 22);
            this.lblImagePath.TabIndex = 1;
            this.lblImagePath.Text = "Image Path:";
            // 
            // txtImagePath
            // 
            this.txtImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagePath.Location = new System.Drawing.Point(379, 71);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(500, 28);
            this.txtImagePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(272, 111);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(144, 35);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(517, 111);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(300, 250);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // grpImageControlCenter
            // 
            this.grpImageControlCenter.Controls.Add(this.btnClearAll);
            this.grpImageControlCenter.Controls.Add(this.btnClearInput);
            this.grpImageControlCenter.Controls.Add(this.btnDelete);
            this.grpImageControlCenter.Controls.Add(this.btnAdd);
            this.grpImageControlCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpImageControlCenter.Location = new System.Drawing.Point(135, 168);
            this.grpImageControlCenter.Name = "grpImageControlCenter";
            this.grpImageControlCenter.Size = new System.Drawing.Size(339, 144);
            this.grpImageControlCenter.TabIndex = 5;
            this.grpImageControlCenter.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(145, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(6, 77);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(133, 44);
            this.btnClearInput.TabIndex = 2;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(145, 77);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(158, 43);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(779, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvImages
            // 
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImages.Location = new System.Drawing.Point(24, 371);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.RowHeadersWidth = 51;
            this.dgvImages.RowTemplate.Height = 24;
            this.dgvImages.Size = new System.Drawing.Size(880, 220);
            this.dgvImages.TabIndex = 6;
            this.dgvImages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImages_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.dgvImages);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpImageControlCenter);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.txtImageTitle);
            this.Controls.Add(this.txtImageId);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.lblImageTitle);
            this.Controls.Add(this.lblImageId);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Image Upload and Display App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.grpImageControlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblImageId;
        private System.Windows.Forms.TextBox txtImageId;
        private System.Windows.Forms.Label lblImageTitle;
        private System.Windows.Forms.TextBox txtImageTitle;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox grpImageControlCenter;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridView dgvImages;
    }
}

