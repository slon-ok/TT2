namespace ТТ2 {
    partial class mini {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.deskrBox = new System.Windows.Forms.TextBox();
            this.countDayBox = new System.Windows.Forms.TextBox();
            this.addNewTask = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(442, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Список задач";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Короткое название задачи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание задачи:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(83, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество дней для решения:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(21, 61);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(308, 26);
            this.nameBox.TabIndex = 5;
            // 
            // deskrBox
            // 
            this.deskrBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskrBox.Location = new System.Drawing.Point(5, 5);
            this.deskrBox.Multiline = true;
            this.deskrBox.Name = "deskrBox";
            this.deskrBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deskrBox.Size = new System.Drawing.Size(523, 200);
            this.deskrBox.TabIndex = 6;
            // 
            // countDayBox
            // 
            this.countDayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countDayBox.Location = new System.Drawing.Point(368, 369);
            this.countDayBox.Name = "countDayBox";
            this.countDayBox.Size = new System.Drawing.Size(74, 26);
            this.countDayBox.TabIndex = 7;
            // 
            // addNewTask
            // 
            this.addNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewTask.Location = new System.Drawing.Point(92, 408);
            this.addNewTask.Name = "addNewTask";
            this.addNewTask.Size = new System.Drawing.Size(80, 30);
            this.addNewTask.TabIndex = 8;
            this.addNewTask.Text = "Добавить";
            this.addNewTask.UseVisualStyleBackColor = true;
            this.addNewTask.Click += new System.EventHandler(this.addNewTask_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(385, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(87, 327);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 27);
            this.messageLabel.TabIndex = 10;
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeButton.Location = new System.Drawing.Point(136, 408);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(80, 30);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(337, 93);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(181, 22);
            this.checkBoxAll.TabIndex = 12;
            this.checkBoxAll.Text = "Отобразить выполенные";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deskrBox);
            this.panel1.Location = new System.Drawing.Point(20, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(533, 210);
            this.panel1.TabIndex = 13;
            // 
            // mini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.countDayBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addNewTask);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mini";
            this.Text = "Редактирование задачи";
            this.Load += new System.EventHandler(this.mini_Load);
            this.SizeChanged += new System.EventHandler(this.mini_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox deskrBox;
        private System.Windows.Forms.TextBox countDayBox;
        private System.Windows.Forms.Button addNewTask;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Panel panel1;
    }
}