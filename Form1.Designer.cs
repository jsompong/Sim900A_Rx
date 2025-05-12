namespace Sim900A_Rx
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ReceivedBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serRxBox = new System.Windows.Forms.TextBox();
            this.RxLed = new System.Windows.Forms.PictureBox();
            this.datelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RxLed)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceivedBox
            // 
            this.ReceivedBox.AllowDrop = true;
            this.ReceivedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedBox.Location = new System.Drawing.Point(330, 38);
            this.ReceivedBox.Multiline = true;
            this.ReceivedBox.Name = "ReceivedBox";
            this.ReceivedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceivedBox.Size = new System.Drawing.Size(428, 268);
            this.ReceivedBox.TabIndex = 1;
            this.ReceivedBox.TextChanged += new System.EventHandler(this.ReceivedBox_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serRxBox
            // 
            this.serRxBox.Location = new System.Drawing.Point(226, 35);
            this.serRxBox.Name = "serRxBox";
            this.serRxBox.Size = new System.Drawing.Size(87, 20);
            this.serRxBox.TabIndex = 2;
            this.serRxBox.TextChanged += new System.EventHandler(this.serRxBox_TextChanged);
            // 
            // RxLed
            // 
            this.RxLed.BackColor = System.Drawing.Color.Red;
            this.RxLed.Location = new System.Drawing.Point(294, 69);
            this.RxLed.Name = "RxLed";
            this.RxLed.Size = new System.Drawing.Size(19, 10);
            this.RxLed.TabIndex = 3;
            this.RxLed.TabStop = false;
            this.RxLed.Click += new System.EventHandler(this.RxLed_Click);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(730, 9);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(28, 13);
            this.datelabel.TabIndex = 4;
            this.datelabel.Text = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.RxLed);
            this.Controls.Add(this.serRxBox);
            this.Controls.Add(this.ReceivedBox);
            this.Name = "Form1";
            this.Text = "SIm900A_[vs2019]_COM7_Rx";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RxLed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceivedBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox serRxBox;
        private System.Windows.Forms.PictureBox RxLed;
        private System.Windows.Forms.Label datelabel;
    }
}

