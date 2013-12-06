namespace OptimizationOfSimpleHeatEquation
{
    partial class GeneralForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.labelG = new System.Windows.Forms.Label();
            this.textBoxTau = new System.Windows.Forms.TextBox();
            this.labelTau = new System.Windows.Forms.Label();
            this.labelFi = new System.Windows.Forms.Label();
            this.labelRo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonProgon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.richTextBoxVar = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lBegin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lEnd = new System.Windows.Forms.ToolStripStatusLabel();
            this.lTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelWait = new System.Windows.Forms.Label();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикПрогонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.пробноеПостроениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЗначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматПредставленияЧиселToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxFormat = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.прогонкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прогоняемыйПараметрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.величинаШагаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxStep = new System.Windows.Forms.ToolStripTextBox();
            this.интервалПрогонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxInterval = new System.Windows.Forms.ToolStripTextBox();
            this.печататьПроверкуУсловийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кратностьВыбораПараболToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbChoose = new System.Windows.Forms.ToolStripTextBox();
            this.представлениеТочекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxPoints = new System.Windows.Forms.ToolStripComboBox();
            this.labelSopr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRo0 = new System.Windows.Forms.ComboBox();
            this.comboBoxRo1 = new System.Windows.Forms.ComboBox();
            this.comboBoxFi = new System.Windows.Forms.ComboBox();
            this.groupBoxVar = new System.Windows.Forms.GroupBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelL = new System.Windows.Forms.Label();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelN.Location = new System.Drawing.Point(5, 30);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(37, 21);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "N =";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxN.Location = new System.Drawing.Point(38, 27);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(50, 29);
            this.textBoxN.TabIndex = 1;
            this.textBoxN.Text = "14";
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            this.textBoxN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxN_KeyDown);
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            this.textBoxN.Leave += new System.EventHandler(this.textBoxG_Leave);
            // 
            // textBoxG
            // 
            this.textBoxG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxG.Location = new System.Drawing.Point(38, 89);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(50, 29);
            this.textBoxG.TabIndex = 4;
            this.textBoxG.Text = "1";
            this.toolTip1.SetToolTip(this.textBoxG, "Значение не должно быть равным нулю");
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            this.textBoxG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxN_KeyDown);
            this.textBoxG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            this.textBoxG.Leave += new System.EventHandler(this.textBoxG_Leave);
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG.Location = new System.Drawing.Point(5, 92);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(33, 21);
            this.labelG.TabIndex = 4;
            this.labelG.Text = "γ =";
            // 
            // textBoxTau
            // 
            this.textBoxTau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTau.Location = new System.Drawing.Point(38, 58);
            this.textBoxTau.Name = "textBoxTau";
            this.textBoxTau.Size = new System.Drawing.Size(50, 29);
            this.textBoxTau.TabIndex = 3;
            this.textBoxTau.Text = "0,1";
            this.toolTip1.SetToolTip(this.textBoxTau, "Значение должно быть положительным");
            this.textBoxTau.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            this.textBoxTau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxN_KeyDown);
            this.textBoxTau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            this.textBoxTau.Leave += new System.EventHandler(this.textBoxG_Leave);
            // 
            // labelTau
            // 
            this.labelTau.AutoSize = true;
            this.labelTau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTau.Location = new System.Drawing.Point(5, 61);
            this.labelTau.Name = "labelTau";
            this.labelTau.Size = new System.Drawing.Size(33, 21);
            this.labelTau.TabIndex = 6;
            this.labelTau.Text = "τ =";
            // 
            // labelFi
            // 
            this.labelFi.AutoSize = true;
            this.labelFi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFi.Location = new System.Drawing.Point(179, 93);
            this.labelFi.Name = "labelFi";
            this.labelFi.Size = new System.Drawing.Size(35, 21);
            this.labelFi.TabIndex = 12;
            this.labelFi.Text = "ϕ =";
            // 
            // labelRo
            // 
            this.labelRo.AutoSize = true;
            this.labelRo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelRo.Location = new System.Drawing.Point(94, 30);
            this.labelRo.Name = "labelRo";
            this.labelRo.Size = new System.Drawing.Size(34, 21);
            this.labelRo.TabIndex = 14;
            this.labelRo.Text = "ρ =";
            // 
            // buttonProgon
            // 
            this.buttonProgon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonProgon.Location = new System.Drawing.Point(231, 162);
            this.buttonProgon.Name = "buttonProgon";
            this.buttonProgon.Size = new System.Drawing.Size(151, 33);
            this.buttonProgon.TabIndex = 137;
            this.buttonProgon.Text = "Прогнать";
            this.toolTip1.SetToolTip(this.buttonProgon, "Параметры прогонки настраиваются в \"Настройки/Прогонка\"");
            this.buttonProgon.UseVisualStyleBackColor = true;
            this.buttonProgon.Click += new System.EventHandler(this.buttonProgon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Location = new System.Drawing.Point(231, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 139;
            this.button1.Text = "Быстро вычислить";
            this.toolTip1.SetToolTip(this.button1, "Покажутся только значения слагаемых и результат");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonGo.Location = new System.Drawing.Point(126, 122);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(99, 73);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Вычислить";
            this.toolTip1.SetToolTip(this.buttonGo, "Переменные будут доступны для просмотра");
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxL
            // 
            this.textBoxL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL.Location = new System.Drawing.Point(123, 90);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(50, 29);
            this.textBoxL.TabIndex = 140;
            this.textBoxL.Text = "0,1";
            this.toolTip1.SetToolTip(this.textBoxL, "Значение в отрезке [0; 1]");
            // 
            // richTextBoxVar
            // 
            this.richTextBoxVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxVar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxVar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxVar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.richTextBoxVar.Location = new System.Drawing.Point(9, 247);
            this.richTextBoxVar.Name = "richTextBoxVar";
            this.richTextBoxVar.ReadOnly = true;
            this.richTextBoxVar.Size = new System.Drawing.Size(249, 218);
            this.richTextBoxVar.TabIndex = 17;
            this.richTextBoxVar.Text = "";
            this.richTextBoxVar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lBegin,
            this.lEnd,
            this.lTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 22);
            this.statusStrip1.TabIndex = 80;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lBegin
            // 
            this.lBegin.Name = "lBegin";
            this.lBegin.Size = new System.Drawing.Size(87, 17);
            this.lBegin.Text = "Время начала:";
            // 
            // lEnd
            // 
            this.lEnd.Name = "lEnd";
            this.lEnd.Size = new System.Drawing.Size(81, 17);
            this.lEnd.Text = "Время конца:";
            // 
            // lTime
            // 
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(118, 17);
            this.lTime.Text = "Затраченное время:";
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.Font = new System.Drawing.Font("Segoe Script", 20F);
            this.labelWait.Location = new System.Drawing.Point(2, 247);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(195, 42);
            this.labelWait.TabIndex = 83;
            this.labelWait.Text = "Вычисляю...";
            this.labelWait.Visible = false;
            this.labelWait.MouseHover += new System.EventHandler(this.labelWait_MouseHover);
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.Location = new System.Drawing.Point(9, 143);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(102, 19);
            this.radioButtonOn.TabIndex = 84;
            this.radioButtonOn.Text = "Включить лог";
            this.radioButtonOn.UseVisualStyleBackColor = true;
            this.radioButtonOn.CheckedChanged += new System.EventHandler(this.radioButtonOff_CheckedChanged);
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Checked = true;
            this.radioButtonOff.Location = new System.Drawing.Point(9, 162);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(111, 19);
            this.radioButtonOff.TabIndex = 85;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Выключить лог";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.radioButtonOff_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.графикToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 128;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьToolStripMenuItem,
            this.графикПрогонкиToolStripMenuItem,
            this.toolStripMenuItem3,
            this.пробноеПостроениеToolStripMenuItem});
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.графикToolStripMenuItem.Text = "График";
            this.графикToolStripMenuItem.Visible = false;
            // 
            // построитьToolStripMenuItem
            // 
            this.построитьToolStripMenuItem.Name = "построитьToolStripMenuItem";
            this.построитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.построитьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.построитьToolStripMenuItem.Text = "Построить";
            this.построитьToolStripMenuItem.Click += new System.EventHandler(this.построитьToolStripMenuItem_Click);
            // 
            // графикПрогонкиToolStripMenuItem
            // 
            this.графикПрогонкиToolStripMenuItem.Name = "графикПрогонкиToolStripMenuItem";
            this.графикПрогонкиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.графикПрогонкиToolStripMenuItem.Text = "График прогонки";
            this.графикПрогонкиToolStripMenuItem.Click += new System.EventHandler(this.графикПрогонкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
            // 
            // пробноеПостроениеToolStripMenuItem
            // 
            this.пробноеПостроениеToolStripMenuItem.Name = "пробноеПостроениеToolStripMenuItem";
            this.пробноеПостроениеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.пробноеПостроениеToolStripMenuItem.Text = "Пробное построение";
            this.пробноеПостроениеToolStripMenuItem.Click += new System.EventHandler(this.пробноеПостроениеToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьЗначенияToolStripMenuItem,
            this.форматПредставленияЧиселToolStripMenuItem,
            this.toolStripMenuItem2,
            this.прогонкаToolStripMenuItem,
            this.графикToolStripMenuItem1});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // показатьЗначенияToolStripMenuItem
            // 
            this.показатьЗначенияToolStripMenuItem.Name = "показатьЗначенияToolStripMenuItem";
            this.показатьЗначенияToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.показатьЗначенияToolStripMenuItem.Text = "Проверка условий";
            this.показатьЗначенияToolStripMenuItem.Click += new System.EventHandler(this.показатьЗначенияToolStripMenuItem_Click);
            // 
            // форматПредставленияЧиселToolStripMenuItem
            // 
            this.форматПредставленияЧиселToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxFormat});
            this.форматПредставленияЧиселToolStripMenuItem.Name = "форматПредставленияЧиселToolStripMenuItem";
            this.форматПредставленияЧиселToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.форматПредставленияЧиселToolStripMenuItem.Text = "Формат представления чисел";
            this.форматПредставленияЧиселToolStripMenuItem.Visible = false;
            // 
            // toolStripComboBoxFormat
            // 
            this.toolStripComboBoxFormat.Name = "toolStripComboBoxFormat";
            this.toolStripComboBoxFormat.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxFormat.Text = "R";
            this.toolStripComboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFormat_SelectedIndexChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(235, 6);
            // 
            // прогонкаToolStripMenuItem
            // 
            this.прогонкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прогоняемыйПараметрToolStripMenuItem,
            this.величинаШагаToolStripMenuItem,
            this.интервалПрогонкиToolStripMenuItem,
            this.печататьПроверкуУсловийToolStripMenuItem});
            this.прогонкаToolStripMenuItem.Name = "прогонкаToolStripMenuItem";
            this.прогонкаToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.прогонкаToolStripMenuItem.Text = "Прогонка";
            // 
            // прогоняемыйПараметрToolStripMenuItem
            // 
            this.прогоняемыйПараметрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.tToolStripMenuItem,
            this.gToolStripMenuItem,
            this.lToolStripMenuItem});
            this.прогоняемыйПараметрToolStripMenuItem.Name = "прогоняемыйПараметрToolStripMenuItem";
            this.прогоняемыйПараметрToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.прогоняемыйПараметрToolStripMenuItem.Text = "Прогоняемый параметр";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Checked = true;
            this.nToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nToolStripMenuItem.Text = "N";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tToolStripMenuItem.Text = "τ";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gToolStripMenuItem.Text = "γ ";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // величинаШагаToolStripMenuItem
            // 
            this.величинаШагаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxStep});
            this.величинаШагаToolStripMenuItem.Name = "величинаШагаToolStripMenuItem";
            this.величинаШагаToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.величинаШагаToolStripMenuItem.Text = "Величина шага";
            // 
            // toolStripTextBoxStep
            // 
            this.toolStripTextBoxStep.Name = "toolStripTextBoxStep";
            this.toolStripTextBoxStep.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxStep.Text = "1";
            this.toolStripTextBoxStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            // 
            // интервалПрогонкиToolStripMenuItem
            // 
            this.интервалПрогонкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxInterval});
            this.интервалПрогонкиToolStripMenuItem.Name = "интервалПрогонкиToolStripMenuItem";
            this.интервалПрогонкиToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.интервалПрогонкиToolStripMenuItem.Text = "Промежуток прогонки";
            // 
            // toolStripTextBoxInterval
            // 
            this.toolStripTextBoxInterval.Name = "toolStripTextBoxInterval";
            this.toolStripTextBoxInterval.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxInterval.Text = "1;500";
            this.toolStripTextBoxInterval.ToolTipText = "начало; конец";
            // 
            // печататьПроверкуУсловийToolStripMenuItem
            // 
            this.печататьПроверкуУсловийToolStripMenuItem.Name = "печататьПроверкуУсловийToolStripMenuItem";
            this.печататьПроверкуУсловийToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.печататьПроверкуУсловийToolStripMenuItem.Text = "Печатать проверку условий";
            this.печататьПроверкуУсловийToolStripMenuItem.Click += new System.EventHandler(this.печататьПроверкуУсловийToolStripMenuItem_Click);
            // 
            // графикToolStripMenuItem1
            // 
            this.графикToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кратностьВыбораПараболToolStripMenuItem,
            this.представлениеТочекToolStripMenuItem});
            this.графикToolStripMenuItem1.Name = "графикToolStripMenuItem1";
            this.графикToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.графикToolStripMenuItem1.Text = "График";
            this.графикToolStripMenuItem1.Visible = false;
            // 
            // кратностьВыбораПараболToolStripMenuItem
            // 
            this.кратностьВыбораПараболToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbChoose});
            this.кратностьВыбораПараболToolStripMenuItem.Name = "кратностьВыбораПараболToolStripMenuItem";
            this.кратностьВыбораПараболToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.кратностьВыбораПараболToolStripMenuItem.Text = "Кратность выбора парабол";
            // 
            // tbChoose
            // 
            this.tbChoose.Name = "tbChoose";
            this.tbChoose.Size = new System.Drawing.Size(100, 23);
            this.tbChoose.Text = "2";
            this.tbChoose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            // 
            // представлениеТочекToolStripMenuItem
            // 
            this.представлениеТочекToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxPoints});
            this.представлениеТочекToolStripMenuItem.Name = "представлениеТочекToolStripMenuItem";
            this.представлениеТочекToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.представлениеТочекToolStripMenuItem.Text = "Представление точек";
            // 
            // comboBoxPoints
            // 
            this.comboBoxPoints.Name = "comboBoxPoints";
            this.comboBoxPoints.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPoints.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoints_SelectedIndexChanged);
            // 
            // labelSopr
            // 
            this.labelSopr.AutoSize = true;
            this.labelSopr.Location = new System.Drawing.Point(9, 122);
            this.labelSopr.Name = "labelSopr";
            this.labelSopr.Size = new System.Drawing.Size(38, 15);
            this.labelSopr.TabIndex = 131;
            this.labelSopr.Text = "label1";
            this.labelSopr.MouseEnter += new System.EventHandler(this.labelSopr_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 21);
            this.label1.TabIndex = 132;
            this.label1.Text = "ρ =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 12);
            this.label2.TabIndex = 134;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(102, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 12);
            this.label3.TabIndex = 135;
            this.label3.Text = "1";
            // 
            // comboBoxRo0
            // 
            this.comboBoxRo0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRo0.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxRo0.FormattingEnabled = true;
            this.comboBoxRo0.Location = new System.Drawing.Point(123, 27);
            this.comboBoxRo0.Name = "comboBoxRo0";
            this.comboBoxRo0.Size = new System.Drawing.Size(594, 29);
            this.comboBoxRo0.TabIndex = 5;
            this.comboBoxRo0.Text = "0.9*x + 7";
            this.comboBoxRo0.Leave += new System.EventHandler(this.comboBoxFi_Leave);
            // 
            // comboBoxRo1
            // 
            this.comboBoxRo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRo1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxRo1.FormattingEnabled = true;
            this.comboBoxRo1.Location = new System.Drawing.Point(123, 58);
            this.comboBoxRo1.Name = "comboBoxRo1";
            this.comboBoxRo1.Size = new System.Drawing.Size(594, 29);
            this.comboBoxRo1.TabIndex = 6;
            this.comboBoxRo1.Text = "0.9*x + 8";
            this.comboBoxRo1.Leave += new System.EventHandler(this.comboBoxFi_Leave);
            // 
            // comboBoxFi
            // 
            this.comboBoxFi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxFi.FormattingEnabled = true;
            this.comboBoxFi.Location = new System.Drawing.Point(211, 90);
            this.comboBoxFi.Name = "comboBoxFi";
            this.comboBoxFi.Size = new System.Drawing.Size(506, 29);
            this.comboBoxFi.TabIndex = 7;
            this.comboBoxFi.Text = "x + 7";
            this.comboBoxFi.Leave += new System.EventHandler(this.comboBoxFi_Leave);
            // 
            // groupBoxVar
            // 
            this.groupBoxVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVar.Location = new System.Drawing.Point(0, 195);
            this.groupBoxVar.Name = "groupBoxVar";
            this.groupBoxVar.Size = new System.Drawing.Size(723, 46);
            this.groupBoxVar.TabIndex = 136;
            this.groupBoxVar.TabStop = false;
            this.groupBoxVar.Text = "Переменные";
            this.groupBoxVar.Visible = false;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.richTextBoxLog.Location = new System.Drawing.Point(264, 247);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(453, 218);
            this.richTextBoxLog.TabIndex = 138;
            this.richTextBoxLog.Text = "";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL.Location = new System.Drawing.Point(94, 93);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(33, 21);
            this.labelL.TabIndex = 141;
            this.labelL.Text = "λ =";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lToolStripMenuItem.Text = "λ";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 490);
            this.Controls.Add(this.labelWait);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.buttonProgon);
            this.Controls.Add(this.groupBoxVar);
            this.Controls.Add(this.comboBoxFi);
            this.Controls.Add(this.comboBoxRo1);
            this.Controls.Add(this.comboBoxRo0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSopr);
            this.Controls.Add(this.radioButtonOff);
            this.Controls.Add(this.radioButtonOn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBoxVar);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelRo);
            this.Controls.Add(this.labelFi);
            this.Controls.Add(this.textBoxTau);
            this.Controls.Add(this.labelTau);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(739, 528);
            this.Name = "GeneralForm";
            this.ShowIcon = false;
            this.Text = "Точная формула для невязки оптимального аппроксимирующего сплайна простейшего ура" +
                "внения теплопроводности";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralForm_FormClosed);
            this.Resize += new System.EventHandler(this.GeneralForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.TextBox textBoxTau;
        private System.Windows.Forms.Label labelTau;
        private System.Windows.Forms.Label labelFi;
        private System.Windows.Forms.Label labelRo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RichTextBox richTextBoxVar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lBegin;
        private System.Windows.Forms.ToolStripStatusLabel lEnd;
        private System.Windows.Forms.ToolStripStatusLabel lTime;
        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЗначенияToolStripMenuItem;
        private System.Windows.Forms.Label labelSopr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRo0;
        private System.Windows.Forms.ComboBox comboBoxRo1;
        private System.Windows.Forms.ComboBox comboBoxFi;
        private System.Windows.Forms.GroupBox groupBoxVar;
        private System.Windows.Forms.Button buttonProgon;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.ToolStripMenuItem форматПредставленияЧиселToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFormat;
        private System.Windows.Forms.ToolStripMenuItem прогонкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прогоняемыйПараметрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem величинаШагаToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxStep;
        private System.Windows.Forms.ToolStripMenuItem интервалПрогонкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInterval;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem печататьПроверкуУсловийToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пробноеПостроениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикПрогонкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem кратностьВыбораПараболToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbChoose;
        private System.Windows.Forms.ToolStripMenuItem представлениеТочекToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comboBoxPoints;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
    }
}

