internal partial class RendererSetupForm
{
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
            this.label_Hue = new System.Windows.Forms.Label();
            this.label_Quantization = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.label_Saturation = new System.Windows.Forms.Label();
            this.label_G = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_Resolution = new System.Windows.Forms.Label();
            this.label_ColorMode = new System.Windows.Forms.Label();
            this.label_RenderMode = new System.Windows.Forms.Label();
            this.label_ASCIITable = new System.Windows.Forms.Label();
            this.num_Width = new System.Windows.Forms.NumericUpDown();
            this.num_Height = new System.Windows.Forms.NumericUpDown();
            this.num_Quantization = new System.Windows.Forms.NumericUpDown();
            this.num_Saturation = new System.Windows.Forms.NumericUpDown();
            this.num_R = new System.Windows.Forms.NumericUpDown();
            this.num_G = new System.Windows.Forms.NumericUpDown();
            this.num_B = new System.Windows.Forms.NumericUpDown();
            this.num_Frame = new System.Windows.Forms.NumericUpDown();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.button_Preview = new System.Windows.Forms.Button();
            this.check_Loop = new System.Windows.Forms.CheckBox();
            this.cb_ColorMode = new System.Windows.Forms.ComboBox();
            this.cb_RenderMode = new System.Windows.Forms.ComboBox();
            this.cb_ASCIITable = new System.Windows.Forms.ComboBox();
            this.cb_CharColor = new System.Windows.Forms.ComboBox();
            this.gb_Renderer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_FontX = new System.Windows.Forms.NumericUpDown();
            this.num_FontY = new System.Windows.Forms.NumericUpDown();
            this.cb_BGColor = new System.Windows.Forms.ComboBox();
            this.gb_Image = new System.Windows.Forms.GroupBox();
            this.num_Lightness = new System.Windows.Forms.NumericUpDown();
            this.label_Contrast = new System.Windows.Forms.Label();
            this.num_Contrast = new System.Windows.Forms.NumericUpDown();
            this.num_Hue = new System.Windows.Forms.NumericUpDown();
            this.label_Lightness = new System.Windows.Forms.Label();
            this.gb_Render = new System.Windows.Forms.GroupBox();
            this.label_Frame = new System.Windows.Forms.Label();
            this.label_FPS = new System.Windows.Forms.Label();
            this.num_FPS = new System.Windows.Forms.NumericUpDown();
            this.check_SingleFrame = new System.Windows.Forms.CheckBox();
            this.button_Render = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Frame)).BeginInit();
            this.gb_Renderer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FontX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_FontY)).BeginInit();
            this.gb_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hue)).BeginInit();
            this.gb_Render.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FPS)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Hue
            // 
            this.label_Hue.AutoSize = true;
            this.label_Hue.Location = new System.Drawing.Point(63, 82);
            this.label_Hue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Hue.Name = "label_Hue";
            this.label_Hue.Size = new System.Drawing.Size(39, 20);
            this.label_Hue.TabIndex = 18;
            this.label_Hue.Text = "Hue";
            // 
            // label_Quantization
            // 
            this.label_Quantization.AutoSize = true;
            this.label_Quantization.Location = new System.Drawing.Point(4, 205);
            this.label_Quantization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Quantization.Name = "label_Quantization";
            this.label_Quantization.Size = new System.Drawing.Size(99, 20);
            this.label_Quantization.TabIndex = 20;
            this.label_Quantization.Text = "Quantization";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(50, 274);
            this.label_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(21, 20);
            this.label_R.TabIndex = 26;
            this.label_R.Text = "R";
            // 
            // label_Saturation
            // 
            this.label_Saturation.AutoSize = true;
            this.label_Saturation.Location = new System.Drawing.Point(21, 122);
            this.label_Saturation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Saturation.Name = "label_Saturation";
            this.label_Saturation.Size = new System.Drawing.Size(83, 20);
            this.label_Saturation.TabIndex = 22;
            this.label_Saturation.Text = "Saturation";
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Location = new System.Drawing.Point(129, 274);
            this.label_G.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(22, 20);
            this.label_G.TabIndex = 29;
            this.label_G.Text = "G";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(208, 274);
            this.label_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(20, 20);
            this.label_B.TabIndex = 30;
            this.label_B.Text = "B";
            // 
            // label_Resolution
            // 
            this.label_Resolution.AutoSize = true;
            this.label_Resolution.Location = new System.Drawing.Point(31, 99);
            this.label_Resolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Resolution.Name = "label_Resolution";
            this.label_Resolution.Size = new System.Drawing.Size(85, 20);
            this.label_Resolution.TabIndex = 33;
            this.label_Resolution.Text = "Resolution";
            // 
            // label_ColorMode
            // 
            this.label_ColorMode.AutoSize = true;
            this.label_ColorMode.Location = new System.Drawing.Point(24, 142);
            this.label_ColorMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ColorMode.Name = "label_ColorMode";
            this.label_ColorMode.Size = new System.Drawing.Size(90, 20);
            this.label_ColorMode.TabIndex = 34;
            this.label_ColorMode.Text = "Color Mode";
            // 
            // label_RenderMode
            // 
            this.label_RenderMode.AutoSize = true;
            this.label_RenderMode.Location = new System.Drawing.Point(8, 184);
            this.label_RenderMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RenderMode.Name = "label_RenderMode";
            this.label_RenderMode.Size = new System.Drawing.Size(106, 20);
            this.label_RenderMode.TabIndex = 35;
            this.label_RenderMode.Text = "Render Mode";
            // 
            // label_ASCIITable
            // 
            this.label_ASCIITable.AutoSize = true;
            this.label_ASCIITable.Location = new System.Drawing.Point(20, 225);
            this.label_ASCIITable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ASCIITable.Name = "label_ASCIITable";
            this.label_ASCIITable.Size = new System.Drawing.Size(95, 20);
            this.label_ASCIITable.TabIndex = 36;
            this.label_ASCIITable.Text = "ASCII Table";
            // 
            // num_Width
            // 
            this.num_Width.Location = new System.Drawing.Point(124, 97);
            this.num_Width.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Width.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.num_Width.Name = "num_Width";
            this.num_Width.Size = new System.Drawing.Size(141, 26);
            this.num_Width.TabIndex = 2;
            this.num_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Width.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.num_Width.ValueChanged += new System.EventHandler(this.num_Width_ValueChanged);
            // 
            // num_Height
            // 
            this.num_Height.Location = new System.Drawing.Point(274, 97);
            this.num_Height.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Height.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.num_Height.Name = "num_Height";
            this.num_Height.Size = new System.Drawing.Size(141, 26);
            this.num_Height.TabIndex = 3;
            this.num_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Height.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.num_Height.ValueChanged += new System.EventHandler(this.num_Height_ValueChanged);
            // 
            // num_Quantization
            // 
            this.num_Quantization.Location = new System.Drawing.Point(112, 198);
            this.num_Quantization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Quantization.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Quantization.Name = "num_Quantization";
            this.num_Quantization.Size = new System.Drawing.Size(141, 26);
            this.num_Quantization.TabIndex = 19;
            this.num_Quantization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Quantization.ValueChanged += new System.EventHandler(this.num_Quantization_ValueChanged);
            // 
            // num_Saturation
            // 
            this.num_Saturation.DecimalPlaces = 3;
            this.num_Saturation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num_Saturation.Location = new System.Drawing.Point(112, 118);
            this.num_Saturation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Saturation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Saturation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.num_Saturation.Name = "num_Saturation";
            this.num_Saturation.Size = new System.Drawing.Size(141, 26);
            this.num_Saturation.TabIndex = 21;
            this.num_Saturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Saturation.ValueChanged += new System.EventHandler(this.num_Saturation_ValueChanged);
            // 
            // num_R
            // 
            this.num_R.Location = new System.Drawing.Point(33, 238);
            this.num_R.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_R.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.num_R.Name = "num_R";
            this.num_R.Size = new System.Drawing.Size(68, 26);
            this.num_R.TabIndex = 25;
            this.num_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_R.ValueChanged += new System.EventHandler(this.num_R_ValueChanged);
            // 
            // num_G
            // 
            this.num_G.Location = new System.Drawing.Point(110, 238);
            this.num_G.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_G.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.num_G.Name = "num_G";
            this.num_G.Size = new System.Drawing.Size(68, 26);
            this.num_G.TabIndex = 27;
            this.num_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_G.ValueChanged += new System.EventHandler(this.num_G_ValueChanged);
            // 
            // num_B
            // 
            this.num_B.Location = new System.Drawing.Point(186, 238);
            this.num_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_B.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.num_B.Name = "num_B";
            this.num_B.Size = new System.Drawing.Size(68, 26);
            this.num_B.TabIndex = 28;
            this.num_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_B.ValueChanged += new System.EventHandler(this.num_B_ValueChanged);
            // 
            // num_Frame
            // 
            this.num_Frame.Location = new System.Drawing.Point(144, 51);
            this.num_Frame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Frame.Name = "num_Frame";
            this.num_Frame.Size = new System.Drawing.Size(68, 26);
            this.num_Frame.TabIndex = 38;
            this.num_Frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Frame.ValueChanged += new System.EventHandler(this.num_Frame_ValueChanged);
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Location = new System.Drawing.Point(477, 337);
            this.button_SelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(280, 46);
            this.button_SelectFile.TabIndex = 0;
            this.button_SelectFile.Text = "Select File";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // button_Preview
            // 
            this.button_Preview.Location = new System.Drawing.Point(9, 88);
            this.button_Preview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Preview.Name = "button_Preview";
            this.button_Preview.Size = new System.Drawing.Size(202, 46);
            this.button_Preview.TabIndex = 31;
            this.button_Preview.Text = "Preview";
            this.button_Preview.UseVisualStyleBackColor = true;
            this.button_Preview.Click += new System.EventHandler(this.button_Preview_Click);
            // 
            // check_Loop
            // 
            this.check_Loop.AutoSize = true;
            this.check_Loop.Location = new System.Drawing.Point(228, 52);
            this.check_Loop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_Loop.Name = "check_Loop";
            this.check_Loop.Size = new System.Drawing.Size(64, 24);
            this.check_Loop.TabIndex = 37;
            this.check_Loop.Text = "Loop";
            this.check_Loop.UseVisualStyleBackColor = true;
            this.check_Loop.CheckedChanged += new System.EventHandler(this.check_Loop_CheckedChanged);
            // 
            // cb_ColorMode
            // 
            this.cb_ColorMode.FormattingEnabled = true;
            this.cb_ColorMode.Location = new System.Drawing.Point(124, 137);
            this.cb_ColorMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_ColorMode.Name = "cb_ColorMode";
            this.cb_ColorMode.Size = new System.Drawing.Size(139, 28);
            this.cb_ColorMode.TabIndex = 7;
            this.cb_ColorMode.Text = "Select Mode";
            this.cb_ColorMode.SelectedIndexChanged += new System.EventHandler(this.cb_ColorMode_SelectedIndexChanged);
            // 
            // cb_RenderMode
            // 
            this.cb_RenderMode.FormattingEnabled = true;
            this.cb_RenderMode.Location = new System.Drawing.Point(124, 179);
            this.cb_RenderMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_RenderMode.Name = "cb_RenderMode";
            this.cb_RenderMode.Size = new System.Drawing.Size(139, 28);
            this.cb_RenderMode.TabIndex = 8;
            this.cb_RenderMode.Text = "Select Mode";
            this.cb_RenderMode.SelectedIndexChanged += new System.EventHandler(this.cb_RenderMode_SelectedIndexChanged);
            // 
            // cb_ASCIITable
            // 
            this.cb_ASCIITable.FormattingEnabled = true;
            this.cb_ASCIITable.Location = new System.Drawing.Point(124, 221);
            this.cb_ASCIITable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_ASCIITable.Name = "cb_ASCIITable";
            this.cb_ASCIITable.Size = new System.Drawing.Size(139, 28);
            this.cb_ASCIITable.TabIndex = 10;
            this.cb_ASCIITable.Text = "Select Table";
            this.cb_ASCIITable.SelectedIndexChanged += new System.EventHandler(this.cb_ASCIITable_SelectedIndexChanged);
            // 
            // cb_CharColor
            // 
            this.cb_CharColor.FormattingEnabled = true;
            this.cb_CharColor.Location = new System.Drawing.Point(274, 137);
            this.cb_CharColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_CharColor.Name = "cb_CharColor";
            this.cb_CharColor.Size = new System.Drawing.Size(139, 28);
            this.cb_CharColor.TabIndex = 32;
            this.cb_CharColor.Text = "Char Color";
            this.cb_CharColor.SelectedIndexChanged += new System.EventHandler(this.cb_CharColor_SelectedIndexChanged);
            // 
            // gb_Renderer
            // 
            this.gb_Renderer.Controls.Add(this.label1);
            this.gb_Renderer.Controls.Add(this.num_FontX);
            this.gb_Renderer.Controls.Add(this.num_FontY);
            this.gb_Renderer.Controls.Add(this.cb_BGColor);
            this.gb_Renderer.Controls.Add(this.label_Resolution);
            this.gb_Renderer.Controls.Add(this.num_Width);
            this.gb_Renderer.Controls.Add(this.num_Height);
            this.gb_Renderer.Controls.Add(this.label_ASCIITable);
            this.gb_Renderer.Controls.Add(this.cb_ColorMode);
            this.gb_Renderer.Controls.Add(this.label_RenderMode);
            this.gb_Renderer.Controls.Add(this.cb_RenderMode);
            this.gb_Renderer.Controls.Add(this.label_ColorMode);
            this.gb_Renderer.Controls.Add(this.cb_ASCIITable);
            this.gb_Renderer.Controls.Add(this.cb_CharColor);
            this.gb_Renderer.Location = new System.Drawing.Point(13, 14);
            this.gb_Renderer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_Renderer.Name = "gb_Renderer";
            this.gb_Renderer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_Renderer.Size = new System.Drawing.Size(440, 313);
            this.gb_Renderer.TabIndex = 39;
            this.gb_Renderer.TabStop = false;
            this.gb_Renderer.Text = "Rebderer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Font Size";
            // 
            // num_FontX
            // 
            this.num_FontX.Location = new System.Drawing.Point(124, 61);
            this.num_FontX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_FontX.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.num_FontX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_FontX.Name = "num_FontX";
            this.num_FontX.Size = new System.Drawing.Size(141, 26);
            this.num_FontX.TabIndex = 38;
            this.num_FontX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_FontX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_FontX.ValueChanged += new System.EventHandler(this.num_FontX_ValueChanged);
            // 
            // num_FontY
            // 
            this.num_FontY.Location = new System.Drawing.Point(274, 61);
            this.num_FontY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_FontY.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.num_FontY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_FontY.Name = "num_FontY";
            this.num_FontY.Size = new System.Drawing.Size(141, 26);
            this.num_FontY.TabIndex = 39;
            this.num_FontY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_FontY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_FontY.ValueChanged += new System.EventHandler(this.num_FontY_ValueChanged);
            // 
            // cb_BGColor
            // 
            this.cb_BGColor.FormattingEnabled = true;
            this.cb_BGColor.Location = new System.Drawing.Point(274, 179);
            this.cb_BGColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_BGColor.Name = "cb_BGColor";
            this.cb_BGColor.Size = new System.Drawing.Size(139, 28);
            this.cb_BGColor.TabIndex = 37;
            this.cb_BGColor.Text = "BG Color";
            this.cb_BGColor.SelectedIndexChanged += new System.EventHandler(this.cb_BGColor_SelectedIndexChanged);
            // 
            // gb_Image
            // 
            this.gb_Image.Controls.Add(this.num_Lightness);
            this.gb_Image.Controls.Add(this.label_Contrast);
            this.gb_Image.Controls.Add(this.num_Contrast);
            this.gb_Image.Controls.Add(this.num_Hue);
            this.gb_Image.Controls.Add(this.label_Lightness);
            this.gb_Image.Controls.Add(this.label_B);
            this.gb_Image.Controls.Add(this.label_Hue);
            this.gb_Image.Controls.Add(this.label_G);
            this.gb_Image.Controls.Add(this.num_Quantization);
            this.gb_Image.Controls.Add(this.num_B);
            this.gb_Image.Controls.Add(this.label_Quantization);
            this.gb_Image.Controls.Add(this.num_G);
            this.gb_Image.Controls.Add(this.num_Saturation);
            this.gb_Image.Controls.Add(this.label_R);
            this.gb_Image.Controls.Add(this.label_Saturation);
            this.gb_Image.Controls.Add(this.num_R);
            this.gb_Image.Location = new System.Drawing.Point(472, 18);
            this.gb_Image.Margin = new System.Windows.Forms.Padding(15, 5, 4, 5);
            this.gb_Image.Name = "gb_Image";
            this.gb_Image.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_Image.Size = new System.Drawing.Size(280, 309);
            this.gb_Image.TabIndex = 40;
            this.gb_Image.TabStop = false;
            this.gb_Image.Text = "Image";
            // 
            // num_Lightness
            // 
            this.num_Lightness.DecimalPlaces = 3;
            this.num_Lightness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num_Lightness.Location = new System.Drawing.Point(112, 158);
            this.num_Lightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Lightness.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Lightness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.num_Lightness.Name = "num_Lightness";
            this.num_Lightness.Size = new System.Drawing.Size(141, 26);
            this.num_Lightness.TabIndex = 31;
            this.num_Lightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Lightness.ValueChanged += new System.EventHandler(this.num_Lightness_ValueChanged);
            // 
            // label_Contrast
            // 
            this.label_Contrast.AutoSize = true;
            this.label_Contrast.Location = new System.Drawing.Point(34, 42);
            this.label_Contrast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Contrast.Name = "label_Contrast";
            this.label_Contrast.Size = new System.Drawing.Size(70, 20);
            this.label_Contrast.TabIndex = 17;
            this.label_Contrast.Text = "Contrast";
            // 
            // num_Contrast
            // 
            this.num_Contrast.DecimalPlaces = 3;
            this.num_Contrast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_Contrast.Location = new System.Drawing.Point(112, 38);
            this.num_Contrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Contrast.Name = "num_Contrast";
            this.num_Contrast.Size = new System.Drawing.Size(141, 26);
            this.num_Contrast.TabIndex = 14;
            this.num_Contrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Contrast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Contrast.ValueChanged += new System.EventHandler(this.num_Contrast_ValueChanged);
            // 
            // num_Hue
            // 
            this.num_Hue.Location = new System.Drawing.Point(112, 78);
            this.num_Hue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Hue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_Hue.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.num_Hue.Name = "num_Hue";
            this.num_Hue.Size = new System.Drawing.Size(141, 26);
            this.num_Hue.TabIndex = 15;
            this.num_Hue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Hue.ValueChanged += new System.EventHandler(this.num_Hue_ValueChanged);
            // 
            // label_Lightness
            // 
            this.label_Lightness.AutoSize = true;
            this.label_Lightness.Location = new System.Drawing.Point(20, 162);
            this.label_Lightness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Lightness.Name = "label_Lightness";
            this.label_Lightness.Size = new System.Drawing.Size(78, 20);
            this.label_Lightness.TabIndex = 16;
            this.label_Lightness.Text = "Lightness";
            // 
            // gb_Render
            // 
            this.gb_Render.Controls.Add(this.label_Frame);
            this.gb_Render.Controls.Add(this.label_FPS);
            this.gb_Render.Controls.Add(this.num_FPS);
            this.gb_Render.Controls.Add(this.check_SingleFrame);
            this.gb_Render.Controls.Add(this.button_Render);
            this.gb_Render.Controls.Add(this.button_Preview);
            this.gb_Render.Controls.Add(this.check_Loop);
            this.gb_Render.Controls.Add(this.num_Frame);
            this.gb_Render.Location = new System.Drawing.Point(13, 337);
            this.gb_Render.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_Render.Name = "gb_Render";
            this.gb_Render.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_Render.Size = new System.Drawing.Size(440, 143);
            this.gb_Render.TabIndex = 41;
            this.gb_Render.TabStop = false;
            this.gb_Render.Text = "Render";
            // 
            // label_Frame
            // 
            this.label_Frame.AutoSize = true;
            this.label_Frame.Location = new System.Drawing.Point(140, 24);
            this.label_Frame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Frame.Name = "label_Frame";
            this.label_Frame.Size = new System.Drawing.Size(55, 20);
            this.label_Frame.TabIndex = 42;
            this.label_Frame.Text = "Frame";
            // 
            // label_FPS
            // 
            this.label_FPS.AutoSize = true;
            this.label_FPS.Location = new System.Drawing.Point(358, 25);
            this.label_FPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FPS.Name = "label_FPS";
            this.label_FPS.Size = new System.Drawing.Size(40, 20);
            this.label_FPS.TabIndex = 38;
            this.label_FPS.Text = "FPS";
            // 
            // num_FPS
            // 
            this.num_FPS.Location = new System.Drawing.Point(362, 50);
            this.num_FPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_FPS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_FPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_FPS.Name = "num_FPS";
            this.num_FPS.Size = new System.Drawing.Size(68, 26);
            this.num_FPS.TabIndex = 41;
            this.num_FPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_FPS.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // check_SingleFrame
            // 
            this.check_SingleFrame.AutoSize = true;
            this.check_SingleFrame.Location = new System.Drawing.Point(12, 52);
            this.check_SingleFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_SingleFrame.Name = "check_SingleFrame";
            this.check_SingleFrame.Size = new System.Drawing.Size(122, 24);
            this.check_SingleFrame.TabIndex = 40;
            this.check_SingleFrame.Text = "Single Frame";
            this.check_SingleFrame.UseVisualStyleBackColor = true;
            this.check_SingleFrame.CheckedChanged += new System.EventHandler(this.check_SingleFrame_CheckedChanged);
            // 
            // button_Render
            // 
            this.button_Render.Location = new System.Drawing.Point(228, 88);
            this.button_Render.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Render.Name = "button_Render";
            this.button_Render.Size = new System.Drawing.Size(202, 46);
            this.button_Render.TabIndex = 39;
            this.button_Render.Text = "Render";
            this.button_Render.UseVisualStyleBackColor = true;
            this.button_Render.Click += new System.EventHandler(this.button_Render_Click);
            // 
            // RendererSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 566);
            this.Controls.Add(this.gb_Render);
            this.Controls.Add(this.gb_Image);
            this.Controls.Add(this.gb_Renderer);
            this.Controls.Add(this.button_SelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RendererSetupForm";
            this.Text = "ASCII Renderer";
            this.Load += new System.EventHandler(this.RendererSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Frame)).EndInit();
            this.gb_Renderer.ResumeLayout(false);
            this.gb_Renderer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FontX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_FontY)).EndInit();
            this.gb_Image.ResumeLayout(false);
            this.gb_Image.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hue)).EndInit();
            this.gb_Render.ResumeLayout(false);
            this.gb_Render.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FPS)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label_Resolution;
    private System.Windows.Forms.Label label_ColorMode;
    private System.Windows.Forms.Label label_RenderMode;
    private System.Windows.Forms.Label label_ASCIITable;
    private System.Windows.Forms.Label label_Hue;
    private System.Windows.Forms.Label label_Quantization;
    private System.Windows.Forms.Label label_Saturation;
    private System.Windows.Forms.Label label_R;
    private System.Windows.Forms.Label label_G;
    private System.Windows.Forms.Label label_B;
    private System.Windows.Forms.NumericUpDown num_Width;
    private System.Windows.Forms.NumericUpDown num_Height;
    private System.Windows.Forms.NumericUpDown num_Frame;
    private System.Windows.Forms.NumericUpDown num_Saturation;
    private System.Windows.Forms.NumericUpDown num_Quantization;
    private System.Windows.Forms.NumericUpDown num_R;
    private System.Windows.Forms.NumericUpDown num_G;
    private System.Windows.Forms.NumericUpDown num_B;
    private System.Windows.Forms.Button button_Preview;
    private System.Windows.Forms.Button button_SelectFile;
    private System.Windows.Forms.CheckBox check_Loop;
    private System.Windows.Forms.GroupBox gb_Renderer;
    private System.Windows.Forms.GroupBox gb_Image;
    private System.Windows.Forms.GroupBox gb_Render;
    private System.Windows.Forms.ComboBox cb_ColorMode;
    private System.Windows.Forms.ComboBox cb_RenderMode;
    private System.Windows.Forms.ComboBox cb_ASCIITable;
    private System.Windows.Forms.ComboBox cb_CharColor;
    private System.Windows.Forms.CheckBox check_SingleFrame;
    private System.Windows.Forms.Button button_Render;
    private System.Windows.Forms.ComboBox cb_BGColor;
    private System.Windows.Forms.Label label_Contrast;
    private System.Windows.Forms.NumericUpDown num_Contrast;
    private System.Windows.Forms.NumericUpDown num_Hue;
    private System.Windows.Forms.Label label_Lightness;
    private System.Windows.Forms.NumericUpDown num_Lightness;
    private System.Windows.Forms.Label label_FPS;
    private System.Windows.Forms.NumericUpDown num_FPS;
    private System.Windows.Forms.Label label_Frame;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown num_FontX;
    private System.Windows.Forms.NumericUpDown num_FontY;
}