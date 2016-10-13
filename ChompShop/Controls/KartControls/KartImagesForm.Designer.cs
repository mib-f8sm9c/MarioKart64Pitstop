﻿namespace ChompShop.Controls.KartControls
{
    partial class KartImagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartImagesForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gbKartImages = new System.Windows.Forms.GroupBox();
            this.imagePreviewControl = new MK64Pitstop.Modules.Karts.ImagePreviewControl();
            this.lbKartImages = new System.Windows.Forms.ListBox();
            this.gbNew = new System.Windows.Forms.GroupBox();
            this.lbNewImages = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnRemoveKartImage = new System.Windows.Forms.Button();
            this.btnEditKartImage = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnConvertNewToKart = new System.Windows.Forms.Button();
            this.btnRemoveNewImage = new System.Windows.Forms.Button();
            this.btnAddNewImage = new System.Windows.Forms.Button();
            this.btnBasePaletteManip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbKartImages.SuspendLayout();
            this.gbNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gbKartImages);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gbNew);
            this.splitContainer.Size = new System.Drawing.Size(723, 322);
            this.splitContainer.SplitterDistance = 402;
            this.splitContainer.TabIndex = 0;
            // 
            // gbKartImages
            // 
            this.gbKartImages.Controls.Add(this.btnRemoveKartImage);
            this.gbKartImages.Controls.Add(this.btnEditKartImage);
            this.gbKartImages.Controls.Add(this.imagePreviewControl);
            this.gbKartImages.Controls.Add(this.lbKartImages);
            this.gbKartImages.Controls.Add(this.btnAdvanced);
            this.gbKartImages.Location = new System.Drawing.Point(3, 3);
            this.gbKartImages.Name = "gbKartImages";
            this.gbKartImages.Size = new System.Drawing.Size(396, 316);
            this.gbKartImages.TabIndex = 11;
            this.gbKartImages.TabStop = false;
            this.gbKartImages.Text = "Kart Images";
            // 
            // imagePreviewControl
            // 
            this.imagePreviewControl.ExportButtonVisible = true;
            this.imagePreviewControl.Image = null;
            this.imagePreviewControl.Location = new System.Drawing.Point(220, 18);
            this.imagePreviewControl.Name = "imagePreviewControl";
            this.imagePreviewControl.Size = new System.Drawing.Size(170, 155);
            this.imagePreviewControl.TabIndex = 9;
            // 
            // lbKartImages
            // 
            this.lbKartImages.FormattingEnabled = true;
            this.lbKartImages.ItemHeight = 16;
            this.lbKartImages.Location = new System.Drawing.Point(6, 51);
            this.lbKartImages.Name = "lbKartImages";
            this.lbKartImages.ScrollAlwaysVisible = true;
            this.lbKartImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbKartImages.Size = new System.Drawing.Size(208, 260);
            this.lbKartImages.TabIndex = 0;
            this.lbKartImages.SelectedIndexChanged += new System.EventHandler(this.lbKartImages_SelectedIndexChanged);
            // 
            // gbNew
            // 
            this.gbNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNew.Controls.Add(this.btnConvertNewToKart);
            this.gbNew.Controls.Add(this.btnRemoveNewImage);
            this.gbNew.Controls.Add(this.lbNewImages);
            this.gbNew.Controls.Add(this.btnAddNewImage);
            this.gbNew.Controls.Add(this.btnBasePaletteManip);
            this.gbNew.Location = new System.Drawing.Point(3, 3);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(311, 316);
            this.gbNew.TabIndex = 11;
            this.gbNew.TabStop = false;
            this.gbNew.Text = "New Images";
            // 
            // lbNewImages
            // 
            this.lbNewImages.FormattingEnabled = true;
            this.lbNewImages.ItemHeight = 16;
            this.lbNewImages.Location = new System.Drawing.Point(73, 50);
            this.lbNewImages.Name = "lbNewImages";
            this.lbNewImages.ScrollAlwaysVisible = true;
            this.lbNewImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNewImages.Size = new System.Drawing.Size(222, 260);
            this.lbNewImages.TabIndex = 1;
            this.lbNewImages.SelectedIndexChanged += new System.EventHandler(this.lbNewImages_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PNG/BMP files|*.png;*.bmp|All files|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // btnRemoveKartImage
            // 
            this.btnRemoveKartImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveKartImage.Image = global::ChompShop.Properties.Resources.minus;
            this.btnRemoveKartImage.Location = new System.Drawing.Point(6, 22);
            this.btnRemoveKartImage.Name = "btnRemoveKartImage";
            this.btnRemoveKartImage.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveKartImage.TabIndex = 8;
            this.toolTip.SetToolTip(this.btnRemoveKartImage, "Remove selected Kart Image");
            this.btnRemoveKartImage.UseVisualStyleBackColor = true;
            this.btnRemoveKartImage.Click += new System.EventHandler(this.btnRemoveKartImage_Click);
            // 
            // btnEditKartImage
            // 
            this.btnEditKartImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditKartImage.Image = global::ChompShop.Properties.Resources.pencil;
            this.btnEditKartImage.Location = new System.Drawing.Point(30, 22);
            this.btnEditKartImage.Name = "btnEditKartImage";
            this.btnEditKartImage.Size = new System.Drawing.Size(20, 20);
            this.btnEditKartImage.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnEditKartImage, "Edit selected Kart Image");
            this.btnEditKartImage.UseVisualStyleBackColor = true;
            this.btnEditKartImage.Visible = false;
            this.btnEditKartImage.Click += new System.EventHandler(this.btnEditKartImage_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanced.Image = ((System.Drawing.Image)(resources.GetObject("btnAdvanced.Image")));
            this.btnAdvanced.Location = new System.Drawing.Point(353, 272);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(34, 34);
            this.btnAdvanced.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnAdvanced, "Expand more options");
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnConvertNewToKart
            // 
            this.btnConvertNewToKart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertNewToKart.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertNewToKart.Image")));
            this.btnConvertNewToKart.Location = new System.Drawing.Point(15, 63);
            this.btnConvertNewToKart.Name = "btnConvertNewToKart";
            this.btnConvertNewToKart.Size = new System.Drawing.Size(38, 35);
            this.btnConvertNewToKart.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnConvertNewToKart, "Convert new images to Kart Images");
            this.btnConvertNewToKart.UseVisualStyleBackColor = true;
            this.btnConvertNewToKart.Click += new System.EventHandler(this.btnConvertNewToKart_Click);
            // 
            // btnRemoveNewImage
            // 
            this.btnRemoveNewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveNewImage.Image = global::ChompShop.Properties.Resources.minus;
            this.btnRemoveNewImage.Location = new System.Drawing.Point(277, 18);
            this.btnRemoveNewImage.Name = "btnRemoveNewImage";
            this.btnRemoveNewImage.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveNewImage.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnRemoveNewImage, "Remove selected new image");
            this.btnRemoveNewImage.UseVisualStyleBackColor = true;
            this.btnRemoveNewImage.Click += new System.EventHandler(this.btnRemoveNewImage_Click);
            // 
            // btnAddNewImage
            // 
            this.btnAddNewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewImage.Image = global::ChompShop.Properties.Resources.plus;
            this.btnAddNewImage.Location = new System.Drawing.Point(254, 18);
            this.btnAddNewImage.Name = "btnAddNewImage";
            this.btnAddNewImage.Size = new System.Drawing.Size(20, 20);
            this.btnAddNewImage.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnAddNewImage, "Add new images");
            this.btnAddNewImage.UseVisualStyleBackColor = true;
            this.btnAddNewImage.Click += new System.EventHandler(this.btnAddNewImage_Click);
            // 
            // btnBasePaletteManip
            // 
            this.btnBasePaletteManip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasePaletteManip.Image = global::ChompShop.Properties.Resources.circle_check_3x;
            this.btnBasePaletteManip.Location = new System.Drawing.Point(15, 126);
            this.btnBasePaletteManip.Name = "btnBasePaletteManip";
            this.btnBasePaletteManip.Size = new System.Drawing.Size(38, 36);
            this.btnBasePaletteManip.TabIndex = 5;
            this.btnBasePaletteManip.UseVisualStyleBackColor = true;
            this.btnBasePaletteManip.Click += new System.EventHandler(this.btnBasePaletteManip_Click);
            // 
            // KartImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 322);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KartImagesForm";
            this.Text = "Kart Images";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.gbKartImages.ResumeLayout(false);
            this.gbNew.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MK64Pitstop.Modules.Karts.ImagePreviewControl imagePreviewControl;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox lbKartImages;
        private System.Windows.Forms.Button btnRemoveKartImage;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Button btnBasePaletteManip;
        private System.Windows.Forms.Button btnConvertNewToKart;
        private System.Windows.Forms.ListBox lbNewImages;
        private System.Windows.Forms.Button btnEditKartImage;
        private System.Windows.Forms.Button btnRemoveNewImage;
        private System.Windows.Forms.Button btnAddNewImage;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbNew;
        private System.Windows.Forms.GroupBox gbKartImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}