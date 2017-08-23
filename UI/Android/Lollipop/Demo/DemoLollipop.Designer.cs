namespace VictoriApp.Framework.UI.Android.Lollipop
{
    partial class DemoLollipop
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
            this.button1 = new VictoriApp.Framework.UI.Android.Lollipop.LollipopButton();
            this.lollipopButton1 = new VictoriApp.Framework.UI.Android.Lollipop.LollipopButton();
            this.lollipopCard1 = new VictoriApp.Framework.UI.Android.Lollipop.LollipopCard();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BGColor = "#508ef5";
            this.button1.FontColor = "#ffffff";
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#508ef5";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(115, 12);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(143, 41);
            this.lollipopButton1.TabIndex = 1;
            this.lollipopButton1.Text = "lollipopButton1";
            // 
            // lollipopCard1
            // 
            this.lollipopCard1.ButtonColor = "#33b679";
            this.lollipopCard1.ContentColor = "#444444";
            this.lollipopCard1.ContentText = "Card Content is here";
            this.lollipopCard1.Image = null;
            this.lollipopCard1.Location = new System.Drawing.Point(12, 59);
            this.lollipopCard1.Name = "lollipopCard1";
            this.lollipopCard1.Size = new System.Drawing.Size(294, 299);
            this.lollipopCard1.TabIndex = 2;
            this.lollipopCard1.Text = "lollipopCard1";
            this.lollipopCard1.TitleColor = "#33b679";
            // 
            // DemoLollipop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 589);
            this.Controls.Add(this.lollipopCard1);
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.button1);
            this.Name = "DemoLollipop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DemoLollipop";
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopButton button1;
        private LollipopButton lollipopButton1;
        private LollipopCard lollipopCard1;
    }
}