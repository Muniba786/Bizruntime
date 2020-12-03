namespace WindowsFormsApp18
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
            this.Serializebtn = new System.Windows.Forms.Button();
            this.rtbserialize = new System.Windows.Forms.RichTextBox();
            this.btndeserialize = new System.Windows.Forms.Button();
            this.rtbdeserialize = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Serializebtn
            // 
            this.Serializebtn.Location = new System.Drawing.Point(83, 43);
            this.Serializebtn.Name = "Serializebtn";
            this.Serializebtn.Size = new System.Drawing.Size(624, 46);
            this.Serializebtn.TabIndex = 0;
            this.Serializebtn.Text = "Serialize";
            this.Serializebtn.UseVisualStyleBackColor = true;
            this.Serializebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbserialize
            // 
            this.rtbserialize.Location = new System.Drawing.Point(83, 95);
            this.rtbserialize.Name = "rtbserialize";
            this.rtbserialize.Size = new System.Drawing.Size(624, 145);
            this.rtbserialize.TabIndex = 1;
            this.rtbserialize.Text = "";
            // 
            // btndeserialize
            // 
            this.btndeserialize.Location = new System.Drawing.Point(83, 246);
            this.btndeserialize.Name = "btndeserialize";
            this.btndeserialize.Size = new System.Drawing.Size(624, 46);
            this.btndeserialize.TabIndex = 2;
            this.btndeserialize.Text = "deserialize";
            this.btndeserialize.UseVisualStyleBackColor = true;
            this.btndeserialize.Click += new System.EventHandler(this.btndeserialize_Click);
            // 
            // rtbdeserialize
            // 
            this.rtbdeserialize.Location = new System.Drawing.Point(83, 298);
            this.rtbdeserialize.Name = "rtbdeserialize";
            this.rtbdeserialize.Size = new System.Drawing.Size(624, 140);
            this.rtbdeserialize.TabIndex = 3;
            this.rtbdeserialize.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbdeserialize);
            this.Controls.Add(this.btndeserialize);
            this.Controls.Add(this.rtbserialize);
            this.Controls.Add(this.Serializebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Serializebtn;
        private System.Windows.Forms.RichTextBox rtbserialize;
        private System.Windows.Forms.Button btndeserialize;
        private System.Windows.Forms.RichTextBox rtbdeserialize;
    }
}

