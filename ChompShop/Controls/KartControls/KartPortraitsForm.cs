﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChompShop.Data;
using Cereal64.Microcodes.F3DEX.DataElements;
using Pitstop64.Data;
using System.IO;
using Cereal64.Common.DataElements.Encoding;

namespace ChompShop.Controls.KartControls
{
    public partial class KartPortraitsForm : ChompShopWindow
    {
        public bool _initializing;

        public KartPortraitsForm(KartWrapper kart)
            : base(kart)
        {
            InitializeComponent();

            InitData();
        }

        public override void InitData()
        {
            _initializing = true;

            ResetTitleText();

            MK64Image selectedImage = (MK64Image)lbPortraits.SelectedItem;

            ClearForm();

            PopulatePortraitListBox();

            if (Kart.Kart.KartPortraits.Count > 0)
            {
                if (selectedImage != null && lbPortraits.Items.Contains(selectedImage))
                    lbPortraits.SelectedItem = selectedImage;
                else
                    lbPortraits.SelectedIndex = 0;
            }

            UpdatePortrait();

            UpdatePortraitCount();

            UpdateButtonsEnabled();
            
            _initializing = false;
        }

        private void ClearForm()
        {
            imagePreviewControl.Image = null;
            lbPortraits.Items.Clear();
        }

        private void PopulatePortraitListBox()
        {
            foreach (MK64Image image in Kart.Kart.KartPortraits)
            {
                lbPortraits.Items.Add(image);
            }
        }

        private void UpdatePortraitCount()
        {
            int portraitCount = lbPortraits.Items.Count;
            if (portraitCount < 17)
                lblPortraitCount.ForeColor = Color.DarkRed;
            else
                lblPortraitCount.ForeColor = Color.DarkGreen;
            lblPortraitCount.Text = portraitCount.ToString() + "/17";
        }

        private void UpdatePortrait()
        {
            if (lbPortraits.SelectedItem == null)
                imagePreviewControl.Image = null;
            else
            {
                imagePreviewControl.Image = ((MK64Image)lbPortraits.SelectedItem).Image;
                imagePreviewControl.ImageName = ((MK64Image)lbPortraits.SelectedItem).ImageName;
                if (lbPortraits.SelectedIndex < 17)
                    lblRole.Text = RoleText[lbPortraits.SelectedIndex];
            }
        }

        private void UpdateButtonsEnabled()
        {
            bool validImageSelected = (lbPortraits.SelectedItem != null);

            btnRemove.Enabled = validImageSelected;
            btnUp.Enabled = validImageSelected;
            btnDown.Enabled = validImageSelected;

            bool maxImagesHit = (lbPortraits.Items.Count >= 17);

            btnAdd.Enabled = !maxImagesHit;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openPortraitDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openPortraitDialog.FileNames)
                {
                    if (lbPortraits.Items.Count >= 17)
                        break;

                    Image img = Bitmap.FromFile(file);
                    if (img.Width != 64 || img.Height != 64)
                    {
                        MessageBox.Show("Image must be 64x64!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (img != null)
                    {
                        //Create the new KartImage here
                        byte[] imgData = TextureConversion.RGBA16ToBinary(new Bitmap(img));
                        Texture texture = new Texture(-1, imgData, Texture.ImageFormat.RGBA, Texture.PixelInfo.Size_16b, 64, 64);
                        F3DEXImage image = new F3DEXImage(texture);
                        MK64Image mkImage = new MK64Image(image, Path.GetFileNameWithoutExtension(file), true);
                        Kart.AddPortrait(mkImage);

                        lbPortraits.Items.Add(mkImage);
                    }
                }

                UpdatePortraitCount();
                UpdateButtonsEnabled();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lbPortraits.SelectedItem == null || lbPortraits.SelectedIndex == 0)
                return;

            SwapPortraitImages(lbPortraits.SelectedIndex, lbPortraits.SelectedIndex - 1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lbPortraits.SelectedItem == null || lbPortraits.SelectedIndex == lbPortraits.Items.Count - 1)
                return;

            SwapPortraitImages(lbPortraits.SelectedIndex, lbPortraits.SelectedIndex + 1);
        }

        private void SwapPortraitImages(int index1, int index2)
        {
            object selectedItem = lbPortraits.SelectedItem;

            object temp = lbPortraits.Items[index1];
            lbPortraits.Items[index1] = lbPortraits.Items[index2];
            lbPortraits.Items[index2] = temp;

            lbPortraits.SelectedItem = selectedItem;

            Kart.SwapPortraits(index1, index2);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbPortraits.SelectedItem == null)
                return;

            Kart.RemovePortrait((MK64Image)lbPortraits.SelectedItem);
            lbPortraits.Items.Remove(lbPortraits.SelectedItem);

            UpdatePortraitCount();
            UpdateButtonsEnabled();

            //update the selected index, or will that be handled already?
        }

        private void lbPortraits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initializing)
            {
                UpdatePortrait();
                UpdateButtonsEnabled();
            }
        }

        public override ChompShopWindowType WindowType { get { return ChompShopWindowType.KartPortraits; } }

        protected override string TitleText { get { return "Kart Portraits - {0}"; } }

        private string[] RoleText = new string[17]
        {
            "Static",
            "Blink 1",
            "Blink 2",
            "Blink 3",
            "Blink 4",
            "Blink 5",
            "Victory 1",
            "Victory 2",
            "Victory 3",
            "Victory 4",
            "Victory 5",
            "Victory 6",
            "Victory 7",
            "Victory 8",
            "Victory 9",
            "Victory 10",
            "Loss"
        };

    }
}
