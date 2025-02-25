using System;
using System.Drawing;
using System.Windows.Forms;

namespace Waste_Management
{
    partial class CfrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            cmboProducts = new ComboBox();
            nudReductionPercent = new NumericUpDown();
            btnAdd = new Button();
            lblOriginalDm3 = new Label();
            nudOriginalVolume = new NumericUpDown();
            label4 = new Label();
            lstbxProducts = new ListBox();
            lblOriginalMass = new Label();
            lblReducedMass = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblOriginalMassA = new Label();
            lblOriginalMassB = new Label();
            lblOriginalMassC = new Label();
            lblReducedMassC = new Label();
            lblReducedMassB = new Label();
            lblReducedMassA = new Label();
            label8 = new Label();
            lblDm3 = new Label();
            label10 = new Label();
            lblCompressedDm3 = new Label();
            btnLoadTestData = new Button();
            ((System.ComponentModel.ISupportInitialize)nudReductionPercent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOriginalVolume).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(523, 348);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 32);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 1;
            label1.Text = "Product type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 2;
            label2.Text = "Reduction %";
            // 
            // cmboProducts
            // 
            cmboProducts.FormattingEnabled = true;
            cmboProducts.Location = new Point(13, 33);
            cmboProducts.Name = "cmboProducts";
            cmboProducts.Size = new Size(202, 29);
            cmboProducts.TabIndex = 3;
            // 
            // nudReductionPercent
            // 
            nudReductionPercent.DecimalPlaces = 1;
            nudReductionPercent.Location = new Point(13, 184);
            nudReductionPercent.Name = "nudReductionPercent";
            nudReductionPercent.Size = new Size(97, 29);
            nudReductionPercent.TabIndex = 4;
            nudReductionPercent.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblOriginalDm3
            // 
            lblOriginalDm3.AutoSize = true;
            lblOriginalDm3.Location = new Point(13, 86);
            lblOriginalDm3.Margin = new Padding(4, 0, 4, 0);
            lblOriginalDm3.Name = "lblOriginalDm3";
            lblOriginalDm3.Size = new Size(168, 21);
            lblOriginalDm3.TabIndex = 6;
            lblOriginalDm3.Text = "Original volume (dm3)";
            // 
            // nudOriginalVolume
            // 
            nudOriginalVolume.DecimalPlaces = 1;
            nudOriginalVolume.Location = new Point(13, 108);
            nudOriginalVolume.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudOriginalVolume.Name = "nudOriginalVolume";
            nudOriginalVolume.Size = new Size(97, 29);
            nudOriginalVolume.TabIndex = 7;
            nudOriginalVolume.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 8;
            label4.Text = "Products";
            // 
            // lstbxProducts
            // 
            lstbxProducts.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbxProducts.FormattingEnabled = true;
            lstbxProducts.ItemHeight = 21;
            lstbxProducts.Location = new Point(241, 55);
            lstbxProducts.Name = "lstbxProducts";
            lstbxProducts.Size = new Size(422, 172);
            lstbxProducts.TabIndex = 9;
            // 
            // lblOriginalMass
            // 
            lblOriginalMass.AutoSize = true;
            lblOriginalMass.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblOriginalMass.Location = new Point(314, 230);
            lblOriginalMass.Margin = new Padding(4, 0, 4, 0);
            lblOriginalMass.Name = "lblOriginalMass";
            lblOriginalMass.Size = new Size(155, 21);
            lblOriginalMass.TabIndex = 11;
            lblOriginalMass.Text = "Total original volume";
            // 
            // lblReducedMass
            // 
            lblReducedMass.AutoSize = true;
            lblReducedMass.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblReducedMass.Location = new Point(477, 230);
            lblReducedMass.Margin = new Padding(4, 0, 4, 0);
            lblReducedMass.Name = "lblReducedMass";
            lblReducedMass.Size = new Size(186, 21);
            lblReducedMass.TabIndex = 12;
            lblReducedMass.Text = "Total compressed volume";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 258);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 13;
            label5.Text = "Method A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 282);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 14;
            label6.Text = "Method B";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(241, 306);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 15;
            label7.Text = "Method C";
            // 
            // lblOriginalMassA
            // 
            lblOriginalMassA.AutoSize = true;
            lblOriginalMassA.Location = new Point(384, 258);
            lblOriginalMassA.Name = "lblOriginalMassA";
            lblOriginalMassA.Size = new Size(20, 21);
            lblOriginalMassA.TabIndex = 16;
            lblOriginalMassA.Text = "A";
            // 
            // lblOriginalMassB
            // 
            lblOriginalMassB.AutoSize = true;
            lblOriginalMassB.Location = new Point(384, 282);
            lblOriginalMassB.Name = "lblOriginalMassB";
            lblOriginalMassB.Size = new Size(19, 21);
            lblOriginalMassB.TabIndex = 17;
            lblOriginalMassB.Text = "B";
            // 
            // lblOriginalMassC
            // 
            lblOriginalMassC.AutoSize = true;
            lblOriginalMassC.Location = new Point(384, 306);
            lblOriginalMassC.Name = "lblOriginalMassC";
            lblOriginalMassC.Size = new Size(20, 21);
            lblOriginalMassC.TabIndex = 18;
            lblOriginalMassC.Text = "C";
            // 
            // lblReducedMassC
            // 
            lblReducedMassC.AutoSize = true;
            lblReducedMassC.Location = new Point(549, 306);
            lblReducedMassC.Name = "lblReducedMassC";
            lblReducedMassC.Size = new Size(20, 21);
            lblReducedMassC.TabIndex = 21;
            lblReducedMassC.Text = "C";
            // 
            // lblReducedMassB
            // 
            lblReducedMassB.AutoSize = true;
            lblReducedMassB.Location = new Point(549, 282);
            lblReducedMassB.Name = "lblReducedMassB";
            lblReducedMassB.Size = new Size(19, 21);
            lblReducedMassB.TabIndex = 20;
            lblReducedMassB.Text = "B";
            // 
            // lblReducedMassA
            // 
            lblReducedMassA.AutoSize = true;
            lblReducedMassA.Location = new Point(549, 258);
            lblReducedMassA.Name = "lblReducedMassA";
            lblReducedMassA.Size = new Size(20, 21);
            lblReducedMassA.TabIndex = 19;
            lblReducedMassA.Text = "A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 31);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 22;
            label8.Text = "Type";
            // 
            // lblDm3
            // 
            lblDm3.AutoSize = true;
            lblDm3.Location = new Point(390, 31);
            lblDm3.Margin = new Padding(4, 0, 4, 0);
            lblDm3.Name = "lblDm3";
            lblDm3.Size = new Size(42, 21);
            lblDm3.TabIndex = 23;
            lblDm3.Text = "dm3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(458, 31);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(42, 21);
            label10.TabIndex = 24;
            label10.Text = "Mult";
            // 
            // lblCompressedDm3
            // 
            lblCompressedDm3.AutoSize = true;
            lblCompressedDm3.Location = new Point(520, 31);
            lblCompressedDm3.Margin = new Padding(4, 0, 4, 0);
            lblCompressedDm3.Name = "lblCompressedDm3";
            lblCompressedDm3.Size = new Size(133, 21);
            lblCompressedDm3.TabIndex = 25;
            lblCompressedDm3.Text = "Compressed dm3";
            // 
            // btnLoadTestData
            // 
            btnLoadTestData.Location = new Point(13, 271);
            btnLoadTestData.Name = "btnLoadTestData";
            btnLoadTestData.Size = new Size(122, 32);
            btnLoadTestData.TabIndex = 26;
            btnLoadTestData.Text = "Load test data";
            btnLoadTestData.UseVisualStyleBackColor = true;
            btnLoadTestData.Click += btnLoadTestData_Click;
            // 
            // CfrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 396);
            ControlBox = false;
            Controls.Add(btnLoadTestData);
            Controls.Add(lblCompressedDm3);
            Controls.Add(label10);
            Controls.Add(lblDm3);
            Controls.Add(label8);
            Controls.Add(lblReducedMassC);
            Controls.Add(lblReducedMassB);
            Controls.Add(lblReducedMassA);
            Controls.Add(lblOriginalMassC);
            Controls.Add(lblOriginalMassB);
            Controls.Add(lblOriginalMassA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblReducedMass);
            Controls.Add(lblOriginalMass);
            Controls.Add(lstbxProducts);
            Controls.Add(label4);
            Controls.Add(nudOriginalVolume);
            Controls.Add(lblOriginalDm3);
            Controls.Add(btnAdd);
            Controls.Add(nudReductionPercent);
            Controls.Add(cmboProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "CfrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waste management";
            Load += CfrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)nudReductionPercent).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOriginalVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Button btnClose;
        private Label label1;
        private Label label2;
        private ComboBox cmboProducts;
        private NumericUpDown nudReductionPercent;
        private Button btnAdd;
        private Label lblOriginalDm3;
        private NumericUpDown nudOriginalVolume;
        private Label label4;
        private ListBox lstbxProducts;
        private Label lblOriginalMass;
        private Label lblReducedMass;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblOriginalMassA;
        private Label lblOriginalMassB;
        private Label lblOriginalMassC;
        private Label lblReducedMassC;
        private Label lblReducedMassB;
        private Label lblReducedMassA;
        private Label label8;
        private Label lblDm3;
        private Label label10;
        private Label lblCompressedDm3;
        private Button btnLoadTestData;
    }
}
