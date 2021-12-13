namespace WindowsFormsVariant14
{
    partial class FormBase
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FirsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInitialState = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirsName,
            this.NameColumn,
            this.LastName,
            this.ShortFIO,
            this.Model,
            this.Num,
            this.Color});
            this.dataGridView1.Location = new System.Drawing.Point(3, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.buttonInitialState);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonB);
            this.panel1.Controls.Add(this.buttonA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // buttonB
            // 
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonB.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonB.Location = new System.Drawing.Point(103, 3);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(94, 94);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.toolTip1.SetToolTip(this.buttonB, "Упорядочить все сведения о владельцах белых машин в алфавитном порядке марки маши" +
        "н");
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonA
            // 
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonA.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonA.Location = new System.Drawing.Point(3, 3);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(94, 94);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.toolTip1.SetToolTip(this.buttonA, "Выдать все сведения о владельцах самой распространенной марки автомобиля\r\n");
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // FirsName
            // 
            this.FirsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirsName.HeaderText = "Фамилия";
            this.FirsName.Name = "FirsName";
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "Отчество";
            this.LastName.Name = "LastName";
            // 
            // ShortFIO
            // 
            this.ShortFIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShortFIO.HeaderText = "Краткое ФИО";
            this.ShortFIO.Name = "ShortFIO";
            this.ShortFIO.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Model.HeaderText = "Марка";
            this.Model.Name = "Model";
            this.Model.Width = 65;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.HeaderText = "Номер";
            this.Num.Name = "Num";
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            // 
            // buttonInitialState
            // 
            this.buttonInitialState.BackgroundImage = global::WindowsFormsVariant14.Properties.Resources.icons8_reload_100__1_;
            this.buttonInitialState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInitialState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInitialState.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInitialState.Location = new System.Drawing.Point(203, 3);
            this.buttonInitialState.Name = "buttonInitialState";
            this.buttonInitialState.Size = new System.Drawing.Size(94, 94);
            this.buttonInitialState.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonInitialState, "Сбросить все фильтры.");
            this.buttonInitialState.UseVisualStyleBackColor = true;
            this.buttonInitialState.Click += new System.EventHandler(this.buttonInitialState_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackgroundImage = global::WindowsFormsVariant14.Properties.Resources.icons8_save_100;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(703, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 94);
            this.buttonSave.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonSave, "Сохранить изменения");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBase";
            this.Text = "Бурдуковский Максим Вариант 14";
            this.Load += new System.EventHandler(this.FormBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.Button buttonInitialState;
    }
}

