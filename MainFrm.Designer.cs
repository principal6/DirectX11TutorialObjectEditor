namespace DirectX11TutorialObjectEditor
{
    partial class MainFrm
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
            this.OuterSplitter = new System.Windows.Forms.SplitContainer();
            this.LeftVertSplitter = new System.Windows.Forms.SplitContainer();
            this.ObjectListSplitter = new System.Windows.Forms.SplitContainer();
            this.LBObjects = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBHeight = new System.Windows.Forms.TextBox();
            this.TBWidth = new System.Windows.Forms.TextBox();
            this.TBOffsetV = new System.Windows.Forms.TextBox();
            this.TBOffsetU = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TBObjectName = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.FixedInnerSplitter = new System.Windows.Forms.SplitContainer();
            this.LabelDistance = new System.Windows.Forms.Label();
            this.LabelMousePosFixed = new System.Windows.Forms.Label();
            this.LabelMousePos = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.DlgSave = new System.Windows.Forms.SaveFileDialog();
            this.LabelSelection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OuterSplitter)).BeginInit();
            this.OuterSplitter.Panel1.SuspendLayout();
            this.OuterSplitter.Panel2.SuspendLayout();
            this.OuterSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftVertSplitter)).BeginInit();
            this.LeftVertSplitter.Panel2.SuspendLayout();
            this.LeftVertSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectListSplitter)).BeginInit();
            this.ObjectListSplitter.Panel1.SuspendLayout();
            this.ObjectListSplitter.Panel2.SuspendLayout();
            this.ObjectListSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FixedInnerSplitter)).BeginInit();
            this.FixedInnerSplitter.Panel1.SuspendLayout();
            this.FixedInnerSplitter.Panel2.SuspendLayout();
            this.FixedInnerSplitter.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OuterSplitter
            // 
            this.OuterSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OuterSplitter.Location = new System.Drawing.Point(0, 27);
            this.OuterSplitter.Name = "OuterSplitter";
            // 
            // OuterSplitter.Panel1
            // 
            this.OuterSplitter.Panel1.Controls.Add(this.LeftVertSplitter);
            // 
            // OuterSplitter.Panel2
            // 
            this.OuterSplitter.Panel2.Controls.Add(this.FixedInnerSplitter);
            this.OuterSplitter.Size = new System.Drawing.Size(940, 423);
            this.OuterSplitter.SplitterDistance = 225;
            this.OuterSplitter.TabIndex = 0;
            this.OuterSplitter.TabStop = false;
            // 
            // LeftVertSplitter
            // 
            this.LeftVertSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftVertSplitter.Location = new System.Drawing.Point(0, 0);
            this.LeftVertSplitter.Name = "LeftVertSplitter";
            this.LeftVertSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LeftVertSplitter.Panel1
            // 
            this.LeftVertSplitter.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // LeftVertSplitter.Panel2
            // 
            this.LeftVertSplitter.Panel2.Controls.Add(this.ObjectListSplitter);
            this.LeftVertSplitter.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeftVertSplitter.Size = new System.Drawing.Size(225, 423);
            this.LeftVertSplitter.SplitterDistance = 170;
            this.LeftVertSplitter.TabIndex = 1;
            this.LeftVertSplitter.TabStop = false;
            // 
            // ObjectListSplitter
            // 
            this.ObjectListSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectListSplitter.Location = new System.Drawing.Point(0, 0);
            this.ObjectListSplitter.Name = "ObjectListSplitter";
            this.ObjectListSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ObjectListSplitter.Panel1
            // 
            this.ObjectListSplitter.Panel1.Controls.Add(this.LBObjects);
            // 
            // ObjectListSplitter.Panel2
            // 
            this.ObjectListSplitter.Panel2.Controls.Add(this.label4);
            this.ObjectListSplitter.Panel2.Controls.Add(this.label3);
            this.ObjectListSplitter.Panel2.Controls.Add(this.label2);
            this.ObjectListSplitter.Panel2.Controls.Add(this.label1);
            this.ObjectListSplitter.Panel2.Controls.Add(this.TBHeight);
            this.ObjectListSplitter.Panel2.Controls.Add(this.TBWidth);
            this.ObjectListSplitter.Panel2.Controls.Add(this.TBOffsetV);
            this.ObjectListSplitter.Panel2.Controls.Add(this.TBOffsetU);
            this.ObjectListSplitter.Panel2.Controls.Add(this.btnUpdate);
            this.ObjectListSplitter.Panel2.Controls.Add(this.TBObjectName);
            this.ObjectListSplitter.Panel2.Controls.Add(this.btnErase);
            this.ObjectListSplitter.Panel2.Controls.Add(this.btnAdd);
            this.ObjectListSplitter.Size = new System.Drawing.Size(225, 249);
            this.ObjectListSplitter.SplitterDistance = 110;
            this.ObjectListSplitter.TabIndex = 0;
            this.ObjectListSplitter.TabStop = false;
            // 
            // LBObjects
            // 
            this.LBObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBObjects.FormattingEnabled = true;
            this.LBObjects.ItemHeight = 12;
            this.LBObjects.Location = new System.Drawing.Point(0, 0);
            this.LBObjects.Name = "LBObjects";
            this.LBObjects.Size = new System.Drawing.Size(225, 110);
            this.LBObjects.TabIndex = 2;
            this.LBObjects.SelectedIndexChanged += new System.EventHandler(this.LBObjects_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "세로 크기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "가로 크기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "오프셋 V";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "오프셋 U";
            // 
            // TBHeight
            // 
            this.TBHeight.Location = new System.Drawing.Point(70, 115);
            this.TBHeight.Name = "TBHeight";
            this.TBHeight.Size = new System.Drawing.Size(60, 21);
            this.TBHeight.TabIndex = 4;
            // 
            // TBWidth
            // 
            this.TBWidth.Location = new System.Drawing.Point(70, 88);
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(60, 21);
            this.TBWidth.TabIndex = 3;
            // 
            // TBOffsetV
            // 
            this.TBOffsetV.Location = new System.Drawing.Point(70, 61);
            this.TBOffsetV.Name = "TBOffsetV";
            this.TBOffsetV.Size = new System.Drawing.Size(60, 21);
            this.TBOffsetV.TabIndex = 2;
            // 
            // TBOffsetU
            // 
            this.TBOffsetU.Location = new System.Drawing.Point(70, 31);
            this.TBOffsetU.Name = "TBOffsetU";
            this.TBOffsetU.Size = new System.Drawing.Size(60, 21);
            this.TBOffsetU.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(136, 61);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(54, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "적용";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TBObjectName
            // 
            this.TBObjectName.Location = new System.Drawing.Point(3, 4);
            this.TBObjectName.Name = "TBObjectName";
            this.TBObjectName.Size = new System.Drawing.Size(127, 21);
            this.TBObjectName.TabIndex = 0;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(136, 31);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(54, 23);
            this.btnErase.TabIndex = 6;
            this.btnErase.Text = "제거";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FixedInnerSplitter
            // 
            this.FixedInnerSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FixedInnerSplitter.IsSplitterFixed = true;
            this.FixedInnerSplitter.Location = new System.Drawing.Point(0, 0);
            this.FixedInnerSplitter.Name = "FixedInnerSplitter";
            this.FixedInnerSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // FixedInnerSplitter.Panel1
            // 
            this.FixedInnerSplitter.Panel1.Controls.Add(this.LabelSelection);
            this.FixedInnerSplitter.Panel1.Controls.Add(this.LabelDistance);
            this.FixedInnerSplitter.Panel1.Controls.Add(this.LabelMousePosFixed);
            this.FixedInnerSplitter.Panel1.Controls.Add(this.LabelMousePos);
            // 
            // FixedInnerSplitter.Panel2
            // 
            this.FixedInnerSplitter.Panel2.Controls.Add(this.hScrollBar1);
            this.FixedInnerSplitter.Panel2.Controls.Add(this.vScrollBar1);
            this.FixedInnerSplitter.Size = new System.Drawing.Size(711, 423);
            this.FixedInnerSplitter.SplitterDistance = 25;
            this.FixedInnerSplitter.TabIndex = 0;
            this.FixedInnerSplitter.TabStop = false;
            // 
            // LabelDistance
            // 
            this.LabelDistance.AutoSize = true;
            this.LabelDistance.Location = new System.Drawing.Point(568, 9);
            this.LabelDistance.Name = "LabelDistance";
            this.LabelDistance.Size = new System.Drawing.Size(87, 12);
            this.LabelDistance.TabIndex = 2;
            this.LabelDistance.Text = "거리 (000, 000)";
            // 
            // LabelMousePosFixed
            // 
            this.LabelMousePosFixed.AutoSize = true;
            this.LabelMousePosFixed.Location = new System.Drawing.Point(160, 9);
            this.LabelMousePosFixed.Name = "LabelMousePosFixed";
            this.LabelMousePosFixed.Size = new System.Drawing.Size(115, 12);
            this.LabelMousePosFixed.TabIndex = 1;
            this.LabelMousePosFixed.Text = "고정 좌표 (000, 000)";
            // 
            // LabelMousePos
            // 
            this.LabelMousePos.AutoSize = true;
            this.LabelMousePos.Location = new System.Drawing.Point(3, 9);
            this.LabelMousePos.Name = "LabelMousePos";
            this.LabelMousePos.Size = new System.Drawing.Size(127, 12);
            this.LabelMousePos.TabIndex = 0;
            this.LabelMousePos.Text = "마우스 좌표 (000, 000)";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 377);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(694, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(694, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 394);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(940, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.불러오기ToolStripMenuItem,
            this.저장하기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "openFileDialog1";
            // 
            // LabelSelection
            // 
            this.LabelSelection.AutoSize = true;
            this.LabelSelection.Location = new System.Drawing.Point(311, 9);
            this.LabelSelection.Name = "LabelSelection";
            this.LabelSelection.Size = new System.Drawing.Size(213, 12);
            this.LabelSelection.TabIndex = 3;
            this.LabelSelection.Text = "선택 - 위치(000, 000) - 크기(000, 000)";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.OuterSplitter);
            this.Name = "MainFrm";
            this.Text = "DirectX11Tutorial Object Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFrm_KeyDown);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.OuterSplitter.Panel1.ResumeLayout(false);
            this.OuterSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OuterSplitter)).EndInit();
            this.OuterSplitter.ResumeLayout(false);
            this.LeftVertSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftVertSplitter)).EndInit();
            this.LeftVertSplitter.ResumeLayout(false);
            this.ObjectListSplitter.Panel1.ResumeLayout(false);
            this.ObjectListSplitter.Panel2.ResumeLayout(false);
            this.ObjectListSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectListSplitter)).EndInit();
            this.ObjectListSplitter.ResumeLayout(false);
            this.FixedInnerSplitter.Panel1.ResumeLayout(false);
            this.FixedInnerSplitter.Panel1.PerformLayout();
            this.FixedInnerSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FixedInnerSplitter)).EndInit();
            this.FixedInnerSplitter.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer OuterSplitter;
        private System.Windows.Forms.SplitContainer LeftVertSplitter;
        private System.Windows.Forms.SplitContainer FixedInnerSplitter;
        private System.Windows.Forms.Label LabelMousePos;
        private System.Windows.Forms.SplitContainer ObjectListSplitter;
        private System.Windows.Forms.ListBox LBObjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.TextBox TBObjectName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox TBOffsetV;
        private System.Windows.Forms.TextBox TBOffsetU;
        private System.Windows.Forms.TextBox TBHeight;
        private System.Windows.Forms.TextBox TBWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelMousePosFixed;
        private System.Windows.Forms.Label LabelDistance;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
        private System.Windows.Forms.SaveFileDialog DlgSave;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label LabelSelection;
    }
}