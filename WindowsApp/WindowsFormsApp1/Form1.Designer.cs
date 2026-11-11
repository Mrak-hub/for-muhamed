namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохраниттьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печтьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbon = new System.Windows.Forms.ToolStrip();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnResize = new System.Windows.Forms.ToolStripDropDownButton();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRotate = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.на90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на45ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPencil = new System.Windows.Forms.ToolStripButton();
            this.btnFill = new System.Windows.Forms.ToolStripButton();
            this.btnText = new System.Windows.Forms.ToolStripButton();
            this.btnEraser = new System.Windows.Forms.ToolStripButton();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBrushes = new System.Windows.Forms.ToolStripDropDownButton();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShapes = new System.Windows.Forms.ToolStripDropDownButton();
            this.sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSizeLines = new System.Windows.Forms.ToolStripDropDownButton();
            this.sep6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditColors = new System.Windows.Forms.ToolStripButton();
            this.mainWorkspace = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button299 = new System.Windows.Forms.Button();
            this.button288 = new System.Windows.Forms.Button();
            this.button999 = new System.Windows.Forms.Button();
            this.button888 = new System.Windows.Forms.Button();
            this.button277 = new System.Windows.Forms.Button();
            this.button266 = new System.Windows.Forms.Button();
            this.button255 = new System.Windows.Forms.Button();
            this.button777 = new System.Windows.Forms.Button();
            this.button666 = new System.Windows.Forms.Button();
            this.button244 = new System.Windows.Forms.Button();
            this.button211 = new System.Windows.Forms.Button();
            this.button555 = new System.Windows.Forms.Button();
            this.button444 = new System.Windows.Forms.Button();
            this.button111 = new System.Windows.Forms.Button();
            this.button233 = new System.Windows.Forms.Button();
            this.button2221 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button333 = new System.Windows.Forms.Button();
            this.button222 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.Выделение1 = new System.Windows.Forms.GroupBox();
            this.button32 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ромбToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuBar.SuspendLayout();
            this.ribbon.SuspendLayout();
            this.mainWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.colorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.BackColor = System.Drawing.Color.White;
            this.mainMenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.homeMenu,
            this.viewMenu});
            this.mainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Size = new System.Drawing.Size(1214, 24);
            this.mainMenuBar.TabIndex = 0;
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохраниттьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.печтьToolStripMenuItem});
            this.fileMenu.ForeColor = System.Drawing.Color.White;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохраниттьToolStripMenuItem
            // 
            this.сохраниттьToolStripMenuItem.Name = "сохраниттьToolStripMenuItem";
            this.сохраниттьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохраниттьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить Как";
            // 
            // печтьToolStripMenuItem
            // 
            this.печтьToolStripMenuItem.Name = "печтьToolStripMenuItem";
            this.печтьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.печтьToolStripMenuItem.Text = "Печть";
            // 
            // homeMenu
            // 
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(63, 20);
            this.homeMenu.Text = "Главная";
            // 
            // viewMenu
            // 
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(39, 20);
            this.viewMenu.Text = "Вид";
            // 
            // ribbon
            // 
            this.ribbon.AutoSize = false;
            this.ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ribbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ribbon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ribbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPaste,
            this.sep1,
            this.btnSelect,
            this.btnResize,
            this.btnRotate,
            this.sep2,
            this.btnPencil,
            this.btnFill,
            this.btnText,
            this.btnEraser,
            this.sep3,
            this.btnBrushes,
            this.sep4,
            this.btnShapes,
            this.sep5,
            this.btnSizeLines,
            this.sep6});
            this.ribbon.Location = new System.Drawing.Point(0, 24);
            this.ribbon.Name = "ribbon";
            this.ribbon.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ribbon.Size = new System.Drawing.Size(1214, 95);
            this.ribbon.TabIndex = 1;
            this.ribbon.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ribbon_ItemClicked);
            // 
            // btnPaste
            // 
            this.btnPaste.AutoSize = false;
            this.btnPaste.AutoToolTip = false;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(58, 52);
            this.btnPaste.Text = "Вставить";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 95);
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = false;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(58, 52);
            this.btnSelect.Text = "Выделить";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnResize
            // 
            this.btnResize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem});
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(117, 92);
            this.btnResize.Text = "Изменить размер";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить ";
            // 
            // btnRotate
            // 
            this.btnRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.на90ToolStripMenuItem,
            this.на45ToolStripMenuItem,
            this.на30ToolStripMenuItem,
            this.на15ToolStripMenuItem,
            this.на10ToolStripMenuItem,
            this.на5ToolStripMenuItem,
            this.на1ToolStripMenuItem});
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(79, 92);
            this.btnRotate.Text = "Повернуть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem1.Text = "На 180*";
            // 
            // на90ToolStripMenuItem
            // 
            this.на90ToolStripMenuItem.Name = "на90ToolStripMenuItem";
            this.на90ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.на90ToolStripMenuItem.Text = "На 90*";
            // 
            // на45ToolStripMenuItem
            // 
            this.на45ToolStripMenuItem.Name = "на45ToolStripMenuItem";
            this.на45ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.на45ToolStripMenuItem.Text = "На 45*";
            // 
            // на30ToolStripMenuItem
            // 
            this.на30ToolStripMenuItem.Name = "на30ToolStripMenuItem";
            this.на30ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.на30ToolStripMenuItem.Text = "На 30*";
            // 
            // на15ToolStripMenuItem
            // 
            this.на15ToolStripMenuItem.Name = "на15ToolStripMenuItem";
            this.на15ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.на15ToolStripMenuItem.Text = "На 15*";
            this.на15ToolStripMenuItem.Click += new System.EventHandler(this.на15ToolStripMenuItem_Click);
            // 
            // на10ToolStripMenuItem
            // 
            this.на10ToolStripMenuItem.Name = "на10ToolStripMenuItem";
            this.на10ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.на10ToolStripMenuItem.Text = "На 10*";
            // 
            // на5ToolStripMenuItem
            // 
            this.на5ToolStripMenuItem.Name = "на5ToolStripMenuItem";
            this.на5ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.на5ToolStripMenuItem.Text = "На 5*";
            // 
            // на1ToolStripMenuItem
            // 
            this.на1ToolStripMenuItem.Name = "на1ToolStripMenuItem";
            this.на1ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.на1ToolStripMenuItem.Text = "На 1*";
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 95);
            // 
            // btnPencil
            // 
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(23, 92);
            this.btnPencil.Text = "✏️";
            // 
            // btnFill
            // 
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(23, 92);
            this.btnFill.Text = "🪣";
            // 
            // btnText
            // 
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(23, 92);
            this.btnText.Text = "A";
            // 
            // btnEraser
            // 
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(23, 92);
            this.btnEraser.Text = "🧽";
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(6, 95);
            // 
            // btnBrushes
            // 
            this.btnBrushes.AutoSize = false;
            this.btnBrushes.AutoToolTip = false;
            this.btnBrushes.Name = "btnBrushes";
            this.btnBrushes.Size = new System.Drawing.Size(52, 42);
            this.btnBrushes.Text = "Кисти";
            this.btnBrushes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(6, 95);
            // 
            // btnShapes
            // 
            this.btnShapes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.треугольникToolStripMenuItem,
            this.кругToolStripMenuItem,
            this.квадратToolStripMenuItem,
            this.ромбToolStripMenuItem});
            this.btnShapes.Name = "btnShapes";
            this.btnShapes.Size = new System.Drawing.Size(63, 92);
            this.btnShapes.Text = "Фигуры";
            // 
            // sep5
            // 
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(6, 95);
            // 
            // btnSizeLines
            // 
            this.btnSizeLines.Name = "btnSizeLines";
            this.btnSizeLines.Size = new System.Drawing.Size(72, 92);
            this.btnSizeLines.Text = "Толщина";
            this.btnSizeLines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sep6
            // 
            this.sep6.Name = "sep6";
            this.sep6.Size = new System.Drawing.Size(6, 95);
            // 
            // btnEditColors
            // 
            this.btnEditColors.Name = "btnEditColors";
            this.btnEditColors.Size = new System.Drawing.Size(23, 23);
            // 
            // mainWorkspace
            // 
            this.mainWorkspace.AutoScroll = true;
            this.mainWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.mainWorkspace.Controls.Add(this.canvas);
            this.mainWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWorkspace.Location = new System.Drawing.Point(0, 119);
            this.mainWorkspace.Name = "mainWorkspace";
            this.mainWorkspace.Size = new System.Drawing.Size(1214, 468);
            this.mainWorkspace.TabIndex = 2;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(16, 14);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(801, 410);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.colorPanel.Controls.Add(this.button21);
            this.colorPanel.Controls.Add(this.button22);
            this.colorPanel.Controls.Add(this.button23);
            this.colorPanel.Controls.Add(this.button24);
            this.colorPanel.Controls.Add(this.button25);
            this.colorPanel.Controls.Add(this.button26);
            this.colorPanel.Controls.Add(this.button27);
            this.colorPanel.Controls.Add(this.button28);
            this.colorPanel.Controls.Add(this.button29);
            this.colorPanel.Controls.Add(this.button30);
            this.colorPanel.Controls.Add(this.button299);
            this.colorPanel.Controls.Add(this.button288);
            this.colorPanel.Controls.Add(this.button999);
            this.colorPanel.Controls.Add(this.button888);
            this.colorPanel.Controls.Add(this.button277);
            this.colorPanel.Controls.Add(this.button266);
            this.colorPanel.Controls.Add(this.button255);
            this.colorPanel.Controls.Add(this.button777);
            this.colorPanel.Controls.Add(this.button666);
            this.colorPanel.Controls.Add(this.button244);
            this.colorPanel.Controls.Add(this.button211);
            this.colorPanel.Controls.Add(this.button555);
            this.colorPanel.Controls.Add(this.button444);
            this.colorPanel.Controls.Add(this.button111);
            this.colorPanel.Controls.Add(this.button233);
            this.colorPanel.Controls.Add(this.button2221);
            this.colorPanel.Controls.Add(this.button2);
            this.colorPanel.Controls.Add(this.button333);
            this.colorPanel.Controls.Add(this.button222);
            this.colorPanel.Controls.Add(this.button1);
            this.colorPanel.Controls.Add(this.color2);
            this.colorPanel.Controls.Add(this.color1);
            this.colorPanel.Location = new System.Drawing.Point(645, 33);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(320, 80);
            this.colorPanel.TabIndex = 3;
            this.colorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.colorPanel_Paint);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(288, 55);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(20, 20);
            this.button21.TabIndex = 27;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(266, 55);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(20, 20);
            this.button22.TabIndex = 26;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(246, 55);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(20, 20);
            this.button23.TabIndex = 22;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(226, 55);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(20, 20);
            this.button24.TabIndex = 20;
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(204, 55);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(20, 20);
            this.button25.TabIndex = 25;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(184, 55);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(20, 20);
            this.button26.TabIndex = 24;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(162, 55);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(20, 20);
            this.button27.TabIndex = 23;
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(142, 55);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(20, 20);
            this.button28.TabIndex = 21;
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(120, 55);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(20, 20);
            this.button29.TabIndex = 19;
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.White;
            this.button30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button30.Location = new System.Drawing.Point(98, 55);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(20, 20);
            this.button30.TabIndex = 18;
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button299
            // 
            this.button299.BackColor = System.Drawing.Color.Plum;
            this.button299.Location = new System.Drawing.Point(288, 32);
            this.button299.Name = "button299";
            this.button299.Size = new System.Drawing.Size(20, 20);
            this.button299.TabIndex = 17;
            this.button299.UseVisualStyleBackColor = false;
            // 
            // button288
            // 
            this.button288.BackColor = System.Drawing.Color.SteelBlue;
            this.button288.Location = new System.Drawing.Point(266, 32);
            this.button288.Name = "button288";
            this.button288.Size = new System.Drawing.Size(20, 20);
            this.button288.TabIndex = 16;
            this.button288.UseVisualStyleBackColor = false;
            this.button288.Click += new System.EventHandler(this.button18_Click);
            // 
            // button999
            // 
            this.button999.BackColor = System.Drawing.Color.DarkOrchid;
            this.button999.Location = new System.Drawing.Point(288, 10);
            this.button999.Name = "button999";
            this.button999.Size = new System.Drawing.Size(20, 20);
            this.button999.TabIndex = 15;
            this.button999.UseVisualStyleBackColor = false;
            // 
            // button888
            // 
            this.button888.BackColor = System.Drawing.Color.DarkBlue;
            this.button888.Location = new System.Drawing.Point(266, 10);
            this.button888.Name = "button888";
            this.button888.Size = new System.Drawing.Size(20, 20);
            this.button888.TabIndex = 14;
            this.button888.UseVisualStyleBackColor = false;
            // 
            // button277
            // 
            this.button277.BackColor = System.Drawing.Color.SkyBlue;
            this.button277.Location = new System.Drawing.Point(246, 32);
            this.button277.Name = "button277";
            this.button277.Size = new System.Drawing.Size(20, 20);
            this.button277.TabIndex = 8;
            this.button277.UseVisualStyleBackColor = false;
            // 
            // button266
            // 
            this.button266.BackColor = System.Drawing.Color.PaleGreen;
            this.button266.Location = new System.Drawing.Point(226, 32);
            this.button266.Name = "button266";
            this.button266.Size = new System.Drawing.Size(20, 20);
            this.button266.TabIndex = 7;
            this.button266.UseVisualStyleBackColor = false;
            // 
            // button255
            // 
            this.button255.BackColor = System.Drawing.Color.LightYellow;
            this.button255.Location = new System.Drawing.Point(204, 32);
            this.button255.Name = "button255";
            this.button255.Size = new System.Drawing.Size(20, 20);
            this.button255.TabIndex = 13;
            this.button255.UseVisualStyleBackColor = false;
            // 
            // button777
            // 
            this.button777.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button777.Location = new System.Drawing.Point(246, 10);
            this.button777.Name = "button777";
            this.button777.Size = new System.Drawing.Size(20, 20);
            this.button777.TabIndex = 6;
            this.button777.UseVisualStyleBackColor = false;
            // 
            // button666
            // 
            this.button666.BackColor = System.Drawing.Color.SeaGreen;
            this.button666.Location = new System.Drawing.Point(226, 10);
            this.button666.Name = "button666";
            this.button666.Size = new System.Drawing.Size(20, 20);
            this.button666.TabIndex = 5;
            this.button666.UseVisualStyleBackColor = false;
            // 
            // button244
            // 
            this.button244.BackColor = System.Drawing.Color.Gold;
            this.button244.Location = new System.Drawing.Point(184, 32);
            this.button244.Name = "button244";
            this.button244.Size = new System.Drawing.Size(20, 20);
            this.button244.TabIndex = 12;
            this.button244.UseVisualStyleBackColor = false;
            // 
            // button211
            // 
            this.button211.BackColor = System.Drawing.Color.Salmon;
            this.button211.Location = new System.Drawing.Point(162, 32);
            this.button211.Name = "button211";
            this.button211.Size = new System.Drawing.Size(20, 20);
            this.button211.TabIndex = 11;
            this.button211.UseVisualStyleBackColor = false;
            // 
            // button555
            // 
            this.button555.BackColor = System.Drawing.Color.Yellow;
            this.button555.Location = new System.Drawing.Point(204, 10);
            this.button555.Name = "button555";
            this.button555.Size = new System.Drawing.Size(20, 20);
            this.button555.TabIndex = 10;
            this.button555.UseVisualStyleBackColor = false;
            // 
            // button444
            // 
            this.button444.BackColor = System.Drawing.Color.Tomato;
            this.button444.Location = new System.Drawing.Point(184, 10);
            this.button444.Name = "button444";
            this.button444.Size = new System.Drawing.Size(20, 20);
            this.button444.TabIndex = 9;
            this.button444.UseVisualStyleBackColor = false;
            // 
            // button111
            // 
            this.button111.BackColor = System.Drawing.Color.Red;
            this.button111.Location = new System.Drawing.Point(162, 10);
            this.button111.Name = "button111";
            this.button111.Size = new System.Drawing.Size(20, 20);
            this.button111.TabIndex = 8;
            this.button111.UseVisualStyleBackColor = false;
            // 
            // button233
            // 
            this.button233.BackColor = System.Drawing.Color.Sienna;
            this.button233.Location = new System.Drawing.Point(142, 32);
            this.button233.Name = "button233";
            this.button233.Size = new System.Drawing.Size(20, 20);
            this.button233.TabIndex = 7;
            this.button233.UseVisualStyleBackColor = false;
            // 
            // button2221
            // 
            this.button2221.BackColor = System.Drawing.Color.Silver;
            this.button2221.Location = new System.Drawing.Point(120, 32);
            this.button2221.Name = "button2221";
            this.button2221.Size = new System.Drawing.Size(20, 20);
            this.button2221.TabIndex = 6;
            this.button2221.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(98, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button333
            // 
            this.button333.BackColor = System.Drawing.Color.Brown;
            this.button333.Location = new System.Drawing.Point(142, 10);
            this.button333.Name = "button333";
            this.button333.Size = new System.Drawing.Size(20, 20);
            this.button333.TabIndex = 4;
            this.button333.UseVisualStyleBackColor = false;
            // 
            // button222
            // 
            this.button222.BackColor = System.Drawing.Color.Gray;
            this.button222.Location = new System.Drawing.Point(120, 10);
            this.button222.Name = "button222";
            this.button222.Size = new System.Drawing.Size(20, 20);
            this.button222.TabIndex = 3;
            this.button222.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(98, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.White;
            this.color2.Location = new System.Drawing.Point(50, 10);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(40, 50);
            this.color2.TabIndex = 1;
            this.color2.Text = "Цвет\r\n2";
            this.color2.UseVisualStyleBackColor = false;
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.ForeColor = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(5, 10);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(40, 50);
            this.color1.TabIndex = 0;
            this.color1.Text = "Цвет\r\n1";
            this.color1.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.White;
            this.button31.Image = ((System.Drawing.Image)(resources.GetObject("button31.Image")));
            this.button31.Location = new System.Drawing.Point(971, 38);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(51, 60);
            this.button31.TabIndex = 18;
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // Выделение1
            // 
            this.Выделение1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Выделение1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Выделение1.Location = new System.Drawing.Point(70, 41);
            this.Выделение1.Name = "Выделение1";
            this.Выделение1.Size = new System.Drawing.Size(59, 34);
            this.Выделение1.TabIndex = 0;
            this.Выделение1.TabStop = false;
            this.Выделение1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.White;
            this.button32.Image = ((System.Drawing.Image)(resources.GetObject("button32.Image")));
            this.button32.Location = new System.Drawing.Point(16, 28);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(38, 45);
            this.button32.TabIndex = 19;
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кругToolStripMenuItem.Text = "Круг";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат ";
            // 
            // ромбToolStripMenuItem
            // 
            this.ромбToolStripMenuItem.Name = "ромбToolStripMenuItem";
            this.ромбToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ромбToolStripMenuItem.Text = "Ромб";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1214, 587);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.Выделение1);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.mainWorkspace);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.mainMenuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuBar;
            this.Name = "Form1";
            this.Text = "Paint";
            this.mainMenuBar.ResumeLayout(false);
            this.mainMenuBar.PerformLayout();
            this.ribbon.ResumeLayout(false);
            this.ribbon.PerformLayout();
            this.mainWorkspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.colorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip mainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem homeMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStrip ribbon;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripDropDownButton btnResize;
        private System.Windows.Forms.ToolStripDropDownButton btnRotate;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripButton btnPencil;
        private System.Windows.Forms.ToolStripButton btnFill;
        private System.Windows.Forms.ToolStripButton btnText;
        private System.Windows.Forms.ToolStripButton btnEraser;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripDropDownButton btnBrushes;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripDropDownButton btnShapes;
        private System.Windows.Forms.ToolStripSeparator sep5;
        private System.Windows.Forms.ToolStripDropDownButton btnSizeLines;
        private System.Windows.Forms.ToolStripSeparator sep6;
        private System.Windows.Forms.ToolStripButton btnEditColors;
        private System.Windows.Forms.Panel mainWorkspace;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button277;
        private System.Windows.Forms.Button button266;
        private System.Windows.Forms.Button button255;
        private System.Windows.Forms.Button button777;
        private System.Windows.Forms.Button button666;
        private System.Windows.Forms.Button button244;
        private System.Windows.Forms.Button button211;
        private System.Windows.Forms.Button button555;
        private System.Windows.Forms.Button button444;
        private System.Windows.Forms.Button button111;
        private System.Windows.Forms.Button button233;
        private System.Windows.Forms.Button button2221;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button333;
        private System.Windows.Forms.Button button222;
        private System.Windows.Forms.Button button299;
        private System.Windows.Forms.Button button288;
        private System.Windows.Forms.Button button999;
        private System.Windows.Forms.Button button888;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.GroupBox Выделение1;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem на90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на45ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохраниттьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печтьToolStripMenuItem;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ромбToolStripMenuItem;
    }
}