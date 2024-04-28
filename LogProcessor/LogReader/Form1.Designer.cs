namespace LogReader
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
            dataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CorrelationId = new DataGridViewTextBoxColumn();
            DateUtc = new DataGridViewTextBoxColumn();
            Thread = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            Logger = new DataGridViewTextBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            Exception = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sorokSzama = new Label();
            errorok = new Label();
            debugok = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            saveBTN = new Button();
            textBox1 = new TextBox();
            kereses_BTN = new Button();
            comboBox1 = new ComboBox();
            resetBTN = new Button();
            label10 = new Label();
            label9 = new Label();
            messageTX = new TextBox();
            exceptionTX = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, CorrelationId, DateUtc, Thread, Level, Logger, Message, Exception });
            dataGrid.Location = new Point(0, 32);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 82;
            dataGrid.RowTemplate.Height = 41;
            dataGrid.Size = new Size(936, 300);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.Width = 200;
            // 
            // CorrelationId
            // 
            CorrelationId.HeaderText = "CorrelationId";
            CorrelationId.MinimumWidth = 10;
            CorrelationId.Name = "CorrelationId";
            CorrelationId.Width = 200;
            // 
            // DateUtc
            // 
            DateUtc.HeaderText = "DateUtc";
            DateUtc.MinimumWidth = 10;
            DateUtc.Name = "DateUtc";
            DateUtc.Width = 200;
            // 
            // Thread
            // 
            Thread.HeaderText = "Thread";
            Thread.MinimumWidth = 10;
            Thread.Name = "Thread";
            Thread.Width = 200;
            // 
            // Level
            // 
            Level.HeaderText = "Level";
            Level.MinimumWidth = 10;
            Level.Name = "Level";
            Level.Width = 200;
            // 
            // Logger
            // 
            Logger.HeaderText = "Logger";
            Logger.MinimumWidth = 10;
            Logger.Name = "Logger";
            Logger.Width = 200;
            // 
            // Message
            // 
            Message.HeaderText = "Message";
            Message.MinimumWidth = 10;
            Message.Name = "Message";
            Message.Width = 200;
            // 
            // Exception
            // 
            Exception.HeaderText = "Exception";
            Exception.MinimumWidth = 10;
            Exception.Name = "Exception";
            Exception.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1283, 108);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 2;
            label2.Text = "Sorok száma:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1283, 166);
            label3.Name = "label3";
            label3.Size = new Size(178, 32);
            label3.TabIndex = 3;
            label3.Text = "Error-ok száma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1283, 227);
            label4.Name = "label4";
            label4.Size = new Size(200, 32);
            label4.TabIndex = 4;
            label4.Text = "Debug-ok száma:";
            // 
            // sorokSzama
            // 
            sorokSzama.AutoSize = true;
            sorokSzama.Location = new Point(1603, 108);
            sorokSzama.Name = "sorokSzama";
            sorokSzama.Size = new Size(27, 32);
            sorokSzama.TabIndex = 5;
            sorokSzama.Text = "0";
            // 
            // errorok
            // 
            errorok.AutoSize = true;
            errorok.Location = new Point(1603, 166);
            errorok.Name = "errorok";
            errorok.Size = new Size(27, 32);
            errorok.TabIndex = 6;
            errorok.Text = "0";
            // 
            // debugok
            // 
            debugok.AutoSize = true;
            debugok.Location = new Point(1603, 227);
            debugok.Name = "debugok";
            debugok.Size = new Size(27, 32);
            debugok.TabIndex = 7;
            debugok.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(1269, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 261);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statisztikák";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 416);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 9;
            label1.Text = "Message:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 644);
            label8.Name = "label8";
            label8.Size = new Size(122, 32);
            label8.TabIndex = 10;
            label8.Text = "Exception:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(saveBTN);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(kereses_BTN);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(resetBTN);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(1269, 434);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 349);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Keresés";
            // 
            // saveBTN
            // 
            saveBTN.Location = new Point(51, 280);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new Size(283, 46);
            saveBTN.TabIndex = 13;
            saveBTN.Text = "Mentés másként";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 39);
            textBox1.TabIndex = 4;
            // 
            // kereses_BTN
            // 
            kereses_BTN.Location = new Point(15, 210);
            kereses_BTN.Name = "kereses_BTN";
            kereses_BTN.Size = new Size(150, 46);
            kereses_BTN.TabIndex = 12;
            kereses_BTN.Text = "Keresés";
            kereses_BTN.UseVisualStyleBackColor = true;
            kereses_BTN.Click += kereses_BTN_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 3;
            // 
            // resetBTN
            // 
            resetBTN.Location = new Point(215, 210);
            resetBTN.Name = "resetBTN";
            resetBTN.Size = new Size(150, 46);
            resetBTN.TabIndex = 2;
            resetBTN.Text = "Visszaállít";
            resetBTN.UseVisualStyleBackColor = true;
            resetBTN.Click += resetBTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 133);
            label10.Name = "label10";
            label10.Size = new Size(72, 32);
            label10.TabIndex = 1;
            label10.Text = "Érték:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 74);
            label9.Name = "label9";
            label9.Size = new Size(79, 32);
            label9.TabIndex = 0;
            label9.Text = "Mező:";
            // 
            // messageTX
            // 
            messageTX.Location = new Point(166, 416);
            messageTX.Name = "messageTX";
            messageTX.Size = new Size(955, 39);
            messageTX.TabIndex = 12;
            // 
            // exceptionTX
            // 
            exceptionTX.Location = new Point(166, 651);
            exceptionTX.Name = "exceptionTX";
            exceptionTX.Size = new Size(955, 39);
            exceptionTX.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1699, 872);
            Controls.Add(exceptionTX);
            Controls.Add(messageTX);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(debugok);
            Controls.Add(errorok);
            Controls.Add(sorokSzama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGrid);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CorrelationId;
        private DataGridViewTextBoxColumn DateUtc;
        private DataGridViewTextBoxColumn Thread;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn Logger;
        private DataGridViewTextBoxColumn Message;
        private DataGridViewTextBoxColumn Exception;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label sorokSzama;
        private Label errorok;
        private Label debugok;
        private GroupBox groupBox1;
        private Label label1;
        private Label label8;
        private GroupBox groupBox2;
        private Button saveBTN;
        private TextBox textBox1;
        private Button kereses_BTN;
        private ComboBox comboBox1;
        private Button resetBTN;
        private Label label10;
        private Label label9;
        private TextBox messageTX;
        private TextBox exceptionTX;
    }
}
