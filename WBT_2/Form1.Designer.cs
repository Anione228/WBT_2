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
            label1 = new Label();
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
            swithThemeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            showWeightsToolStripMenuItem = new ToolStripMenuItem();
            xToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            faQToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(0, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add node";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(0, 98);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(210, 35);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(0, 139);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(210, 35);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(downloadBtn);
            panel1.Controls.Add(uploadBtn);
            panel1.Controls.Add(txtInput);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(674, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 581);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(6, 218);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 8;
            // 
            // downloadBtn
            // 
            downloadBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            downloadBtn.IconColor = Color.Black;
            downloadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            downloadBtn.Location = new Point(3, 528);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(97, 50);
            downloadBtn.TabIndex = 7;
            toolTip1.SetToolTip(downloadBtn, "Download");
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // uploadBtn
            // 
            uploadBtn.Anchor = AnchorStyles.Bottom;
            uploadBtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            uploadBtn.IconColor = Color.Black;
            uploadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            uploadBtn.Location = new Point(106, 528);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(101, 50);
            uploadBtn.TabIndex = 6;
            toolTip1.SetToolTip(uploadBtn, "Upload tree from text file");
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Times New Roman", 18F);
            txtInput.Location = new Point(0, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(210, 39);
            txtInput.TabIndex = 5;
            txtInput.TextAlign = HorizontalAlignment.Center;
            txtInput.Enter += txtInput_Enter_1;
            txtInput.KeyPress += txtInput_KeyPress;
            txtInput.Leave += txtInput_Leave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(0, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(210, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // canvas
            // 
            canvas.BackColor = Color.FromArgb(37, 37, 38);
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(0, 30);
            canvas.Name = "canvas";
            canvas.Size = new Size(674, 581);
            canvas.TabIndex = 4;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(45, 45, 48);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, vievToolStripMenuItem, optionsToolStripMenuItem, xToolStripMenuItem, toolStripMenuItem1, faQToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(884, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.MouseDown += menuStrip1_MouseDown;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsTxtToolStripMenuItem, saveAsPngToolStripMenuItem, toolStripMenuItem3, closeAppToolStripMenuItem, toolStripMenuItem2, closeAppToolStripMenuItem1 });
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.Image = (Image)resources.GetObject("fileToolStripMenuItem.Image");
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 26);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveAsTxtToolStripMenuItem
            // 
            saveAsTxtToolStripMenuItem.BackColor = SystemColors.Control;
            saveAsTxtToolStripMenuItem.ForeColor = Color.Black;
            saveAsTxtToolStripMenuItem.Name = "saveAsTxtToolStripMenuItem";
            saveAsTxtToolStripMenuItem.Size = new Size(157, 22);
            saveAsTxtToolStripMenuItem.Text = "Save as txt";
            saveAsTxtToolStripMenuItem.Click += saveAsTxtToolStripMenuItem_Click;
            // 
            // saveAsPngToolStripMenuItem
            // 
            saveAsPngToolStripMenuItem.ForeColor = Color.Black;
            saveAsPngToolStripMenuItem.Name = "saveAsPngToolStripMenuItem";
            saveAsPngToolStripMenuItem.Size = new Size(157, 22);
            saveAsPngToolStripMenuItem.Text = "Save as picture";
            saveAsPngToolStripMenuItem.Click += saveAsPngToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(154, 6);
            // 
            // closeAppToolStripMenuItem
            // 
            closeAppToolStripMenuItem.ForeColor = Color.Black;
            closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            closeAppToolStripMenuItem.Size = new Size(157, 22);
            closeAppToolStripMenuItem.Text = "Fill tree from txt";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(154, 6);
            // 
            // closeAppToolStripMenuItem1
            // 
            closeAppToolStripMenuItem1.ForeColor = Color.Black;
            closeAppToolStripMenuItem1.Name = "closeAppToolStripMenuItem1";
            closeAppToolStripMenuItem1.Size = new Size(157, 22);
            closeAppToolStripMenuItem1.Text = "Close app";
            closeAppToolStripMenuItem1.Click += closeAppToolStripMenuItem1_Click;
            // 
            // vievToolStripMenuItem
            // 
            vievToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { swithThemeToolStripMenuItem });
            vievToolStripMenuItem.ForeColor = Color.White;
            vievToolStripMenuItem.Name = "vievToolStripMenuItem";
            vievToolStripMenuItem.Size = new Size(44, 26);
            vievToolStripMenuItem.Text = "View";
            // 
            // swithThemeToolStripMenuItem
            // 
            swithThemeToolStripMenuItem.Name = "swithThemeToolStripMenuItem";
            swithThemeToolStripMenuItem.Size = new Size(143, 22);
            swithThemeToolStripMenuItem.Text = "Swith Theme";
            swithThemeToolStripMenuItem.Click += swithThemeToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showWeightsToolStripMenuItem });
            optionsToolStripMenuItem.ForeColor = Color.White;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 26);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // showWeightsToolStripMenuItem
            // 
            showWeightsToolStripMenuItem.Checked = true;
            showWeightsToolStripMenuItem.CheckState = CheckState.Checked;
            showWeightsToolStripMenuItem.Name = "showWeightsToolStripMenuItem";
            showWeightsToolStripMenuItem.Size = new Size(150, 22);
            showWeightsToolStripMenuItem.Text = "Show weights ";
            showWeightsToolStripMenuItem.Click += showWeightsToolStripMenuItem_Click;
            // 
            // xToolStripMenuItem
            // 
            xToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            xToolStripMenuItem.AutoSize = false;
            xToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            xToolStripMenuItem.Font = new Font("Segoe Fluent Icons", 9F, FontStyle.Bold);
            xToolStripMenuItem.Image = (Image)resources.GetObject("xToolStripMenuItem.Image");
            xToolStripMenuItem.Name = "xToolStripMenuItem";
            xToolStripMenuItem.Size = new Size(40, 30);
            xToolStripMenuItem.Click += xToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Font = new Font("Marlett", 9F, FontStyle.Bold);
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(40, 30);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // faQToolStripMenuItem
            // 
            faQToolStripMenuItem.Name = "faQToolStripMenuItem";
            faQToolStripMenuItem.Size = new Size(40, 26);
            faQToolStripMenuItem.Text = "FaQ";
            faQToolStripMenuItem.Click += faQToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(884, 611);
            Controls.Add(canvas);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "WBT Tree";
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
        private ToolStripMenuItem swithThemeToolStripMenuItem;
        private ToolStripMenuItem faQToolStripMenuItem;
        private ToolStripMenuItem showWeightsToolStripMenuItem;
        private Label label1;
    }
}
