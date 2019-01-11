namespace LeetTranslatorFun
{
  partial class LeetForm
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
      this.button_CopyToClipboard = new System.Windows.Forms.Button();
      this.textBox_PlainText = new System.Windows.Forms.TextBox();
      this.textBox_LeetText = new System.Windows.Forms.TextBox();
      this.label_PlainText = new System.Windows.Forms.Label();
      this.label_LeetText = new System.Windows.Forms.Label();
      this.button_CopyFromClipboard = new System.Windows.Forms.Button();
      this.trackBar_LeetDegree = new System.Windows.Forms.TrackBar();
      this.label_LeetDegree = new System.Windows.Forms.Label();
      this.checkBox_LeetAlternateCharset = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_LeetDegree)).BeginInit();
      this.SuspendLayout();
      // 
      // button_CopyToClipboard
      // 
      this.button_CopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_CopyToClipboard.Location = new System.Drawing.Point(731, 357);
      this.button_CopyToClipboard.Name = "button_CopyToClipboard";
      this.button_CopyToClipboard.Size = new System.Drawing.Size(109, 23);
      this.button_CopyToClipboard.TabIndex = 0;
      this.button_CopyToClipboard.Text = "Copy to Clipboard";
      this.button_CopyToClipboard.UseVisualStyleBackColor = true;
      this.button_CopyToClipboard.Click += new System.EventHandler(this.button_CopyToClipboard_Click);
      // 
      // textBox_PlainText
      // 
      this.textBox_PlainText.AcceptsReturn = true;
      this.textBox_PlainText.AcceptsTab = true;
      this.textBox_PlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.textBox_PlainText.Location = new System.Drawing.Point(12, 36);
      this.textBox_PlainText.Multiline = true;
      this.textBox_PlainText.Name = "textBox_PlainText";
      this.textBox_PlainText.Size = new System.Drawing.Size(411, 291);
      this.textBox_PlainText.TabIndex = 1;
      this.textBox_PlainText.ModifiedChanged += new System.EventHandler(this.textBox_PlainText_ModifiedChanged);
      this.textBox_PlainText.TextChanged += new System.EventHandler(this.textBox_PlainText_TextChanged);
      // 
      // textBox_LeetText
      // 
      this.textBox_LeetText.AcceptsReturn = true;
      this.textBox_LeetText.AcceptsTab = true;
      this.textBox_LeetText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_LeetText.BackColor = System.Drawing.SystemColors.Window;
      this.textBox_LeetText.Location = new System.Drawing.Point(429, 36);
      this.textBox_LeetText.Multiline = true;
      this.textBox_LeetText.Name = "textBox_LeetText";
      this.textBox_LeetText.ReadOnly = true;
      this.textBox_LeetText.Size = new System.Drawing.Size(411, 291);
      this.textBox_LeetText.TabIndex = 2;
      // 
      // label_PlainText
      // 
      this.label_PlainText.AutoSize = true;
      this.label_PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_PlainText.Location = new System.Drawing.Point(12, 13);
      this.label_PlainText.Name = "label_PlainText";
      this.label_PlainText.Size = new System.Drawing.Size(73, 20);
      this.label_PlainText.TabIndex = 3;
      this.label_PlainText.Text = "Plain text";
      // 
      // label_LeetText
      // 
      this.label_LeetText.AutoSize = true;
      this.label_LeetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_LeetText.Location = new System.Drawing.Point(429, 13);
      this.label_LeetText.Name = "label_LeetText";
      this.label_LeetText.Size = new System.Drawing.Size(71, 20);
      this.label_LeetText.TabIndex = 4;
      this.label_LeetText.Text = "Leet text";
      // 
      // button_CopyFromClipboard
      // 
      this.button_CopyFromClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.button_CopyFromClipboard.Location = new System.Drawing.Point(12, 357);
      this.button_CopyFromClipboard.Name = "button_CopyFromClipboard";
      this.button_CopyFromClipboard.Size = new System.Drawing.Size(109, 23);
      this.button_CopyFromClipboard.TabIndex = 5;
      this.button_CopyFromClipboard.Text = "Copy from Clipboard";
      this.button_CopyFromClipboard.UseVisualStyleBackColor = true;
      this.button_CopyFromClipboard.Click += new System.EventHandler(this.button_CopyFromClipboard_Click);
      // 
      // trackBar_LeetDegree
      // 
      this.trackBar_LeetDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar_LeetDegree.AutoSize = false;
      this.trackBar_LeetDegree.LargeChange = 15;
      this.trackBar_LeetDegree.Location = new System.Drawing.Point(429, 354);
      this.trackBar_LeetDegree.Maximum = 100;
      this.trackBar_LeetDegree.Name = "trackBar_LeetDegree";
      this.trackBar_LeetDegree.Size = new System.Drawing.Size(266, 26);
      this.trackBar_LeetDegree.TabIndex = 6;
      this.trackBar_LeetDegree.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trackBar_LeetDegree.Value = 30;
      this.trackBar_LeetDegree.Scroll += new System.EventHandler(this.trackBar_LeetDegree_Scroll);
      // 
      // label_LeetDegree
      // 
      this.label_LeetDegree.AutoSize = true;
      this.label_LeetDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_LeetDegree.Location = new System.Drawing.Point(429, 330);
      this.label_LeetDegree.Name = "label_LeetDegree";
      this.label_LeetDegree.Size = new System.Drawing.Size(121, 20);
      this.label_LeetDegree.TabIndex = 7;
      this.label_LeetDegree.Text = "Leet degree: 30";
      // 
      // checkBox_LeetAlternateCharset
      // 
      this.checkBox_LeetAlternateCharset.AutoSize = true;
      this.checkBox_LeetAlternateCharset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBox_LeetAlternateCharset.Location = new System.Drawing.Point(597, 329);
      this.checkBox_LeetAlternateCharset.Name = "checkBox_LeetAlternateCharset";
      this.checkBox_LeetAlternateCharset.Size = new System.Drawing.Size(150, 24);
      this.checkBox_LeetAlternateCharset.TabIndex = 8;
      this.checkBox_LeetAlternateCharset.Text = "Alternate charset";
      this.checkBox_LeetAlternateCharset.UseVisualStyleBackColor = true;
      this.checkBox_LeetAlternateCharset.CheckedChanged += new System.EventHandler(this.checkBox_LeetAlternateCharset_CheckedChanged);
      // 
      // LeetForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(852, 386);
      this.Controls.Add(this.checkBox_LeetAlternateCharset);
      this.Controls.Add(this.label_LeetDegree);
      this.Controls.Add(this.trackBar_LeetDegree);
      this.Controls.Add(this.button_CopyFromClipboard);
      this.Controls.Add(this.label_LeetText);
      this.Controls.Add(this.label_PlainText);
      this.Controls.Add(this.textBox_LeetText);
      this.Controls.Add(this.textBox_PlainText);
      this.Controls.Add(this.button_CopyToClipboard);
      this.MinimumSize = new System.Drawing.Size(868, 351);
      this.Name = "LeetForm";
      this.Text = "Leet Translator";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_LeetDegree)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button_CopyToClipboard;
    private System.Windows.Forms.TextBox textBox_PlainText;
    private System.Windows.Forms.TextBox textBox_LeetText;
    private System.Windows.Forms.Label label_PlainText;
    private System.Windows.Forms.Label label_LeetText;
    private System.Windows.Forms.Button button_CopyFromClipboard;
    private System.Windows.Forms.TrackBar trackBar_LeetDegree;
    private System.Windows.Forms.Label label_LeetDegree;
    private System.Windows.Forms.CheckBox checkBox_LeetAlternateCharset;
  }
}

