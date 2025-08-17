namespace ListaHorizontalNumeros
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
            flowLayoutPanelNumeros = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelNumeros
            // 
            flowLayoutPanelNumeros.AutoScroll = true;
            flowLayoutPanelNumeros.Location = new Point(12, 120);
            flowLayoutPanelNumeros.Name = "flowLayoutPanelNumeros";
            flowLayoutPanelNumeros.Size = new Size(1763, 100);
            flowLayoutPanelNumeros.TabIndex = 0;
            flowLayoutPanelNumeros.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1793, 450);
            Controls.Add(flowLayoutPanelNumeros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelNumeros;
    }
}
