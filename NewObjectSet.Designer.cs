namespace DirectX11TutorialObjectEditor
{
    partial class NewObjectSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbObjectSetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTextureFileName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "오브젝트 셋 이름";
            // 
            // tbObjectSetName
            // 
            this.tbObjectSetName.Location = new System.Drawing.Point(116, 10);
            this.tbObjectSetName.Name = "tbObjectSetName";
            this.tbObjectSetName.Size = new System.Drawing.Size(100, 21);
            this.tbObjectSetName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "텍스처 파일";
            // 
            // tbTextureFileName
            // 
            this.tbTextureFileName.Location = new System.Drawing.Point(116, 37);
            this.tbTextureFileName.Name = "tbTextureFileName";
            this.tbTextureFileName.Size = new System.Drawing.Size(100, 21);
            this.tbTextureFileName.TabIndex = 3;
            this.tbTextureFileName.Enter += new System.EventHandler(this.TbTextureFileName_Enter);
            this.tbTextureFileName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbTextureFileName_MouseDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 67);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(141, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "openFileDialog1";
            // 
            // NewObjectSet
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(227, 100);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbTextureFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbObjectSetName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewObjectSet";
            this.Text = "새로만들기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObjectSetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTextureFileName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}