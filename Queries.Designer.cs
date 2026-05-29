using System.ComponentModel;

namespace FestivalsBD;

partial class Queries
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        Return = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Return
        // 
        Return.Location = new System.Drawing.Point(33, 28);
        Return.Name = "Return";
        Return.Size = new System.Drawing.Size(128, 37);
        Return.TabIndex = 0;
        Return.Text = "На головну";
        Return.UseVisualStyleBackColor = true;
        Return.Click += Return_Click;
        // 
        // Queries
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Return);
        Text = "Queries";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Return;

    #endregion
}