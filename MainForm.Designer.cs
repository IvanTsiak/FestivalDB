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
        ToCRUDButton = new System.Windows.Forms.Button();
        ToQueriesButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // ToCRUDButton
        // 
        ToCRUDButton.Location = new System.Drawing.Point(184, 271);
        ToCRUDButton.Name = "ToCRUDButton";
        ToCRUDButton.Size = new System.Drawing.Size(160, 52);
        ToCRUDButton.TabIndex = 0;
        ToCRUDButton.Text = "Управління таблицями\r\n\r\n\r\n";
        ToCRUDButton.UseVisualStyleBackColor = true;
        ToCRUDButton.Click += ToCRUDButton_Click;
        // 
        // ToQueriesButton
        // 
        ToQueriesButton.Location = new System.Drawing.Point(505, 271);
        ToQueriesButton.Name = "ToQueriesButton";
        ToQueriesButton.Size = new System.Drawing.Size(160, 52);
        ToQueriesButton.TabIndex = 1;
        ToQueriesButton.Text = "Запити";
        ToQueriesButton.UseVisualStyleBackColor = true;
        ToQueriesButton.Click += ToQueriesButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(852, 485);
        Controls.Add(ToQueriesButton);
        Controls.Add(ToCRUDButton);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "FestivalsBD";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ToQueriesButton;

    private System.Windows.Forms.Button ToCRUDButton;

    #endregion
}