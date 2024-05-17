using System.IO;
using System.Windows.Forms;
using System;

internal partial class RendererSetupForm : Form
{
    public event Action<string> RenderButtonPressed;
    public event Action PreviewButtonPressed;

    private RendererSettings settings;

    public RendererSetupForm(ASCIIRenderer renderer)
    {
        InitializeComponent();

        cb_ASCIITable.Items.AddRange(Enum.GetNames(typeof(ASCIITable)));
        cb_ColorMode.Items.AddRange(Enum.GetNames(typeof(ColorMode)));
        cb_RenderMode.Items.AddRange(Enum.GetNames(typeof(RenderMode)));
        cb_CharColor.Items.AddRange(Enum.GetNames(typeof(ConsoleColor)));
        cb_BGColor.Items.AddRange(Enum.GetNames(typeof(ConsoleColor)));

        settings = renderer.Settings;

        num_Width.Value = settings.WindowWidth;
        num_Height.Value = settings.WindowHeight;
        num_FontX.Value = settings.FontWidth;
        num_FontY.Value = settings.FontHeight;

        UpdateInterface();
    }

    private void button_SelectFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.Filter = fileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif;*.tiff)|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif;*.tiff";

        if (fileDialog.ShowDialog() == DialogResult.OK)
        {
            OnFileSelected(fileDialog.FileName);
        }
    }

    private void OnFileSelected(string filePath)
    {
        num_Frame.Maximum = ASCIIRenderer.GetFrameCount(filePath);
        settings.filePath = filePath;
        UpdateInterface();
    }

    private void UpdateInterface()
    {
        UpdateGroupBoxes();
        UpdateRendererGroup();
        UpdateRenderGroup();
    }

    private void UpdateGroupBoxes()
    {
        bool enabled = File.Exists(settings.filePath);

        gb_Image.Enabled = enabled;
        gb_Render.Enabled = enabled;
        gb_Renderer.Enabled = enabled;
    }

    #region Renderer
    private void cb_ColorMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        settings.colorMode = (ColorMode)cb_ColorMode.SelectedIndex;
        UpdateInterface();
    }

    private void cb_RenderMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        settings.renderMode = (RenderMode)cb_RenderMode.SelectedIndex;
        UpdateInterface();
    }

    private void cb_CharColor_SelectedIndexChanged(object sender, EventArgs e)
    {
        settings.solidModeColor = (ConsoleColor)cb_CharColor.SelectedIndex;
        UpdateInterface();
    }

    private void cb_BGColor_SelectedIndexChanged(object sender, EventArgs e)
    {
        settings.asciiModeBGColor = (ConsoleColor)cb_BGColor.SelectedIndex;
        UpdateInterface();
    }

    private void cb_ASCIITable_SelectedIndexChanged(object sender, EventArgs e)
    {
        settings.asciiTable = (ASCIITable)cb_ASCIITable.SelectedIndex;
        UpdateInterface();
    }

    private void num_Width_ValueChanged(object sender, EventArgs e)
    {
        settings.WindowWidth = (int)num_Width.Value;
        UpdateInterface();
    }

    private void num_Height_ValueChanged(object sender, EventArgs e)
    {
        settings.WindowHeight = (int)num_Height.Value;
        UpdateInterface();
    }

    private void UpdateRendererGroup()
    {
        bool isASCIIArt = settings.renderMode == RenderMode.ASCIIArt &&
            cb_RenderMode.SelectedIndex == (int)RenderMode.ASCIIArt;

        bool isSolid = settings.colorMode == ColorMode.Solid &&
            cb_ColorMode.SelectedIndex == (int)ColorMode.Solid;

        cb_CharColor.Enabled = isASCIIArt && isSolid;
        cb_BGColor.Enabled = isASCIIArt;
        cb_ASCIITable.Enabled = isASCIIArt;
    }
    #endregion

    #region Render
    private void check_SingleFrame_CheckedChanged(object sender, EventArgs e)
    {
        settings.renderSingleFrame = check_SingleFrame.Checked;
        UpdateInterface();
    }

    private void num_Frame_ValueChanged(object sender, EventArgs e)
    {
        settings.frame = (int)num_Frame.Value;
        UpdateInterface();
    }

    private void check_Loop_CheckedChanged(object sender, EventArgs e)
    {
        settings.loop = check_Loop.Checked;
        UpdateInterface();
    }

    private void UpdateRenderGroup()
    {
        bool multiframeFile = settings.IsMultiframeFile();
        bool renderSingle = settings.renderSingleFrame;

        check_SingleFrame.Enabled = multiframeFile;
        check_Loop.Enabled = multiframeFile && !renderSingle;
        num_FPS.Enabled = multiframeFile && !renderSingle;
        num_Frame.Enabled = renderSingle && multiframeFile;

        if (!multiframeFile)
        {
            check_SingleFrame.Checked = true;
            num_Frame.Value = num_Frame.Minimum;
            num_FPS.Value = num_FPS.Minimum;
        }

        if (renderSingle || !multiframeFile)
            check_Loop.Checked = true;

        bool isReady = true;

        if (cb_ColorMode.SelectedIndex == -1 ||
            cb_RenderMode.SelectedIndex == -1)
        {
            isReady = false;
        }

        if (settings.renderMode == RenderMode.ASCIIArt)
        {
            if (cb_BGColor.SelectedIndex == -1) isReady = false;
            if (settings.colorMode == ColorMode.Solid &&
                cb_CharColor.SelectedIndex == -1) isReady = false;
        }

        button_Preview.Enabled = isReady;
        button_Render.Enabled = isReady;
    }

    #endregion

    private void num_Contrast_ValueChanged(object sender, EventArgs e)
    {
        settings.contrast = (double)num_Contrast.Value;
    }

    private void num_Hue_ValueChanged(object sender, EventArgs e)
    {
        settings.hue = (int)num_Hue.Value;
    }

    private void num_Saturation_ValueChanged(object sender, EventArgs e)
    {
        settings.saturation = (double)num_Saturation.Value;
    }

    private void num_Lightness_ValueChanged(object sender, EventArgs e)
    {
        settings.lightness = (double)num_Lightness.Value;
    }

    private void num_Quantization_ValueChanged(object sender, EventArgs e)
    {
        settings.quantization = (int)num_Quantization.Value;
    }

    private void num_R_ValueChanged(object sender, EventArgs e)
    {
        settings.valueR = (int)num_R.Value;
    }

    private void num_G_ValueChanged(object sender, EventArgs e)
    {
        settings.valueG = (int)num_G.Value;
    }

    private void num_B_ValueChanged(object sender, EventArgs e)
    {
        settings.valueB = (int)num_B.Value;
    }

    private void button_Preview_Click(object sender, EventArgs e)
    {
        ApplySettings();
        PreviewButtonPressed?.Invoke();
    }

    private void button_Render_Click(object sender, EventArgs e)
    {
        SaveFileDialog fileDialog = new SaveFileDialog();
        fileDialog.Filter = "Binary File (*.bin)|*.bin";

        if (fileDialog.ShowDialog() == DialogResult.OK)
        {
            ApplySettings();
            RenderButtonPressed?.Invoke(fileDialog.FileName);
        }
    }

    private void ApplySettings()
    {
            settings.WindowWidth = (int)num_Width.Value;
            settings.WindowHeight = (int)num_Height.Value;
            settings.renderMode = (RenderMode)cb_RenderMode.SelectedIndex;
            settings.colorMode = (ColorMode)cb_ColorMode.SelectedIndex;
            settings.solidModeColor = (ConsoleColor)cb_CharColor.SelectedIndex;
            settings.asciiModeBGColor = (ConsoleColor)cb_BGColor.SelectedIndex;
            settings.asciiTable = (ASCIITable)cb_ASCIITable.SelectedIndex;
            
            settings.contrast = (double)num_Contrast.Value;
            settings.hue = (int)num_Hue.Value;
            settings.saturation = (double)num_Saturation.Value;
            settings.lightness = (double)num_Lightness.Value;
            settings.quantization = (int)num_Quantization.Value;
            settings.valueR = (int)num_R.Value;
            settings.valueG = (int)num_G.Value;
            settings.valueB = (int)num_B.Value;
            
            settings.renderSingleFrame = check_SingleFrame.Checked;
            settings.frame = (int)num_Frame.Value;
            settings.fps = (int)num_FPS.Value;
            settings.loop = check_Loop.Checked;
    }

    private void RendererSetupForm_Load(object sender, EventArgs e)
    {

    }

    private void num_FontX_ValueChanged(object sender, EventArgs e)
    {
        settings.FontWidth = (int)num_FontX.Value;
    }

    private void num_FontY_ValueChanged(object sender, EventArgs e)
    {
        settings.FontHeight = (int)num_FontY.Value;
    }
}