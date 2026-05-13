using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WBT_2
{
    public partial class Form1 : Form
    {
        private WeightBalancedTree tree = new WeightBalancedTree();
        private int? highlightedKey = null;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyMenuColors());
            // Настраиваем Enter для текстового поля
            txtInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd_Click(this, new EventArgs());
                    e.SuppressKeyPress = true; // Убирает звук "бип"
                }
            };
        }

        public WeightBalancedTree WeightBalancedTree
        {
            get => default;
            set
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int val))
            {
                if (tree.Search(tree.Root, val))
                {
                    MessageBox.Show("Такой элемент уже есть!");
                }
                else
                {
                    tree.Insert(val);
                    highlightedKey = val;
                }
                txtInput.Clear();
                canvas.Invalidate();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int val))
            {
                if (tree.Search(tree.Root, val)) highlightedKey = val;
                else { highlightedKey = null; MessageBox.Show("Не найдено"); }
                canvas.Invalidate();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // Убедись, что кнопка называется btnDelete
        {
            if (int.TryParse(txtInput.Text, out int val))
            {
                if (tree.Search(tree.Root, val))
                {
                    tree.Delete(val);
                    highlightedKey = null;
                }
                else
                {
                    MessageBox.Show("Элемент не найден для удаления");
                }
                txtInput.Clear();
                canvas.Invalidate();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tree.Root = null;
            highlightedKey = null;
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (tree.Root != null)
                DrawNode(e.Graphics, tree.Root, canvas.Width / 2, 40, canvas.Width / 4);
        }

        private void DrawNode(Graphics g, WBTNode node, int x, int y, int xOffset)
        {
            const int radius = 20;
            const int gap = 60;

            if (node.Left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - xOffset, y + gap);
                DrawNode(g, node.Left, x - xOffset, y + gap, xOffset / 2);
            }
            if (node.Right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + xOffset, y + gap);
                DrawNode(g, node.Right, x + xOffset, y + gap, xOffset / 2);
            }

            var fill = (node.Key == highlightedKey) ? Brushes.Gold : Brushes.White;
            g.FillEllipse(fill, x - radius, y - radius, radius * 2, radius * 2);
            g.DrawEllipse(Pens.Black, x - radius, y - radius, radius * 2, radius * 2);

            string txt = node.Key.ToString();
            var size = g.MeasureString(txt, this.Font);
            g.DrawString(txt, this.Font, Brushes.Black, x - size.Width / 2, y - size.Height / 2);
            g.DrawString($"s:{node.Size}", this.Font, Brushes.Blue, x - 10, y + radius + 2);
        }

        // 1. ВЫГРУЗИТЬ (Сохранение структуры дерева в файл)
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (tree.Root == null)
            {
                MessageBox.Show("Дерево пустое. Нечего выгружать.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                sfd.FileName = "my_tree_data";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Собираем все ключи дерева в список (в порядке возрастания - InOrder)
                        List<int> keys = new List<int>();
                        GetAllKeys(tree.Root, keys);

                        // Сохраняем ключи через пробел
                        System.IO.File.WriteAllText(sfd.FileName, string.Join(" ", keys));
                        MessageBox.Show("Дерево успешно сохранено в файл.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                    }
                }
            }
        }

        // Вспомогательный метод для сбора всех ключей (рекурсивный)
        private void GetAllKeys(WBTNode node, List<int> list)
        {
            if (node == null) return;
            GetAllKeys(node.Left, list);
            list.Add(node.Key);
            GetAllKeys(node.Right, list);
        }

        // 2. ЗАГРУЗИТЬ (Чтение из файла и построение дерева)
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = System.IO.File.ReadAllText(ofd.FileName);
                        // Разделяем строку по пробелам, запятым или переносам строк
                        string[] parts = content.Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length == 0)
                        {
                            MessageBox.Show("Файл пуст.");
                            return;
                        }

                        // Очищаем текущее дерево перед загрузкой (по желанию)
                        tree.Root = null;
                        int count = 0;

                        foreach (string p in parts)
                        {
                            // Проверка: является ли значение целым числом
                            if (int.TryParse(p, out int val))
                            {
                                // Проверка на дубликаты перед вставкой
                                if (!tree.Search(tree.Root, val))
                                {
                                    tree.Insert(val);
                                    count++;
                                }
                            }
                        }

                        highlightedKey = null;
                        canvas.Invalidate(); // Перерисовываем
                        MessageBox.Show($"Загрузка завершена. Добавлено узлов: {count}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
                    }
                }
            }
        }

        // 3. СПРАВКА (Информация о программе)
        private void infoBtn_Click(object sender, EventArgs e)
        {
            string info = "ПРОГРАММА ВИЗУАЛИЗАЦИИ WBT-ДЕРЕВА\n\n" +
                          "WBT (Weight-Balanced Tree) — это весово-сбалансированное дерево поиска.\n\n" +
                          "ОСНОВНЫЕ ФУНКЦИИ:\n" +
                          "• Добавить: вставляет новый узел (целое число) и балансирует дерево.\n" +
                          "• Удалить: удаляет узел с автоматической перебалансировкой.\n" +
                          "• Найти: подсвечивает узел золотистым цветом.\n" +
                          "• Очистить: полностью удаляет все узлы.\n\n" +
                          "УПРАВЛЕНИЕ ФАЙЛАМИ:\n" +
                          "• Выгрузить: сохраняет текущие ключи в текстовый файл.\n" +
                          "• Загрузить: строит дерево из чисел, считанных из файла.\n\n" +
                          "ПАРАМЕТРЫ БАЛАНСА:\n" +
                          "Программа использует коэффициент Omega = 2. Узел подписывается весом 's' (размер поддерева).";

            MessageBox.Show(info, "Справка по программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void txtInput_Enter(object sender, EventArgs e) => txtInput.Clear();

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // В конструкторе или в Form_Load
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.DropDown is ToolStripDropDownMenu menu)
                {
                    menu.ShowImageMargin = false;
                    menu.ShowCheckMargin = false; // На всякий случай убираем и это
                }
            }
        }
        private void SaveCanvasImage()
        {
            if (tree.Root == null)
            {
                MessageBox.Show("Дерево пустое, нечего сохранять.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
                sfd.Title = "Сохранить визуализацию дерева";
                sfd.FileName = "wbt_tree_export";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // 1. Создаем Bitmap размером с ваш canvas
                    Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);

                    // 2. Создаем объект Graphics для рисования на этом Bitmap
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        // Настраиваем качество (как в вашем методе Paint)
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.Clear(Color.White); // Заливаем фон белым (чтобы не был прозрачным в JPG)

                        // 3. Вызываем ваш существующий метод отрисовки дерева
                        DrawNode(g, tree.Root, canvas.Width / 2, 40, canvas.Width / 4);
                    }

                    // 4. Определяем формат и сохраняем
                    System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
                    if (sfd.FileName.EndsWith(".jpg")) format = System.Drawing.Imaging.ImageFormat.Jpeg;

                    try
                    {
                        bmp.Save(sfd.FileName, format);
                        MessageBox.Show("Изображение успешно сохранено!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                    }
                    finally
                    {
                        bmp.Dispose(); // Освобождаем память
                    }
                }
            }
        }

        private void saveAsPngToolStripMenuItem_Click(object sender, EventArgs e) => SaveCanvasImage();

    }
}