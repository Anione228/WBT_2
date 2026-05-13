namespace WBT_2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            panel1 = new Panel();
            infoBtn = new FontAwesome.Sharp.IconButton();
            downloadBtn = new FontAwesome.Sharp.IconButton();
            uploadBtn = new FontAwesome.Sharp.IconButton();
            txtInput = new TextBox();
            btnDelete = new Button();
            canvas = new PictureBox();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAsTxtToolStripMenuItem = new ToolStripMenuItem();
            saveAsPngToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            closeAppToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            closeAppToolStripMenuItem1 = new ToolStripMenuItem();
            vievToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            xToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnAdd.Name = "btnAdd";
            toolTip1.SetToolTip(btnAdd, resources.GetString("btnAdd.ToolTip"));
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Name = "btnSearch";
            toolTip1.SetToolTip(btnSearch, resources.GetString("btnSearch.ToolTip"));
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnClear.Name = "btnClear";
            toolTip1.SetToolTip(btnClear, resources.GetString("btnClear.ToolTip"));
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(infoBtn);
            panel1.Controls.Add(downloadBtn);
            panel1.Controls.Add(uploadBtn);
            panel1.Controls.Add(txtInput);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnClear);
            panel1.Name = "panel1";
            toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // infoBtn
            // 
            resources.ApplyResources(infoBtn, "infoBtn");
            infoBtn.IconChar = FontAwesome.Sharp.IconChar.Info;
            infoBtn.IconColor = Color.Black;
            infoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            infoBtn.Name = "infoBtn";
            toolTip1.SetToolTip(infoBtn, resources.GetString("infoBtn.ToolTip"));
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // downloadBtn
            // 
            resources.ApplyResources(downloadBtn, "downloadBtn");
            downloadBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            downloadBtn.IconColor = Color.Black;
            downloadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            downloadBtn.Name = "downloadBtn";
            toolTip1.SetToolTip(downloadBtn, resources.GetString("downloadBtn.ToolTip"));
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // uploadBtn
            // 
            resources.ApplyResources(uploadBtn, "uploadBtn");
            uploadBtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            uploadBtn.IconColor = Color.Black;
            uploadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            uploadBtn.Name = "uploadBtn";
            toolTip1.SetToolTip(uploadBtn, resources.GetString("uploadBtn.ToolTip"));
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // txtInput
            // 
            resources.ApplyResources(txtInput, "txtInput");
            txtInput.Name = "txtInput";
            toolTip1.SetToolTip(txtInput, resources.GetString("txtInput.ToolTip"));
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Name = "btnDelete";
            toolTip1.SetToolTip(btnDelete, resources.GetString("btnDelete.ToolTip"));
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // canvas
            // 
            resources.ApplyResources(canvas, "canvas");
            canvas.BackColor = Color.FromArgb(37, 37, 38);
            canvas.Name = "canvas";
            canvas.TabStop = false;
            toolTip1.SetToolTip(canvas, resources.GetString("canvas.ToolTip"));
            canvas.Paint += canvas_Paint;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = Color.FromArgb(45, 45, 48);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, vievToolStripMenuItem, optionsToolStripMenuItem, xToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolTip1.SetToolTip(menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            menuStrip1.MouseDown += menuStrip1_MouseDown;
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsTxtToolStripMenuItem, saveAsPngToolStripMenuItem, toolStripMenuItem3, closeAppToolStripMenuItem, toolStripMenuItem2, closeAppToolStripMenuItem1 });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // saveAsTxtToolStripMenuItem
            // 
            resources.ApplyResources(saveAsTxtToolStripMenuItem, "saveAsTxtToolStripMenuItem");
            saveAsTxtToolStripMenuItem.ForeColor = Color.White;
            saveAsTxtToolStripMenuItem.Name = "saveAsTxtToolStripMenuItem";
            // 
            // saveAsPngToolStripMenuItem
            // 
            resources.ApplyResources(saveAsPngToolStripMenuItem, "saveAsPngToolStripMenuItem");
            saveAsPngToolStripMenuItem.ForeColor = Color.White;
            saveAsPngToolStripMenuItem.Name = "saveAsPngToolStripMenuItem";
            saveAsPngToolStripMenuItem.Click += saveAsPngToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(toolStripMenuItem3, "toolStripMenuItem3");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // closeAppToolStripMenuItem
            // 
            resources.ApplyResources(closeAppToolStripMenuItem, "closeAppToolStripMenuItem");
            closeAppToolStripMenuItem.ForeColor = Color.White;
            closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(toolStripMenuItem2, "toolStripMenuItem2");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // closeAppToolStripMenuItem1
            // 
            resources.ApplyResources(closeAppToolStripMenuItem1, "closeAppToolStripMenuItem1");
            closeAppToolStripMenuItem1.ForeColor = Color.White;
            closeAppToolStripMenuItem1.Name = "closeAppToolStripMenuItem1";
            // 
            // vievToolStripMenuItem
            // 
            resources.ApplyResources(vievToolStripMenuItem, "vievToolStripMenuItem");
            vievToolStripMenuItem.ForeColor = Color.White;
            vievToolStripMenuItem.Name = "vievToolStripMenuItem";
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(optionsToolStripMenuItem, "optionsToolStripMenuItem");
            optionsToolStripMenuItem.ForeColor = Color.White;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            // 
            // xToolStripMenuItem
            // 
            resources.ApplyResources(xToolStripMenuItem, "xToolStripMenuItem");
            xToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            xToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            xToolStripMenuItem.Name = "xToolStripMenuItem";
            xToolStripMenuItem.Click += xToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            Controls.Add(canvas);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnSearch;
        private Button btnClear;
        private Panel panel1;
        private PictureBox canvas;
        private TextBox txtInput;
        private Button btnDelete;
        private FontAwesome.Sharp.IconButton downloadBtn;
        private FontAwesome.Sharp.IconButton uploadBtn;
        private FontAwesome.Sharp.IconButton infoBtn;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem vievToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsTxtToolStripMenuItem;
        private ToolStripMenuItem saveAsPngToolStripMenuItem;
        private ToolStripMenuItem closeAppToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem closeAppToolStripMenuItem1;
    }
}
