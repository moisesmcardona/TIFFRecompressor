﻿namespace TIFFRecompressor
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
            this.browseInput = new System.Windows.Forms.Button();
            this.Step1Label = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.Step2Label = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.browseOutput = new System.Windows.Forms.Button();
            this.RecompressButton = new System.Windows.Forms.Button();
            this.Step3Label = new System.Windows.Forms.Label();
            this.compressionMethodComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPUThreads = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CPUThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // browseInput
            // 
            this.browseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInput.Location = new System.Drawing.Point(329, 23);
            this.browseInput.Name = "browseInput";
            this.browseInput.Size = new System.Drawing.Size(75, 23);
            this.browseInput.TabIndex = 0;
            this.browseInput.Text = "Browse";
            this.browseInput.UseVisualStyleBackColor = true;
            this.browseInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.Location = new System.Drawing.Point(12, 9);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(174, 13);
            this.Step1Label.TabIndex = 1;
            this.Step1Label.Text = "Step 1: Select folder with TIFF files:";
            // 
            // inputTextbox
            // 
            this.inputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextbox.Location = new System.Drawing.Point(15, 25);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(308, 20);
            this.inputTextbox.TabIndex = 2;
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Location = new System.Drawing.Point(12, 57);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(259, 13);
            this.Step2Label.TabIndex = 3;
            this.Step2Label.Text = "Step 2: Select folder to store recompressed TIFF files:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(15, 73);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(308, 20);
            this.outputTextBox.TabIndex = 5;
            // 
            // browseOutput
            // 
            this.browseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutput.Location = new System.Drawing.Point(329, 71);
            this.browseOutput.Name = "browseOutput";
            this.browseOutput.Size = new System.Drawing.Size(75, 23);
            this.browseOutput.TabIndex = 4;
            this.browseOutput.Text = "Browse";
            this.browseOutput.UseVisualStyleBackColor = true;
            this.browseOutput.Click += new System.EventHandler(this.browseOutput_Click);
            // 
            // RecompressButton
            // 
            this.RecompressButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecompressButton.Location = new System.Drawing.Point(15, 150);
            this.RecompressButton.Name = "RecompressButton";
            this.RecompressButton.Size = new System.Drawing.Size(389, 23);
            this.RecompressButton.TabIndex = 6;
            this.RecompressButton.Text = "Recompress";
            this.RecompressButton.UseVisualStyleBackColor = true;
            this.RecompressButton.Click += new System.EventHandler(this.RecompressButton_Click);
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.Location = new System.Drawing.Point(12, 107);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(179, 13);
            this.Step3Label.TabIndex = 7;
            this.Step3Label.Text = "Step 3: Select Compression Method:";
            // 
            // compressionMethodComboBox
            // 
            this.compressionMethodComboBox.FormattingEnabled = true;
            this.compressionMethodComboBox.Items.AddRange(new object[] {
            "Uncompressed",
            "CCITT3",
            "CCITT4",
            "LZW",
            "RLE"});
            this.compressionMethodComboBox.Location = new System.Drawing.Point(15, 123);
            this.compressionMethodComboBox.Name = "compressionMethodComboBox";
            this.compressionMethodComboBox.Size = new System.Drawing.Size(176, 21);
            this.compressionMethodComboBox.TabIndex = 8;
            this.compressionMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.compressionMethodComboBox_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 180);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "GUI By: Moisés Cardona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "v0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Threads to use:";
            // 
            // CPUThreads
            // 
            this.CPUThreads.Location = new System.Drawing.Point(197, 124);
            this.CPUThreads.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CPUThreads.Name = "CPUThreads";
            this.CPUThreads.Size = new System.Drawing.Size(78, 20);
            this.CPUThreads.TabIndex = 13;
            this.CPUThreads.ValueChanged += new System.EventHandler(this.CPUThreads_ValueChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 238);
            this.Controls.Add(this.CPUThreads);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.compressionMethodComboBox);
            this.Controls.Add(this.Step3Label);
            this.Controls.Add(this.RecompressButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.browseOutput);
            this.Controls.Add(this.Step2Label);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.Step1Label);
            this.Controls.Add(this.browseInput);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TIFF Recompressor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.CPUThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseInput;
        private System.Windows.Forms.Label Step1Label;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label Step2Label;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button browseOutput;
        private System.Windows.Forms.Button RecompressButton;
        private System.Windows.Forms.Label Step3Label;
        private System.Windows.Forms.ComboBox compressionMethodComboBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CPUThreads;
    }
}