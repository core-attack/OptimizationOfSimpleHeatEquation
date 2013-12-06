using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using zg = ZedGraph;


namespace OptimizationOfSimpleHeatEquation
{
    public partial class GeneralForm : Form
    {
        System.Globalization.NumberFormatInfo format;
        Parser p = new Parser();
        string fileEq = Application.StartupPath + "allEquations.txt";
        Encoding myEnc = Encoding.UTF8;
        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-us");
        string formatInfo = "000,000,000,000.00###";
        string sFormat = "{0:0.0000000000000000000}";

        

        public GeneralForm()
        {
            InitializeComponent();
            setFormatSep();
            setRtb();
            setComboBox();
            forEq();
            richTextBoxLog.Cursor = Cursors.IBeam;
            
        }

        //для уравнений
        void forEq()
        {
            if (!File.Exists(fileEq))
                File.WriteAllText(fileEq, "", myEnc);
            readFileEq();

            foreach (string s in listFi)
                //if (!listFi.Contains(s))
                    comboBoxFi.Items.Add(s);
            foreach (string s in listRo0)
                //if (!listRo0.Contains(s))
                    comboBoxRo0.Items.Add(s);
            foreach (string s in listRo1)
                //if (!listRo1.Contains(s))
                    comboBoxRo1.Items.Add(s);

        }

        //для ричтекстбоксов
        void setRtb()
        {
            oldW = Width;
        }

        void setFormatSep()
        {
            format = new System.Globalization.NumberFormatInfo();
            format.NumberDecimalSeparator = ",";

            string[] f = { "C", "C0", "C1", "C2", "C3",
                           "E", "E0", "E1", "E2", "E3", 
                           "F", "F0", "F1", "F2", "F3", 
                           "G", "G0", "G1", "G2", "G3", 
                           "N", "N0", "N1", "N2", "N3", 
                           "P", "P0", "P1", "P2", "P3", 
                           "R", "#,000.000", "0.###E-000", "000,000,000,000.00###"
                         };

            foreach (string s in f)
                toolStripComboBoxFormat.Items.Add(s);
        }

        zg.SymbolType pointView = new zg.SymbolType();
        void setComboBox()
        {
            string[] a = {"Круги", "Многоугольники" , "Плюсы", "Квадраты", "Звезды", "Треугольники вверх", "Треугольники вниз",
                             "V", "X", "По умолчанию", "Ничего"};
            comboBoxPoints.Items.AddRange(a);
            comboBoxPoints.Text = a[a.Length - 1];
            pointView = zg.SymbolType.None;
            

        }
        
        /*
         * τ
         * ɵ
         * α
         * β
         * ρ
         * ϕ
         * ω
         * ξ
         * θ
         */

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
                if (((TextBox)sender).Text.IndexOf(".") != -1)
                {
                    if (((TextBox)sender).Text.IndexOf(",") != -1)
                        ((TextBox)sender).Text = ((TextBox)sender).Text.Replace(".", "");
                    else
                        ((TextBox)sender).Text = ((TextBox)sender).Text.Replace(".", ",");
                }
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
            //double doub = jStar;
        }

        void addLog(string caption, string value)
        {
            richTextBoxLog.Text += caption + " = " + value + "\n";
        }

        void addLog(string caption)
        {
            richTextBoxLog.Text += caption + "\n";
        }

        void addVar(string caption, string value)
        {
            if (radioButtonOn.Checked)
                if (richTextBoxVar.Text.IndexOf(caption) == -1)
                    richTextBoxVar.Text += caption + " = " + value + "\n";
        }

        //
        //оформление ричтекстбокса
        //
        string bold = "<b>";
        string boldE = "</b>";
        string italic = "<i>";
        string italicE = "</i>";
        string under = "<u>";
        string underE = "</u>";
        string middle = "<m>";
        string middleE = "</m>";
        string center = "<c>";
        string left = "<l>";
        string right = "<r>";
        string defaultText = "";

        class selections
        {
            //позиция начала выделения жирного
            public int selectionStart = 0;
            //позиция окончания выделения жирного
            public int selectionEnd = 0;

            //какое выделение
            public bool bold = false;
            public bool italic = false;
            public bool under = false;
            public bool middle = false;
            public bool center = false;
            public bool left = false;
            public bool right = false;
            //индекс строки выделения в массиве всех строк
            public int index = 0;
        }

        //каждая строка может иметь несколько выделений
        List<List<selections>> listListSelections = new List<List<selections>>();

