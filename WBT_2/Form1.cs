using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WBT_2
{
    public partial class Form1 : Form
    {
        private const string PlaceholderText = "Enter the node";
        private const int NodeRadius = 20;
        private const int NodeGap = 60;

        private readonly WeightBalancedTree tree = new WeightBalancedTree();
        private int? highlightedKey = null;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyMenuColors());
            SetMenuTextColor(menuStrip1.Items, Color.White);
            showWeightsToolStripMenuItem.CheckOnClick = true;

            txtInput.Text = PlaceholderText;
            txtInput.ForeColor = Color.Gray;

            txtInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd_Click(this, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
            };
        }

        // ─── Кнопки ──────────────────────────────────────────────────────────

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryGetInput(out int val)) return;

            if (tree.Search(tree.Root, val))
                MessageBox.Show("Such an element already exists!");
            else
            {
                tree.Insert(val);
                highlightedKey = val;
            }

            txtInput.Clear();
            canvas.Invalidate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!TryGetInput(out int val)) return;

            if (tree.Search(tree.Root, val))
                highlightedKey = val;
            else
            {
                highlightedKey = null;
                MessageBox.Show("Element not found");
            }

            canvas.Invalidate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetInput(out int val)) return;

            if (tree.Search(tree.Root, val))
            {
                tree.Delete(val);
                highlightedKey = null;
            }
            else
            {
                MessageBox.Show("Element not found for deletion");
            }

            txtInput.Clear();
            canvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tree.Root = null;
            highlightedKey = null;
            canvas.Invalidate();
        }

        // ─── Отрисовка ───────────────────────────────────────────────────────

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (tree.Root != null)
                DrawNode(e.Graphics, tree.Root, canvas.Width / 2, 40, canvas.Width / 4);
        }

        private void DrawNode(Graphics g, WBTNode node, int x, int y, int xOffset)
        {
            if (node.Left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - xOffset, y + NodeGap);
                DrawNode(g, node.Left, x - xOffset, y + NodeGap, xOffset / 2);
            }
            if (node.Right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + xOffset, y + NodeGap);
                DrawNode(g, node.Right, x + xOffset, y + NodeGap, xOffset / 2);
            }

            var fill = node.Key == highlightedKey ? Brushes.Gold : Brushes.White;
            var rect = new Rectangle(x - NodeRadius, y - NodeRadius, NodeRadius * 2, NodeRadius * 2);
            g.FillEllipse(fill, rect);
            g.DrawEllipse(Pens.Black, rect);

            DrawCenteredString(g, node.Key.ToString(), Font, Brushes.Black, x, y);

            if (showWeightsToolStripMenuItem.Checked)
            {
                string sizeTxt = $"s:{node.Size}";
                var sSize = g.MeasureString(sizeTxt, Font);
                g.DrawString(sizeTxt, Font, Brushes.Green, x - sSize.Width / 2, y + NodeRadius + 2);
            }
        }

        private void DrawCenteredString(Graphics g, string text, Font font, Brush brush, float cx, float cy)
        {
            var size = g.MeasureString(text, font);
            g.DrawString(text, font, brush, cx - size.Width / 2, cy - size.Height / 2);
        }

        // ─── Файловые операции ───────────────────────────────────────────────

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Text Files (*.txt)|*.txt" })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var parts = System.IO.File.ReadAllText(ofd.FileName)
                        .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 0) { MessageBox.Show("The file is empty."); return; }

                    tree.Root = null;
                    int count = 0;

                    foreach (var p in parts)
                    {
                        if (int.TryParse(p, out int val) && !tree.Search(tree.Root, val))
                        {
                            tree.Insert(val);
                            count++;
                        }
                    }

                    highlightedKey = null;
                    canvas.Invalidate();
                    MessageBox.Show($"Loading complete. Nodes added: {count}");
                }
                catch (Exception ex) { MessageBox.Show($"File read error: {ex.Message}"); }
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e) => SaveTreeToFile();
        private void saveAsTxtToolStripMenuItem_Click(object sender, EventArgs e) => SaveTreeToFile();

        private void SaveTreeToFile()
        {
            if (tree.Root == null) { MessageBox.Show("The tree is empty. There is nothing to upload."); return; }

            using (var sfd = new SaveFileDialog { Filter = "Text Files (*.txt)|*.txt", DefaultExt = "txt", FileName = "my_tree_data" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var keys = new List<int>();
                    GetAllKeys(tree.Root, keys);
                    System.IO.File.WriteAllText(sfd.FileName, string.Join(" ", keys));
                    MessageBox.Show("The tree has been successfully saved to file.");
                }
                catch (Exception ex) { MessageBox.Show($"Error saving: {ex.Message}"); }
            }
        }

        private void GetAllKeys(WBTNode node, List<int> list)
        {
            if (node == null) return;
            GetAllKeys(node.Left, list);
            list.Add(node.Key);
            GetAllKeys(node.Right, list);
        }

        private void saveAsPngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tree.Root == null) { MessageBox.Show("The tree is empty, there is nothing to save."); return; }

            using (var sfd = new SaveFileDialog { Filter = "PNG Image|*.png|JPEG Image|*.jpg", FileName = "wbt_tree_export" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var bmp = new Bitmap(canvas.Width, canvas.Height))
                using (var g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.Clear(Color.White);
                    DrawNode(g, tree.Root, canvas.Width / 2, 40, canvas.Width / 4);

                    var format = sfd.FileName.EndsWith(".jpg")
                        ? System.Drawing.Imaging.ImageFormat.Jpeg
                        : System.Drawing.Imaging.ImageFormat.Png;

                    try { bmp.Save(sfd.FileName, format); MessageBox.Show("Image saved successfully!"); }
                    catch (Exception ex) { MessageBox.Show($"Error saving: {ex.Message}"); }
                }
            }
        }

        // ─── Тема, меню, утилиты ─────────────────────────────────────────────

        private void swithThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isDark = canvas.BackColor != Color.White;
            canvas.BackColor = isDark ? Color.White : Color.FromArgb(37, 37, 38);
            panel1.BackColor = isDark ? Color.FromArgb(240, 240, 240) : Color.FromArgb(31, 31, 31);
        }

        private void SetMenuTextColor(ToolStripItemCollection items, Color color)
        {
            foreach (ToolStripItem item in items)
            {
                item.ForeColor = color;
                if (item is ToolStripMenuItem menuItem)
                    SetMenuTextColor(menuItem.DropDownItems, color);
            }
        }

        private void showWeightsToolStripMenuItem_Click(object sender, EventArgs e) => canvas.Invalidate();

        private void faQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "WBT-TREE VISUALIZATION PROGRAM\n\n" +
                "WBT (Weight-Balanced Tree) is a weight-balanced search tree.\n\n" +
                "MAIN FUNCTIONS:\n" +
                "• Add: inserts a new node (integer) and balances the tree.\n" +
                "• Delete: removes a node with automatic rebalancing.\n" +
                "• Find: highlights the node in gold.\n" +
                "• Clear: completely removes all nodes.\n\n" +
                "FILE MANAGEMENT:\n" +
                "• Unload: saves the current keys to a text file.\n" +
                "• Load: builds a tree from numbers read from a file.\n\n" +
                "BALANCE PARAMETERS:\n" +
                "The program uses Omega = 2. Node label 's' shows subtree size.",
                "FaQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── Placeholder для txtInput ─────────────────────────────────────────

        private void txtInput_Enter_1(object sender, EventArgs e)
        {
            if (txtInput.Text == PlaceholderText)
            {
                txtInput.Text = "";
                txtInput.ForeColor = Color.Black;
            }
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                txtInput.Text = PlaceholderText;
                txtInput.ForeColor = Color.Gray;
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '-' && !txtInput.Text.Contains("-") && txtInput.SelectionStart == 0) return;
            e.Handled = true;
        }

        // ─── Win32 / прочее ───────────────────────────────────────────────────

        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void closeAppToolStripMenuItem1_Click(object sender, EventArgs e) => Close();
        private void toolStripMenuItem1_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        // ─── Вспомогательное ─────────────────────────────────────────────────

        private bool TryGetInput(out int val) => int.TryParse(txtInput.Text, out val);
    }
}