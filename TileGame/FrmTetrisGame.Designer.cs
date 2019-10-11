namespace TileGame
{
    partial class FrmTetrisGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pnlGameScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGameScreen
            // 
            this.pnlGameScreen.BackColor = System.Drawing.Color.White;
            this.pnlGameScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGameScreen.Location = new System.Drawing.Point(12, 12);
            this.pnlGameScreen.Name = "pnlGameScreen";
            this.pnlGameScreen.Size = new System.Drawing.Size(258, 364);
            this.pnlGameScreen.TabIndex = 0;
            // 
            // FrmTetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 467);
            this.Controls.Add(this.pnlGameScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTetrisGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTetrisGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmTetrisGame_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameScreen;
    }
}

