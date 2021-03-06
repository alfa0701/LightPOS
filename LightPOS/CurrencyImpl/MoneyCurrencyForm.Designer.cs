﻿namespace NickAc.LightPOS.Frontend.CurrencyImpl
{
    partial class MoneyCurrencyForm
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
            if (disposing && (components != null)) {
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
            this.translationHelper1 = new NickAc.LightPOS.Backend.Translation.TranslationHelper();
            this.priceKeypadControl1 = new NickAc.LightPOS.Frontend.Controls.PriceKeypadControl();
            this.SuspendLayout();
            // 
            // appBar1
            // 
            this.appBar1.Location = new System.Drawing.Point(1, 1);
            this.appBar1.Size = new System.Drawing.Size(836, 50);
            this.appBar1.Text = "MoneyCurrencyForm";
            this.translationHelper1.SetTranslationLocation(this.appBar1, "");
            // 
            // priceKeypadControl1
            // 
            this.priceKeypadControl1.ButtonSize = new System.Drawing.Size(75, 75);
            this.priceKeypadControl1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.priceKeypadControl1.Location = new System.Drawing.Point(354, 73);
            this.priceKeypadControl1.Name = "priceKeypadControl1";
            this.priceKeypadControl1.Size = new System.Drawing.Size(225, 300);
            this.priceKeypadControl1.TabIndex = 1;
            this.priceKeypadControl1.Text = "priceKeypadControl1";
            this.translationHelper1.SetTranslationLocation(this.priceKeypadControl1, "");
            // 
            // MoneyCurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(838, 469);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.priceKeypadControl1);
            this.Name = "MoneyCurrencyForm";
            this.Text = "MoneyCurrencyForm";
            this.TitlebarVisible = false;
            this.TopMost = true;
            this.translationHelper1.SetTranslationLocation(this, "money_currency_title");
            this.Controls.SetChildIndex(this.appBar1, 0);
            this.Controls.SetChildIndex(this.priceKeypadControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Backend.Translation.TranslationHelper translationHelper1;
        private Controls.PriceKeypadControl priceKeypadControl1;
    }
}