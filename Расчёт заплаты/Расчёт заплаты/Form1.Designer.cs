namespace Расчёт_заплаты
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.topText = new System.Windows.Forms.Label();
            this.stajBox = new System.Windows.Forms.ComboBox();
            this.par1name = new System.Windows.Forms.Label();
            this.par2name = new System.Windows.Forms.Label();
            this.razr1 = new System.Windows.Forms.RadioButton();
            this.razr2 = new System.Windows.Forms.RadioButton();
            this.razr3 = new System.Windows.Forms.RadioButton();
            this.oneHrPay = new System.Windows.Forms.TextBox();
            this.par3name = new System.Windows.Forms.Label();
            this.par4name = new System.Windows.Forms.Label();
            this.dayLength = new System.Windows.Forms.ComboBox();
            this.kolDay = new System.Windows.Forms.ComboBox();
            this.par5name = new System.Windows.Forms.Label();
            this.par6Name = new System.Windows.Forms.Label();
            this.txtNalogi = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.showResBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topText
            // 
            this.topText.AutoSize = true;
            this.topText.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topText.Location = new System.Drawing.Point(81, 9);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(375, 38);
            this.topText.TabIndex = 0;
            this.topText.Text = "Расчёт зароботной платы";
            // 
            // stajBox
            // 
            this.stajBox.FormattingEnabled = true;
            this.stajBox.Items.AddRange(new object[] {
            "Менее 5 лет (нет доплаты)",
            "От 5 до 10 лет (доплата 2000)",
            "Более 10 лет (доплата 4000)"});
            this.stajBox.Location = new System.Drawing.Point(12, 107);
            this.stajBox.Name = "stajBox";
            this.stajBox.Size = new System.Drawing.Size(121, 21);
            this.stajBox.TabIndex = 1;
            // 
            // par1name
            // 
            this.par1name.AutoSize = true;
            this.par1name.Location = new System.Drawing.Point(9, 91);
            this.par1name.Name = "par1name";
            this.par1name.Size = new System.Drawing.Size(95, 13);
            this.par1name.TabIndex = 3;
            this.par1name.Text = "Стаж работника";
            // 
            // par2name
            // 
            this.par2name.AutoSize = true;
            this.par2name.Location = new System.Drawing.Point(186, 91);
            this.par2name.Name = "par2name";
            this.par2name.Size = new System.Drawing.Size(104, 13);
            this.par2name.TabIndex = 4;
            this.par2name.Text = "Разряд работника";
            // 
            // razr1
            // 
            this.razr1.AutoSize = true;
            this.razr1.Location = new System.Drawing.Point(189, 107);
            this.razr1.Name = "razr1";
            this.razr1.Size = new System.Drawing.Size(144, 17);
            this.razr1.TabIndex = 5;
            this.razr1.TabStop = true;
            this.razr1.Text = "Первый (нет доплаты)";
            this.razr1.UseVisualStyleBackColor = true;
            this.razr1.CheckedChanged += new System.EventHandler(this.razr1_CheckedChanged);
            // 
            // razr2
            // 
            this.razr2.AutoSize = true;
            this.razr2.Location = new System.Drawing.Point(189, 130);
            this.razr2.Name = "razr2";
            this.razr2.Size = new System.Drawing.Size(141, 17);
            this.razr2.TabIndex = 6;
            this.razr2.TabStop = true;
            this.razr2.Text = "Второй (доплата1000)";
            this.razr2.UseVisualStyleBackColor = true;
            this.razr2.CheckedChanged += new System.EventHandler(this.razr2_CheckedChanged);
            // 
            // razr3
            // 
            this.razr3.AutoSize = true;
            this.razr3.Location = new System.Drawing.Point(189, 153);
            this.razr3.Name = "razr3";
            this.razr3.Size = new System.Drawing.Size(143, 17);
            this.razr3.TabIndex = 7;
            this.razr3.TabStop = true;
            this.razr3.Text = "Третий (доплата 2000)";
            this.razr3.UseVisualStyleBackColor = true;
            this.razr3.CheckedChanged += new System.EventHandler(this.razr3_CheckedChanged);
            // 
            // oneHrPay
            // 
            this.oneHrPay.Location = new System.Drawing.Point(381, 108);
            this.oneHrPay.Name = "oneHrPay";
            this.oneHrPay.Size = new System.Drawing.Size(121, 22);
            this.oneHrPay.TabIndex = 8;
            this.oneHrPay.TextChanged += new System.EventHandler(this.oneHrPay_TextChanged);
            this.oneHrPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oneHrPay_KeyPress);
            // 
            // par3name
            // 
            this.par3name.AutoSize = true;
            this.par3name.Location = new System.Drawing.Point(378, 91);
            this.par3name.Name = "par3name";
            this.par3name.Size = new System.Drawing.Size(78, 13);
            this.par3name.TabIndex = 9;
            this.par3name.Text = "Оплата 1 часа";
            // 
            // par4name
            // 
            this.par4name.AutoSize = true;
            this.par4name.Location = new System.Drawing.Point(9, 217);
            this.par4name.Name = "par4name";
            this.par4name.Size = new System.Drawing.Size(192, 13);
            this.par4name.TabIndex = 10;
            this.par4name.Text = "Продолжительность рабочего дня";
            // 
            // dayLength
            // 
            this.dayLength.FormattingEnabled = true;
            this.dayLength.Items.AddRange(new object[] {
            "6-часовой",
            "8-часовой"});
            this.dayLength.Location = new System.Drawing.Point(12, 233);
            this.dayLength.Name = "dayLength";
            this.dayLength.Size = new System.Drawing.Size(121, 21);
            this.dayLength.TabIndex = 11;
            // 
            // kolDay
            // 
            this.kolDay.FormattingEnabled = true;
            this.kolDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.kolDay.Location = new System.Drawing.Point(189, 233);
            this.kolDay.Name = "kolDay";
            this.kolDay.Size = new System.Drawing.Size(121, 21);
            this.kolDay.TabIndex = 12;
            // 
            // par5name
            // 
            this.par5name.AutoSize = true;
            this.par5name.Location = new System.Drawing.Point(196, 217);
            this.par5name.Name = "par5name";
            this.par5name.Size = new System.Drawing.Size(122, 13);
            this.par5name.TabIndex = 13;
            this.par5name.Text = "Кол-во рабочих дней";
            this.par5name.Click += new System.EventHandler(this.par5name_Click);
            // 
            // par6Name
            // 
            this.par6Name.AutoSize = true;
            this.par6Name.Location = new System.Drawing.Point(378, 217);
            this.par6Name.Name = "par6Name";
            this.par6Name.Size = new System.Drawing.Size(112, 13);
            this.par6Name.TabIndex = 14;
            this.par6Name.Text = "Налоговая ставка %";
            // 
            // txtNalogi
            // 
            this.txtNalogi.Location = new System.Drawing.Point(381, 234);
            this.txtNalogi.Name = "txtNalogi";
            this.txtNalogi.Size = new System.Drawing.Size(121, 22);
            this.txtNalogi.TabIndex = 15;
            this.txtNalogi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNalogi_KeyPress);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 286);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(121, 49);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Очистить поля";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // showResBtn
            // 
            this.showResBtn.Location = new System.Drawing.Point(189, 286);
            this.showResBtn.Name = "showResBtn";
            this.showResBtn.Size = new System.Drawing.Size(121, 49);
            this.showResBtn.TabIndex = 19;
            this.showResBtn.Text = "Вывод результатов";
            this.showResBtn.UseVisualStyleBackColor = true;
            this.showResBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 415);
            this.Controls.Add(this.showResBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.txtNalogi);
            this.Controls.Add(this.par6Name);
            this.Controls.Add(this.par5name);
            this.Controls.Add(this.kolDay);
            this.Controls.Add(this.dayLength);
            this.Controls.Add(this.par4name);
            this.Controls.Add(this.par3name);
            this.Controls.Add(this.oneHrPay);
            this.Controls.Add(this.razr3);
            this.Controls.Add(this.razr2);
            this.Controls.Add(this.razr1);
            this.Controls.Add(this.par2name);
            this.Controls.Add(this.par1name);
            this.Controls.Add(this.stajBox);
            this.Controls.Add(this.topText);
            this.Name = "Form1";
            this.Text = "Форма расчёта ЗП";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topText;
        public System.Windows.Forms.ComboBox stajBox;
        private System.Windows.Forms.Label par1name;
        private System.Windows.Forms.Label par2name;
        public System.Windows.Forms.RadioButton razr1;
        public System.Windows.Forms.RadioButton razr2;
        public System.Windows.Forms.RadioButton razr3;
        public System.Windows.Forms.TextBox oneHrPay;
        private System.Windows.Forms.Label par3name;
        private System.Windows.Forms.Label par4name;
        public System.Windows.Forms.ComboBox dayLength;
        public System.Windows.Forms.ComboBox kolDay;
        private System.Windows.Forms.Label par5name;
        private System.Windows.Forms.Label par6Name;
        public System.Windows.Forms.TextBox txtNalogi;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button showResBtn;
    }
}

