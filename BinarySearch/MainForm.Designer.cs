namespace BinarySearch
{
    partial class MainForm
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
            this.uiTlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiNum_MaxValue = new System.Windows.Forms.NumericUpDown();
            this.uiNum_ValueToFind = new System.Windows.Forms.NumericUpDown();
            this.uiBtn_Search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiRtb_Content = new System.Windows.Forms.RichTextBox();
            this.uiTlp_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_MaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_ValueToFind)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.ColumnCount = 1;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.Controls.Add(this.panel1, 0, 0);
            this.uiTlp_Main.Controls.Add(this.panel2, 0, 1);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 2;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTlp_Main.Size = new System.Drawing.Size(404, 573);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiBtn_Search);
            this.panel1.Controls.Add(this.uiNum_ValueToFind);
            this.panel1.Controls.Add(this.uiNum_MaxValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array Max Value (1~ )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value to find";
            // 
            // uiNum_MaxValue
            // 
            this.uiNum_MaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNum_MaxValue.Location = new System.Drawing.Point(159, 16);
            this.uiNum_MaxValue.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uiNum_MaxValue.Name = "uiNum_MaxValue";
            this.uiNum_MaxValue.Size = new System.Drawing.Size(130, 21);
            this.uiNum_MaxValue.TabIndex = 2;
            this.uiNum_MaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiNum_ValueToFind
            // 
            this.uiNum_ValueToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNum_ValueToFind.Location = new System.Drawing.Point(159, 43);
            this.uiNum_ValueToFind.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uiNum_ValueToFind.Name = "uiNum_ValueToFind";
            this.uiNum_ValueToFind.Size = new System.Drawing.Size(130, 21);
            this.uiNum_ValueToFind.TabIndex = 3;
            this.uiNum_ValueToFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiBtn_Search
            // 
            this.uiBtn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Search.Location = new System.Drawing.Point(295, 16);
            this.uiBtn_Search.Name = "uiBtn_Search";
            this.uiBtn_Search.Size = new System.Drawing.Size(89, 48);
            this.uiBtn_Search.TabIndex = 4;
            this.uiBtn_Search.Text = "Binary Search";
            this.uiBtn_Search.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiRtb_Content);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 491);
            this.panel2.TabIndex = 1;
            // 
            // uiRtb_Content
            // 
            this.uiRtb_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRtb_Content.Location = new System.Drawing.Point(0, 0);
            this.uiRtb_Content.Name = "uiRtb_Content";
            this.uiRtb_Content.Size = new System.Drawing.Size(402, 491);
            this.uiRtb_Content.TabIndex = 0;
            this.uiRtb_Content.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(404, 573);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Binary Search";
            this.uiTlp_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_MaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_ValueToFind)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown uiNum_ValueToFind;
        private System.Windows.Forms.NumericUpDown uiNum_MaxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiBtn_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox uiRtb_Content;
    }
}