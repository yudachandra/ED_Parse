namespace AES_Encrypt_Decrypt
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_iv_string = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_key_string = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_input = new System.Windows.Forms.RichTextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.txtBox_output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_iv_string);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_key_string);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtBox_input);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_encrypt);
            this.splitContainer1.Panel2.Controls.Add(this.button_decrypt);
            this.splitContainer1.Panel2.Controls.Add(this.txtBox_output);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_iv_string
            // 
            this.txt_iv_string.Location = new System.Drawing.Point(16, 321);
            this.txt_iv_string.Name = "txt_iv_string";
            this.txt_iv_string.Size = new System.Drawing.Size(346, 26);
            this.txt_iv_string.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "IV String";
            // 
            // txt_key_string
            // 
            this.txt_key_string.Location = new System.Drawing.Point(16, 264);
            this.txt_key_string.Name = "txt_key_string";
            this.txt_key_string.Size = new System.Drawing.Size(346, 26);
            this.txt_key_string.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key String";
            // 
            // txtBox_input
            // 
            this.txtBox_input.Location = new System.Drawing.Point(12, 12);
            this.txtBox_input.Name = "txtBox_input";
            this.txtBox_input.Size = new System.Drawing.Size(387, 209);
            this.txtBox_input.TabIndex = 0;
            this.txtBox_input.Text = "";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(278, 264);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(104, 38);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(278, 308);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(104, 39);
            this.button_decrypt.TabIndex = 1;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // txtBox_output
            // 
            this.txtBox_output.Location = new System.Drawing.Point(3, 12);
            this.txtBox_output.Name = "txtBox_output";
            this.txtBox_output.Size = new System.Drawing.Size(379, 209);
            this.txtBox_output.TabIndex = 0;
            this.txtBox_output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "AES Encrypt Decrypt";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtBox_input;
        private System.Windows.Forms.RichTextBox txtBox_output;
        private System.Windows.Forms.TextBox txt_iv_string;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_key_string;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
    }
}