        void selectText(RichTextBox richTextBox)
        {
            try
            {
                listListSelections.Clear();
                List<string> rtbList = new List<string>();
                for (int i = 0; i < richTextBox.Lines.Length; i++)
                {
                    rtbList.Add(richTextBox.Lines[i]);
                }
                for (int i = 0; i < rtbList.Count; i++)
                {
                    List<selections> listSelections = new List<selections>();
                    string s = rtbList[i];
                    string sWhisOnlyTag = "";
                    sWhisOnlyTag = deleteTags(s, bold, boldE);
                    while (sWhisOnlyTag.IndexOf(bold) != -1)
                    {
                        selections sel = new selections();
                        sel.bold = true;
                        int Start = sWhisOnlyTag.IndexOf(bold);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(Start, bold.Length);
                        int End = sWhisOnlyTag.IndexOf(boldE);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(End, boldE.Length);
                        if (End == -1)
                            End = Start;
                        sel.index = i;
                        sel.selectionStart = Start;
                        sel.selectionEnd = End;
                        listSelections.Add(sel);
                    }
                    sWhisOnlyTag = deleteTags(s, italic, italicE);
                    while (sWhisOnlyTag.IndexOf(italic) != -1)
                    {
                        selections sel = new selections();
                        sel.italic = true;
                        int Start = sWhisOnlyTag.IndexOf(italic);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(Start, italic.Length);
                        int End = sWhisOnlyTag.IndexOf(italicE);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(End, italicE.Length);
                        if (End == -1)
                            End = Start;
                        sel.index = i;
                        sel.selectionStart = Start;
                        sel.selectionEnd = End;
                        listSelections.Add(sel);
                    }
                    sWhisOnlyTag = deleteTags(s, under, underE);
                    while (sWhisOnlyTag.IndexOf(under) != -1)
                    {
                        selections sel = new selections();
                        sel.under = true;
                        int Start = sWhisOnlyTag.IndexOf(under);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(Start, under.Length);
                        int End = sWhisOnlyTag.IndexOf(underE);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(End, underE.Length);
                        if (End == -1)
                            End = Start;
                        sel.index = i;
                        sel.selectionStart = Start;
                        sel.selectionEnd = End;
                        listSelections.Add(sel);
                    }
                    sWhisOnlyTag = deleteTags(s, middle, middleE);
                    while (sWhisOnlyTag.IndexOf(middle) != -1)
                    {
                        selections sel = new selections();
                        sel.middle = true;
                        int Start = sWhisOnlyTag.IndexOf(middle);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(Start, middle.Length);
                        int End = sWhisOnlyTag.IndexOf(middleE);
                        sWhisOnlyTag = sWhisOnlyTag.Remove(End, middleE.Length);
                        if (End == -1)
                            End = Start;
                        sel.index = i;
                        sel.selectionStart = Start;
                        sel.selectionEnd = End;
                        listSelections.Add(sel);
                    }
                    if (s.IndexOf(center) != -1)
                    {
                        selections sel = new selections();
                        sel.center = true;
                        sel.index = i;
                        listSelections.Add(sel);
                    }
                    if (s.IndexOf(left) != -1)
                    {
                        selections sel = new selections();
                        sel.left = true;
                        sel.index = i;
                        listSelections.Add(sel);
                    }
                    if (s.IndexOf(right) != -1)
                    {
                        selections sel = new selections();
                        sel.right = true;
                        sel.index = i;
                        listSelections.Add(sel);
                    }
                    listListSelections.Add(listSelections);
                    rtbList[i] = deleteTags(s);

                }
                richTextBox.Text = "";
                int length = 0;
                for (int i = 0; i < rtbList.Count; i++)
                {
                    richTextBox.AppendText(rtbList[i] + "\n");
                    for (int j = 0; j < listListSelections[i].Count; j++)
                    {
                        int end = Math.Abs(listListSelections[i][j].selectionEnd - listListSelections[i][j].selectionStart);
                        if (i != 0)
                            richTextBox.Select(listListSelections[i][j].selectionStart + length, end);
                        else
                            richTextBox.Select(listListSelections[i][j].selectionStart, Math.Abs(listListSelections[i][j].selectionEnd - listListSelections[i][j].selectionStart));
                        if (listListSelections[i][j].bold)
                        {
                            richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Bold);
                        }
                        if (listListSelections[i][j].italic)
                        {
                            richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Italic);
                        }
                        if (listListSelections[i][j].under)
                        {
                            richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Underline);
                        }
                        if (listListSelections[i][j].middle)
                        {
                            richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.Font, FontStyle.Strikeout);
                        }
                        if (listListSelections[i][j].center)
                            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                        if (listListSelections[i][j].left)
                            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                        if (listListSelections[i][j].right)
                            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
                    }
                    length += rtbList[i].Length + 1;
                    int lrtb = richTextBox.Text.Length;
                }
                deleteTags(richTextBox);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, "Проверьте синтаксис использованных тегов!");

            }
        }

        void deleteTags(RichTextBox richTextBox)
        {
            string[] tags = { bold, boldE, italic, italicE, under, underE, middle, middleE, center, left, right };
            foreach (string tag in tags)
                richTextBox.Text.Replace(tag, "");
        }

        string deleteTags(string s)
        {
            string[] tags = { bold, boldE, italic, italicE, under, underE, middle, middleE, center, left, right };
            foreach (string tag in tags)
                s = s.Replace(tag, "");
            return s;
        }

        //удаляет все теги, кроме двух указаных
        string deleteTags(string s, string exceptionTag1, string exceptionTag2)
        {
            string[] tags = { bold, boldE, italic, italicE, under, underE, middle, middleE, center, left, right };
            foreach (string tag in tags)
                if (exceptionTag1 != tag && exceptionTag2 != tag)
                    s = s.Replace(tag, "");
            return s;
        }

        List<string> deleteTags(List<string> l)
        {
            for (int i = 0; i < l.Count; i++ )
                l[i] = deleteTags(l[i]);
            return l;
        }

        //
        //закончили оформлять ричтекстбокс
        //

        bool goodFunc()
        {
            bool ok = false;
            double var1 = p.Evaluate(comboBoxRo0.Text, 1);
            ok = notErrors(p);
            if (!ok)
                return false;
            double var2 = p.Evaluate(comboBoxRo1.Text, 1);
            ok = notErrors(p);
            if (!ok)
                return false;
            double var3 = p.Evaluate(comboBoxFi.Text, 1);
            ok = notErrors(p);
            if (!ok)
                return false;
            return ok;
        }

        bool notErrors(Parser p)
        {
            if (p.err == Parser.Errors.NOEXP)
            {    MessageBox.Show("Ошибка: Выражение(-я) отсутствует. \nЗамечание: введите функцию(-и)."); return false; }
            if (p.err == Parser.Errors.OTHER)
            {    MessageBox.Show("Ошибка: Нарушение алгоритма. \nЗамечание: обратитесь к разработчику."); return false; }
            if (p.err == Parser.Errors.SYNTAX)
            {    MessageBox.Show("Ошибка: Синтаксическая ошибка. \nЗамечание: проверьте корректность введённой(-ых) функции(-й)."); return false; }
            if (p.err == Parser.Errors.UNBALPARENTS)
            {    MessageBox.Show("Ошибка: Дисбаланс скобок. \nЗамечание: Количество открывающих скобок не равно количеству закрывающих скобок."); return false; }
            if (p.err == Parser.Errors.DIVBYZERO)
            {    MessageBox.Show("Ошибка: Деление на нуль."); return false; }
            if (p.err == Parser.Errors.BREAK)
            { MessageBox.Show("Ошибка: Разрыв."); return false; }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (goodFunc())
                {

                    DateTime time1 = new DateTime();
                    DateTime time2 = new DateTime();
                    time1 = DateTime.Now;


                    if (!listFi.Contains(comboBoxFi.Text))
                    {
                        listFi.Add(comboBoxFi.Text);
                        comboBoxFi.Items.Add(comboBoxFi.Text);
                    }
                    if (!listRo0.Contains(comboBoxRo0.Text))
                    {
                        listRo0.Add(comboBoxRo0.Text);
                        comboBoxRo0.Items.Add(comboBoxRo0.Text);
                    }
                    if (!listRo1.Contains(comboBoxRo1.Text))
                    {
                        listRo1.Add(comboBoxRo1.Text);
                        comboBoxRo1.Items.Add(comboBoxRo1.Text);
                    }
                    lBegin.Text = "Начало вычисления: ";
                    lEnd.Text = "Конец вычисления: ";
                    lTime.Text = "Затрачено времени: ";

                    richTextBoxLog.Clear();
                    richTextBoxVar.Clear();
                    richTextBoxLog.Visible = richTextBoxVar.Visible = false;
                    labelWait.Visible = !radioButtonOn.Checked;

                    TaskSolution ts = new TaskSolution(Convert.ToInt16(textBoxN.Text), Convert.ToDouble(textBoxG.Text), Convert.ToDouble(textBoxL.Text), 
                        Convert.ToDouble(textBoxTau.Text), comboBoxRo0.Text, comboBoxRo1.Text, comboBoxFi.Text);
                    ts.getShortSolution();
                    //richTextBoxLog.Text = ts.printArrays();
                    string time = DateTime.Now.ToShortTimeString().Replace(':', '-') + " " + DateTime.Today.ToShortDateString().Replace('.', '_');
                    ts.Save(Application.StartupPath + "/" + time + ".txt");
                    System.Diagnostics.Process.Start(Application.StartupPath + "/" + time + ".txt");
                    labelWait.Text = "J* = " + ts.getJmin();
                    if (ts.getErrors().Equals(""))
                        richTextBoxLog.Text += "Ошибок нет\n";
                    else
                        richTextBoxLog.Text += "Найдены следующие ошибки:\n" + ts.getErrors();
                    //setTable();
                    if (radioButtonOn.Checked)
                    {
                        richTextBoxLog.Visible = richTextBoxVar.Visible = true;
                        //selectText(richTextBoxLog);
                        //selectText(richTextBoxVar);
                        richTextBoxLog.Text = File.ReadAllText(Application.StartupPath + "/" + time + ".txt");
                    }
                    time2 = DateTime.Now;
                    lBegin.Text += time1.ToLongTimeString();
                    lEnd.Text += time2.ToLongTimeString();
                    lTime.Text += (time2 - time1).ToString();

                    textBoxN.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n");
            }
        }


        private void radioButtonOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOn.Checked)
                radioButtonOff.Checked = false;
            else if (radioButtonOff.Checked)
                radioButtonOn.Checked = false;
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is RichTextBox)
            {
                if (e.KeyChar == '-')
                {
                    ((RichTextBox)sender).Font = new Font(((RichTextBox)sender).Font.Name, (float)(((RichTextBox)sender).Font.Size - 0.5), FontStyle.Regular);
                }
                else if (e.KeyChar == '+')
                    ((RichTextBox)sender).Font = new Font(((RichTextBox)sender).Font.Name, (float)(((RichTextBox)sender).Font.Size + 0.5), FontStyle.Regular);
            }
        }

        int currentW = 0;
        int oldW = 0;
        private void GeneralForm_Resize(object sender, EventArgs e)
        {
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                if (((CheckBox)sender).Checked)
                    ((CheckBox)sender).Text = "Условие сопряжения выполнено";
                else
                    ((CheckBox)sender).Text = "Условие сопряжения НЕ выполнено";
            }
        }

        private void показатьЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(getValuesFi(), "ϕ");
            //MessageBox.Show(getValuesRo(), "ρ");
            //char[] sep = { '\n' };
            //string[] s = getValuesFi().Split(sep);  
            //listBox1.Items.Add("                                 ϕ");
            //listBox1.Items.Add(DateTime.Now.ToLongTimeString());
            //listBox1.Items.AddRange(s);
            //string[] t = getValuesRo().Split(sep);
            //listBox2.Items.Add("                                 ρ");
            //listBox2.Items.Add(DateTime.Now.ToLongTimeString());
            //listBox2.Items.AddRange(s);
            //panelShow.Visible = true;
            MessageBox.Show(prUsl, "Проверка условий");
        }

        void myIncInt(TextBox tb)
        {
            int i = Convert.ToInt32(tb.Text);
            i += 1;
            tb.Text = i.ToString();
        }

        void myIncFloat(TextBox tb)
        {
            double i = Convert.ToDouble(tb.Text);
            i += 0.1 ;
            tb.Text = i.ToString();
        }

        void myDecInt(TextBox tb)
        {
            int i = Convert.ToInt32(tb.Text);
            i -= 1;
            tb.Text = i.ToString();
        }

        void myDecFloat(TextBox tb)
        {
            double i = Convert.ToDouble(tb.Text);
            i -= 0.1;
            tb.Text = i.ToString();
        }

        private void textBoxN_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                if (e.KeyCode == Keys.Down)
                {
                    switch (((TextBox)sender).Name)
                    {
                        case "textBoxN": myDecInt(((TextBox)sender));
                            break;
                        case "textBoxG": myDecFloat(((TextBox)sender));
                            break;
                        case "textBoxh": myDecInt(((TextBox)sender));
                            break;
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    switch (((TextBox)sender).Name)
                    {
                        case "textBoxN": myIncInt(((TextBox)sender));
                            break;
                        case "textBoxG": myIncFloat(((TextBox)sender));
                            break;
                        case "textBoxh": myIncFloat(((TextBox)sender));
                            break;
                    }
                }
            }
        }

        private void textBoxRo0_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBoxRo0_MouseEnter(object sender, EventArgs e)
        {
            if (sender is TextBox)
                toolTip1.SetToolTip(((TextBox)sender), ((TextBox)sender).Text);
        }


        List<string> listRo0 = new List<string>();
        List<string> listRo1 = new List<string>();
        List<string> listFi = new List<string>();
        //записывает в файл все уравнения
        void writeFileEq()
        {
            //readFileEq();
            StreamWriter sr = new StreamWriter(fileEq);
            sr.WriteLine("#ro0");
            foreach(string s in listRo0)
                sr.WriteLine(s);
            sr.WriteLine("#ro1");
            foreach (string s in listRo1)
                sr.WriteLine(s);
            sr.WriteLine("#fi");
            foreach (string s in listFi)
                sr.WriteLine(s);
            sr.Close();
        }
        //считывает из файла все уравнения
        void readFileEq()
        {
            string[] arr = File.ReadAllLines(fileEq, myEnc);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].IndexOf("#ro0") != -1)
                    while (i < arr.Length && arr[i].IndexOf("#ro1") == -1 && arr[i].IndexOf("#fi") == -1)
                    {
                        if (arr[i].IndexOf("#ro0") == -1)
                            listRo0.Add(arr[i]);

                        i++;
                    }
                if (arr[i].IndexOf("#ro1") != -1)
                    while (i < arr.Length && arr[i].IndexOf("#fi") == -1 )
                    {
                        if (arr[i].IndexOf("#ro1") == -1)
                            listRo1.Add(arr[i]);
                        i++;
                    }
                if (arr[i].IndexOf("#fi") != -1)
                    while (i < arr.Length)
                    {
                        if (arr[i].IndexOf("#fi") == -1)
                            listFi.Add(arr[i]);
                        i++;
                    }
            }
        }

        private void GeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            writeFileEq();
        }

        //есть ли уже в этом списке данная строка
        bool isHave(List<string> l, string s)
        {
            foreach (string ss in l)
                if (ss == s)
                    return true;
            return false;
        }

        bool isHave(List<double> l, double s)
        {
            foreach (double ss in l)
                if (ss == s)
                    return true;
            return false;
        }

        bool isHave(List<PointF> l, PointF s)
        {
            foreach (PointF ss in l)
                if (ss.X == s.X && ss.Y == s.Y)
                    return true;
            return false;
        }

        int arrLenght = 0;
        void lbl_Click(object sender, EventArgs e)
        {
            if (sender is Label)
                for (int i = 0; i < arrLenght; i++)
                    if (((Label)sender).Name.IndexOf(i.ToString()) != -1)
                        foreach (object o in groupBoxVar.Controls)
                            if (o is RichTextBox)
                                if (((RichTextBox)o).Name == "rtb" + i.ToString())
                                {

                                    richTextBoxLog.Text = "<b>" + ((Label)sender).Text + "</b> \n" + ((RichTextBox)o).Text;
                                    selectText(richTextBoxLog);
                                }
        }

        void lbl_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label)
                for (int i = 0; i < arrLenght; i++)
                    if (((Label)sender).Name.IndexOf(i.ToString()) != -1)
                        foreach (object o in groupBoxVar.Controls)
                            if (o is RichTextBox)
                                if (((RichTextBox)o).Name == "rtb" + i.ToString())
                                    if ("τ[i]XYρ0ρ1ϕPξωWZ^2k".IndexOf(((Label)sender).Text) == -1 || ((Label)sender).Text == "τ")
                                    { toolTip1.SetToolTip(((Label)sender), deleteTags(((RichTextBox)o).Text)); }
                                    else
                                    { 
                                        string s = "";
                                        for (int j = 0; j < 5; j++)
                                        {
                                            if (((RichTextBox)o).Lines.Length > j)
                                                s += deleteTags(((RichTextBox)o).Lines[j]) + "\n";
                                        }
                                        if (s.IndexOf("...") == -1)
                                            s += "...";
                                        toolTip1.SetToolTip(((Label)sender), s);
                                    }
        }

        

        private void comboBoxFi_Leave(object sender, EventArgs e)
        {
        }

        private void labelSopr_MouseEnter(object sender, EventArgs e)
        {
        }
        string prUsl = "";
        
        private void textBoxG_Leave(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripComboBox)
                if (((ToolStripComboBox)sender).Text != "")
                    formatInfo = ((ToolStripComboBox)sender).Text;
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ((ToolStripMenuItem)sender).Checked = true;
                if (((ToolStripMenuItem)sender).Name == "nToolStripMenuItem")
                {
                    tToolStripMenuItem.Checked = false;
                    gToolStripMenuItem.Checked = false;
                    lToolStripMenuItem.Checked = false;
                }
                else if (((ToolStripMenuItem)sender).Name == "tToolStripMenuItem")
                {
                    nToolStripMenuItem.Checked = false;
                    gToolStripMenuItem.Checked = false;
                    lToolStripMenuItem.Checked = false;
                }
                else if (((ToolStripMenuItem)sender).Name == "gToolStripMenuItem")
                {
                    nToolStripMenuItem.Checked = false;
                    tToolStripMenuItem.Checked = false;
                    lToolStripMenuItem.Checked = false;
                }
                else if (((ToolStripMenuItem)sender).Name == "lToolStripMenuItem")
                {
                    nToolStripMenuItem.Checked = false;
                    tToolStripMenuItem.Checked = false;
                    gToolStripMenuItem.Checked = false;
                }
            }

        }

        private void textBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (sender is TextBox)
                {
                    if (((TextBox)sender).Name == "textBoxN" || ((TextBox)sender).Name == "tbChoose")
                    {
                        if (e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if (e.KeyChar != ',' && e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                }
                else if (sender is ToolStripTextBox)
                {
                    if (e.KeyChar != ',' && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }

            }
        }


        //сохранение в txt
        void MySave(List<string> l)
        {
            try
            {
                //filename = Application.StartupPath + "\\mySavedFiles\\" + ".txt";
                SaveFileDialog savedialog = saveFileDialog1;
                savedialog.FileName = DateTime.Now.ToShortTimeString().Replace(":", "-") + "_" + DateTime.Now.ToShortDateString().Replace(".", "-") + "_";
                savedialog.Title = "Сохранить как ...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter =
                   "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
                savedialog.ShowHelp = true;
                char[] sep = { '\\' };
                // If selected, save
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the user-selected file name
                    string fileName = savedialog.FileName;
                    //fileName = fileName.Remove(fileName.Length - 4);
                    // Get the extension
                    string strFilExtn =
                        fileName.Remove(0, fileName.Length - 3);
                    // Save file
                    switch (strFilExtn)
                    {
                        case "txt":
                            {
                                File.WriteAllLines(fileName, l, myEnc);
                                lTime.Text += " Результаты сохранены в файл: " + fileName;
                            }
                            break;
                    }
                    
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
        }

        private void печататьПроверкуУсловийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            richTextBoxLog.Text = richTextBoxVar.Text = "";
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFunc();
        }

        void saveFunc()
        {
            try
            {
                SaveFileDialog savedialog = saveFileDialog1;
                savedialog.FileName = "N=" + textBoxN.Text.ToString() + "lambda=" + textBoxL.Text.ToString() + "gamma=" + textBoxG.Text.ToString() + "tau=" + textBoxTau.Text.ToString();
                savedialog.Title = "Сохранить как ...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter =
                   "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
                savedialog.ShowHelp = true;
                char[] sep = { '\\' };
                // If selected, save
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the user-selected file name
                    string fileName = savedialog.FileName;
                    //fileName = fileName.Remove(fileName.Length - 4);
                    // Get the extension
                    string strFilExtn =
                        fileName.Remove(0, fileName.Length - 3);
                    // Save file
                    switch (strFilExtn)
                    {
                        case "txt":
                            {

                                File.WriteAllLines(fileName, saveAll(), myEnc);
                                lTime.Text += " Результаты сохранены в файл: " + fileName;
                                richTextBoxLog.Text += "Результаты сохранены в файл: " + fileName;
                            }
                            break;
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
        
        }

        List<string> saveAll()
        {
            /*List<string> l = new List<string>();
            //object[] arr = { N, n, h, GAMMA, TAU, TETA, x, listTau, listX, listY, ro0List, ro1List, fiList, listU, listP, listKsi, listOmegaSmall, listOmegaBig, listBigTeta, listZ };
            
            l.Add(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
            l.Add("N = " + N.ToString());
            l.Add("n = " + n.ToString());
            l.Add("h = " + h.ToString());
            l.Add("γ = " + GAMMA.ToString());
            l.Add("τ = " + TAU.ToString());
            l.Add("ɵ = " + TETA.ToString());
            l.Add("x = " + x.ToString());
            if (listTau.Count != 0)
            {
                l.Add("Список значений τ с индексами:");
                foreach (string s in listTau)
                    l.Add("    " + s);
            }
            if (listX.Count != 0)
            {
                l.Add("Список значений X:");
                foreach (string s in listX)
                    l.Add("    " + s);
            }
            if (listY.Count != 0)
            {
                l.Add("Список значений Y:");
                foreach (string s in listY)
                    l.Add("    " + s);
            }
            if (ro0List.Count != 0)
            {
                l.Add("Список значений ρ0: ");
                foreach (PointF s in ro0List)
                    l.Add("    " + s.X + ":" + s.Y);
            }
            if (ro1List.Count != 0)
            {
                l.Add("Список значений ρ1: ");
                foreach (PointF s in ro1List)
                    l.Add("    " + s.X + ":" + s.Y);
            }
            if (fiList.Count != 0)
            {
                l.Add("Список значений ϕ: ");
                foreach (PointF s in fiList)
                    l.Add("    " + s.X + ":" + s.Y);
            }
            if (arrayU != null)
            {
                l.Add("Список значений многочлена Чебышева:");
                for (int i = 0; i < arrayU.Length; i++)
                    l.Add("    U(" + i.ToString() + ") = " + arrayU[i].ToString());
            }
            if (listP.Count != 0)
            {
                l.Add("Список значений переопределенного многочлена Чебышева:");
                foreach (string s in listP)
                    l.Add("    " + s.ToString());
            }
            if (listKsi.Count != 0)
            {
                l.Add("Список значений ξ:");
                foreach (string s in listKsi)
                    l.Add("    " + s);
            }
            if (listOmegaSmall.Count != 0)
            {
                l.Add("Список значений ω:");
                foreach (string s in listOmegaSmall)
                    l.Add("    " + s);
            }
            if (listOmegaBig.Count != 0)
            {
                l.Add("Список значений W:");
                foreach (string s in listOmegaBig)
                    l.Add("    " + s);
            }
            if (listBigTeta.Count != 0)
            {
                l.Add("Список значений θ:");
                foreach (string s in listBigTeta)
                    l.Add("    " + s);
            }
            if (listZ.Count != 0)
            {
                l.Add("Список значений Z^2k:");
                foreach (string s in listZ)
                    l.Add("    " + s);
            }
            l.Add("Первое слагаемое = " + labelsecond.Text);
            l.Add("Второе слагаемое = " + labelthird.Text);
            l.Add("Третее слагаемое = " + labelfourth.Text);
            l.Add("Функционал " + labelResult.Text);
            l.Add(lTime.Text);
            l.Add("");
            return deleteTags(l);*/
            return null;
        }

        List<double> zArr = new List<double>();
        //вычисление функционала без записей логов итп
        

        float sqr(float x)
        {
            return x * x;
        }

        List<PointF> buildParab(PointF p1, PointF p2, PointF p3)
        {
            try
            {
                float x1 = p1.X;
                float x2 = p2.X;
                float x3 = p3.X;
                float y1 = p1.Y;
                float y2 = p2.Y;
                float y3 = p3.Y;

                float a = 0;
                float b = 0;
                float c = 0;
                //ищем уравнение параболы
                if (x2 - x1 != 0)
                {
                    a = (y3 - ((x3 * (y2 - y1) + x2 * y1 - x1 * y2) / (x2 - x1))) 
                        / (x3 * (x3 - x1 - x2) + x1 * x2);
                    b = (y2 - y1) / (x2 - x1) - a*(x1 + x2);
                    c = (x2 * y1 - x1 * y2) / (x2 - x1) + a * x1 * x2;

                }
                else if (p1.X == 0 && p2.X != 0 && p3.X != 0)
                { 
                    c = p1.Y;
                    a = (p3.Y + p1.Y * (p3.X - 1) - p2.Y * p3.X) / (sqr(p3.X) * p2.X - sqr(p2.X) * p3.X);
                    b = (p2.Y - p1.Y - a * sqr(p2.X)) / p2.X;
                }
                else if (p1.X != 0 && p2.X == 0 && p3.X != 0)
                {
                    c = p2.Y;
                    a = (- ((p1.Y - p2.Y) * p3.X - (p2.Y - p3.Y) * p1.X)) / (sqr(p3.X) * p1.X - sqr(p1.X) * p3.X);
                    b = (p1.Y - p2.Y - a * sqr(p1.X)) / p1.X;
                }
                else if (p1.X != 0 && p2.X != 0 && p3.X == 0)
                {
                    c = p3.Y;
                    a = (-((p2.Y - p3.Y) * p1.X - (p3.Y - p1.Y) * p2.X)) / (sqr(p1.X) * p2.X - sqr(p2.X) * p1.X);
                    b = (p2.Y - p3.Y - a * sqr(p2.X)) / p2.X;

                }
                
                List<PointF> list = new List<PointF>();
                List<string> log = new List<string>();
                /*
                float tau = ((float)1 / (float)(2 * N));
                if (a != 0 && b != 0 && c != 0)
                for (float i = 0; i < 7; i += tau)
                {
                    sqrEquation eq = new sqrEquation();
                    eq.calc(a, b, c - i);
                    if (!eq.notRealRoots)
                    {
                        if (eq.X1 >= h_(0) && eq.X1 <= h_(2))
                        { PointF point1 = new PointF(eq.X1, i); list.Add(point1); }
                        if (eq.X2 >= h_(0) && eq.X2 <= h_(2))
                        { PointF point2 = new PointF(eq.X2, i); list.Add(point2); }
                    }
                }*/
                list.Sort(new MyClassComparer());
                return list;
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
                return null;
            }
            

        }

        public class MyClassComparer : IComparer<PointF>
        {
            public int Compare(PointF p1, PointF p2)
            {
                return p1.X == p2.X ? 0 :
                    (p1.X < p2.X ? -1 : 1);
            }
        }

        //вычисление корней квадратного уравнения
        class sqrEquation
        {
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            //нет действительных корней
            public bool notRealRoots = false;

            public void calc(double a, double b, double c)
            {
                //считаем дискриминант
                double D = sqr(b) - 4 * a * c;
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    y1 = a * sqr(x1) + b * x1 + c;
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    y2 = a * sqr(x2) + b * x2 + c;
                }
                else if (D == 0)
                {
                    if (a != 0)
                    {
                        x1 = x2 = (-b) / (2 * a);
                        y1 = y2 = a * sqr(x1) + b * x1 + c;
                    }
                    else
                        y1 = y2 = c;
                }
                else
                    notRealRoots = true;
            }

            public float X1
            {
                get { return (float)x1; }
            }

            public float X2
            {
                get { return (float)x2; }
            }

            public float Y1
            {
                get { return (float)y1; }
            }

            public float Y2
            {
                get { return (float)y2; }
            }

            double sqr(double x)
            {
                return x * x;
            }

            static public int MyClassCompareDate(float x1, float x2)
            {
                return x1.CompareTo(x2);
            }
        }

        private void построитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime time1 = DateTime.Now;
            //Graph g = new Graph();
            //List<List<PointF>> l = new List<List<PointF>>();
            //int inc  = Convert.ToInt32(tbChoose.Text);
            //for (int i = 0; i < zArr.Count; i += inc)
            //{
            //    l.Add(buildParab(new PointF(0, (float)ro(0, i * TAU_)), 
            //                    new PointF((float)h, (float)zArr[i]),
            //                    new PointF((float)(2 * h), (float)ro(1, i * TAU_))));
            //}
            //g.DrawGraph(l, pointView, h_(2));
            //DateTime time2 = DateTime.Now;
            //g.Text = "Начало вычисления: " + time1.ToLongTimeString() + ". ";
            //g.Text += "Конец вычисления: " + time2.ToLongTimeString() + ". ";
            //g.Text += "Время построения: " + (time2 - time1).ToString();
            //g.Show();
        }

        private void пробноеПостроениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Graph g = new Graph();
            //List<List<PointF>> l = new List<List<PointF>>();
            //l.Add(buildParab(new PointF(0, 4), new PointF(1, 0), new PointF(2, -2)));
            //g.DrawGraph(l, pointView, h_(2));
            //g.Show();
        }

        private void графикПрогонкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Graph g = new Graph();
            //List<List<PointF>> l = new List<List<PointF>>();
            //l.Add(allJ);
            //g.DrawGraph(l, pointView, h_(2));
            //g.Show();
        }

        private void comboBoxPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPoints.SelectedIndex)
            {
                case 0: { pointView = zg.SymbolType.Circle; }
                    break;
                case 1: { pointView = zg.SymbolType.Diamond; }
                    break;
                case 2: { pointView = zg.SymbolType.Plus; }
                    break;
                case 3: { pointView = zg.SymbolType.Square; }
                    break;
                case 4: { pointView = zg.SymbolType.Star; }
                    break;
                case 5: { pointView = zg.SymbolType.Triangle; }
                    break;
                case 6: { pointView = zg.SymbolType.TriangleDown; }
                    break;
                case 7: { pointView = zg.SymbolType.VDash; }
                    break;
                case 8: { pointView = zg.SymbolType.XCross; }
                    break;
                case 9: { pointView = zg.SymbolType.Default; }
                    break;
                case 10: { pointView = zg.SymbolType.None; }
                    break;
                default: { pointView = zg.SymbolType.None; }
                    break;
            }
        }

        private void buttonProgon_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "J(N, lambda, gamma, tau)\n";
                int begin = Convert.ToInt16(toolStripTextBoxInterval.Text.Split(';')[0]);
                int end = Convert.ToInt16(toolStripTextBoxInterval.Text.Split(';')[1]);
                double inc = Convert.ToDouble(toolStripTextBoxStep.Text, format);
                string type = "";
                for (double t = begin; t < end; t += inc)
                {
                    Random r = new Random();
                    int N = 0;
                    double gamma = 0;
                    double lambda = 0;
                    double tau = 0;
                    if (nToolStripMenuItem.Checked)
                    {
                        N = Convert.ToInt16(t);
                        type = "N";
                    }
                    else
                        N = Convert.ToInt16(textBoxN.Text, format);
                    if (gToolStripMenuItem.Checked)
                    {
                        gamma = t;
                        type = "gamma";
                    }
                    else
                        gamma = Convert.ToDouble(textBoxG.Text, format);
                    if (lToolStripMenuItem.Checked)
                    {
                        lambda = t;
                        type = "lambda";
                    }
                    else
                        lambda = Convert.ToDouble(textBoxL.Text, format);
                    if (tToolStripMenuItem.Checked)
                    {
                        tau = t;
                        type = "tau";
                    }
                    else
                        tau = Convert.ToDouble(textBoxTau.Text, format);
                    string ro0 = String.Format(comboBoxRo0.Text);
                    string ro1 = String.Format(comboBoxRo1.Text);
                    string fi = String.Format(comboBoxFi.Text);
                    TaskSolution ts = new TaskSolution(N, gamma, lambda, tau, ro0, ro1, fi);
                    ts.getShortSolution();
                    string time = DateTime.Now.ToShortTimeString().Replace(':', '-') + " " + DateTime.Today.ToShortDateString().Replace('.', '_');
                    ts.Save(Application.StartupPath + "/" + time + ".txt");
                    result += String.Format("J({0}, {2}, {3}, {4}) = {1}\n", N, ts.getJmin(), lambda, gamma, tau);
                }
                richTextBoxLog.Text = result;
                File.WriteAllText("прогонка по " + type + " с " + begin.ToString() + " по " + end.ToString() + " " + DateTime.Now.ToShortTimeString().Replace(':', '-') + " " + DateTime.Today.ToShortDateString().Replace('.', '_') + ".txt", result);
                System.Diagnostics.Process.Start(Application.StartupPath + "/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void labelWait_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(labelWait.Text, labelWait);
        }

        
    }
}
