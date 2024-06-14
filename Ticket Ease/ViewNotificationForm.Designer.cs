namespace Ticket_Ease
{
    partial class ViewNotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewNotificationForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            vScrollBar1 = new VScrollBar();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(75, 25);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 15;
            label1.Text = "Notifications";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(19, 12);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 67);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(970, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 613);
            vScrollBar1.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AntiqueWhite;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(vScrollBar1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 36);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(993, 613);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // ViewNotificationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 709);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewNotificationForm";
            Text = "ViewNotificationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private VScrollBar vScrollBar1;
        private GroupBox groupBox1;
    }
}