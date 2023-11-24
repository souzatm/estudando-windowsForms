namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.Txt_Msg = new System.Windows.Forms.TextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lbl_Minus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Upper = new System.Windows.Forms.Label();
            this.Lbl_Lower = new System.Windows.Forms.Label();
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Msg
            // 
            this.Txt_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Msg.Location = new System.Drawing.Point(8, 40);
            this.Txt_Msg.Multiline = true;
            this.Txt_Msg.Name = "Txt_Msg";
            this.Txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Msg.Size = new System.Drawing.Size(304, 232);
            this.Txt_Msg.TabIndex = 1;
            this.Txt_Msg.TabStop = false;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.Location = new System.Drawing.Point(328, 8);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Lbl_Minus
            // 
            this.Lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Minus.AutoSize = true;
            this.Lbl_Minus.Location = new System.Drawing.Point(325, 101);
            this.Lbl_Minus.Name = "Lbl_Minus";
            this.Lbl_Minus.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Minus.TabIndex = 3;
            this.Lbl_Minus.Text = "Minus.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maius.";
            // 
            // Lbl_Upper
            // 
            this.Lbl_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Upper.Location = new System.Drawing.Point(371, 42);
            this.Lbl_Upper.Name = "Lbl_Upper";
            this.Lbl_Upper.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Upper.TabIndex = 5;
            // 
            // Lbl_Lower
            // 
            this.Lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lower.Location = new System.Drawing.Point(371, 101);
            this.Lbl_Lower.Name = "Lbl_Lower";
            this.Lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Lower.TabIndex = 6;
            // 
            // Txt_Input
            // 
            this.Txt_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Input.Location = new System.Drawing.Point(8, 8);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(100, 13);
            this.Txt_Input.TabIndex = 7;
            this.Txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Input_KeyDown);
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.Txt_Input);
            this.Controls.Add(this.Lbl_Lower);
            this.Controls.Add(this.Lbl_Upper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Minus);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Txt_Msg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DemonstracaoKey";
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Msg;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lbl_Minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Upper;
        private System.Windows.Forms.Label Lbl_Lower;
        private System.Windows.Forms.TextBox Txt_Input;
    }
}