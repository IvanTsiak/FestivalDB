namespace FestivalsBD;

partial class MainForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        ToCRUDButton = new Button();
        ToQueriesButton = new Button();
        button1 = new Button();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // ToCRUDButton
        // 
        ToCRUDButton.Location = new Point(184, 271);
        ToCRUDButton.Name = "ToCRUDButton";
        ToCRUDButton.Size = new Size(160, 52);
        ToCRUDButton.TabIndex = 0;
        ToCRUDButton.Text = "Управління таблицями\r\n\r\n\r\n";
        ToCRUDButton.UseVisualStyleBackColor = true;
        ToCRUDButton.Click += ToCRUDButton_Click;
        // 
        // ToQueriesButton
        // 
        ToQueriesButton.Location = new Point(505, 271);
        ToQueriesButton.Name = "ToQueriesButton";
        ToQueriesButton.Size = new Size(160, 52);
        ToQueriesButton.TabIndex = 1;
        ToQueriesButton.Text = "Параметризовані запити";
        ToQueriesButton.UseVisualStyleBackColor = true;
        ToQueriesButton.Click += ToQueriesButton_Click;
        // 
        // button1
        // 
        button1.Location = new Point(337, 376);
        button1.Name = "button1";
        button1.Size = new Size(160, 70);
        button1.TabIndex = 2;
        button1.Text = "Запити із множинними порівняннями";
        button1.UseVisualStyleBackColor = true;
        button1.Click += ToHardQueriesButton_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.Location = new Point(171, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(510, 198);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(852, 485);
        Controls.Add(pictureBox1);
        Controls.Add(button1);
        Controls.Add(ToQueriesButton);
        Controls.Add(ToCRUDButton);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Festival DB";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ToQueriesButton;

    private System.Windows.Forms.Button ToCRUDButton;

    #endregion

    private Button button1;
    private PictureBox pictureBox1;
}