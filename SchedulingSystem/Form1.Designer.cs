
namespace SchedulingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FileBttn = new System.Windows.Forms.ToolStripDropDownButton();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.Professors = new System.Windows.Forms.ToolStripStatusLabel();
            this.Help = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupsGB = new System.Windows.Forms.GroupBox();
            this.Check = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteLess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AudTB = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LessonsCMB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeOfLessCMB = new System.Windows.Forms.ComboBox();
            this.AddLessontoSch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Week = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupNamesCMB = new System.Windows.Forms.ComboBox();
            this.ScheduleTable = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfessorsGB = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfWeek = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProfessorsCMB = new System.Windows.Forms.ComboBox();
            this.ProfessorsSCH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.GroupsGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).BeginInit();
            this.ProfessorsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessorsSCH)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileBttn,
            this.GroupMenu,
            this.Professors,
            this.Help});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1421, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FileBttn
            // 
            this.FileBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileBttn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.FileSave,
            this.Export});
            this.FileBttn.Image = ((System.Drawing.Image)(resources.GetObject("FileBttn.Image")));
            this.FileBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileBttn.Name = "FileBttn";
            this.FileBttn.Size = new System.Drawing.Size(59, 24);
            this.FileBttn.Text = "Файл";
            this.FileBttn.Click += new System.EventHandler(this.FileBttn_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(224, 26);
            this.FileOpen.Text = "Открыть";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(224, 26);
            this.FileSave.Text = "Сохранить";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // Export
            // 
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(224, 26);
            this.Export.Text = "Экспорт";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // GroupMenu
            // 
            this.GroupMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGroup,
            this.DeleteGroup});
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Size = new System.Drawing.Size(75, 24);
            this.GroupMenu.Text = "Группы";
            this.GroupMenu.Click += new System.EventHandler(this.GroupMenu_Click);
            // 
            // AddGroup
            // 
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(234, 26);
            this.AddGroup.Text = "Добавить новую";
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // DeleteGroup
            // 
            this.DeleteGroup.Name = "DeleteGroup";
            this.DeleteGroup.Size = new System.Drawing.Size(234, 26);
            this.DeleteGroup.Text = "Удалить выбранную";
            this.DeleteGroup.Click += new System.EventHandler(this.DeleteGroup_Click);
            // 
            // Professors
            // 
            this.Professors.Name = "Professors";
            this.Professors.Size = new System.Drawing.Size(118, 20);
            this.Professors.Text = "Преподаватели";
            this.Professors.Click += new System.EventHandler(this.Professors_Click);
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(67, 20);
            this.Help.Text = "Справка";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // GroupsGB
            // 
            this.GroupsGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupsGB.Controls.Add(this.Check);
            this.GroupsGB.Controls.Add(this.groupBox2);
            this.GroupsGB.Controls.Add(this.label2);
            this.GroupsGB.Controls.Add(this.Week);
            this.GroupsGB.Controls.Add(this.label1);
            this.GroupsGB.Controls.Add(this.GroupNamesCMB);
            this.GroupsGB.Controls.Add(this.ScheduleTable);
            this.GroupsGB.Location = new System.Drawing.Point(7, 30);
            this.GroupsGB.Name = "GroupsGB";
            this.GroupsGB.Size = new System.Drawing.Size(1414, 743);
            this.GroupsGB.TabIndex = 4;
            this.GroupsGB.TabStop = false;
            // 
            // Check
            // 
            this.Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Check.Location = new System.Drawing.Point(1154, 394);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(242, 28);
            this.Check.TabIndex = 16;
            this.Check.Text = "Проверить группу";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DeleteLess);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.AudTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LessonsCMB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TypeOfLessCMB);
            this.groupBox2.Controls.Add(this.AddLessontoSch);
            this.groupBox2.Location = new System.Drawing.Point(1148, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 317);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление занятия";
            // 
            // DeleteLess
            // 
            this.DeleteLess.Location = new System.Drawing.Point(5, 283);
            this.DeleteLess.Name = "DeleteLess";
            this.DeleteLess.Size = new System.Drawing.Size(242, 28);
            this.DeleteLess.TabIndex = 8;
            this.DeleteLess.Text = "Отменить занятие";
            this.DeleteLess.UseVisualStyleBackColor = true;
            this.DeleteLess.Click += new System.EventHandler(this.DeleteLess_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Аудитория:";
            // 
            // AudTB
            // 
            this.AudTB.Location = new System.Drawing.Point(94, 154);
            this.AudTB.Mask = "0000";
            this.AudTB.Name = "AudTB";
            this.AudTB.Size = new System.Drawing.Size(100, 22);
            this.AudTB.TabIndex = 6;
            this.AudTB.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дисциплина:";
            // 
            // LessonsCMB
            // 
            this.LessonsCMB.FormattingEnabled = true;
            this.LessonsCMB.Location = new System.Drawing.Point(6, 106);
            this.LessonsCMB.Name = "LessonsCMB";
            this.LessonsCMB.Size = new System.Drawing.Size(242, 24);
            this.LessonsCMB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип занятия:";
            // 
            // TypeOfLessCMB
            // 
            this.TypeOfLessCMB.FormattingEnabled = true;
            this.TypeOfLessCMB.Items.AddRange(new object[] {
            "Лекция",
            "Семинар"});
            this.TypeOfLessCMB.Location = new System.Drawing.Point(5, 41);
            this.TypeOfLessCMB.Name = "TypeOfLessCMB";
            this.TypeOfLessCMB.Size = new System.Drawing.Size(242, 24);
            this.TypeOfLessCMB.TabIndex = 1;
            this.TypeOfLessCMB.SelectedIndexChanged += new System.EventHandler(this.TypeOfLessCMB_SelectedIndexChanged_1);
            // 
            // AddLessontoSch
            // 
            this.AddLessontoSch.Location = new System.Drawing.Point(5, 226);
            this.AddLessontoSch.Name = "AddLessontoSch";
            this.AddLessontoSch.Size = new System.Drawing.Size(242, 28);
            this.AddLessontoSch.TabIndex = 7;
            this.AddLessontoSch.Text = "Добавить занятие";
            this.AddLessontoSch.UseVisualStyleBackColor = true;
            this.AddLessontoSch.Click += new System.EventHandler(this.AddLessontoSch_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Неделя:";
            // 
            // Week
            // 
            this.Week.AutoCompleteCustomSource.AddRange(new string[] {
            "Нечетная",
            "Четная"});
            this.Week.FormattingEnabled = true;
            this.Week.Items.AddRange(new object[] {
            "Четная",
            "Нечетная"});
            this.Week.Location = new System.Drawing.Point(323, 18);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(142, 24);
            this.Week.TabIndex = 13;
            this.Week.SelectedIndexChanged += new System.EventHandler(this.Week_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Группа:";
            // 
            // GroupNamesCMB
            // 
            this.GroupNamesCMB.FormattingEnabled = true;
            this.GroupNamesCMB.Location = new System.Drawing.Point(73, 18);
            this.GroupNamesCMB.Name = "GroupNamesCMB";
            this.GroupNamesCMB.Size = new System.Drawing.Size(142, 24);
            this.GroupNamesCMB.TabIndex = 11;
            this.GroupNamesCMB.SelectedIndexChanged += new System.EventHandler(this.GroupNamesCMB_SelectedIndexChanged_1);
            // 
            // ScheduleTable
            // 
            this.ScheduleTable.AllowUserToAddRows = false;
            this.ScheduleTable.AllowUserToDeleteRows = false;
            this.ScheduleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
            this.ScheduleTable.GridColor = System.Drawing.SystemColors.Control;
            this.ScheduleTable.Location = new System.Drawing.Point(11, 48);
            this.ScheduleTable.MultiSelect = false;
            this.ScheduleTable.Name = "ScheduleTable";
            this.ScheduleTable.ReadOnly = true;
            this.ScheduleTable.RowHeadersVisible = false;
            this.ScheduleTable.RowHeadersWidth = 51;
            this.ScheduleTable.RowTemplate.Height = 24;
            this.ScheduleTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleTable.Size = new System.Drawing.Size(1118, 689);
            this.ScheduleTable.TabIndex = 10;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Num.FillWeight = 56.14974F;
            this.Num.HeaderText = "№ пары";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Num.Width = 89;
            // 
            // Monday
            // 
            this.Monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monday.FillWeight = 107.3084F;
            this.Monday.HeaderText = "Понедельник";
            this.Monday.MinimumWidth = 6;
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tuesday.FillWeight = 107.3084F;
            this.Tuesday.HeaderText = "Вторник";
            this.Tuesday.MinimumWidth = 6;
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wednesday.FillWeight = 107.3084F;
            this.Wednesday.HeaderText = "Среда";
            this.Wednesday.MinimumWidth = 6;
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Thursday
            // 
            this.Thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thursday.FillWeight = 107.3084F;
            this.Thursday.HeaderText = "Четверг";
            this.Thursday.MinimumWidth = 6;
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Friday
            // 
            this.Friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Friday.FillWeight = 107.3084F;
            this.Friday.HeaderText = "Пятница";
            this.Friday.MinimumWidth = 6;
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Saturday
            // 
            this.Saturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saturday.FillWeight = 107.3084F;
            this.Saturday.HeaderText = "Суббота";
            this.Saturday.MinimumWidth = 6;
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProfessorsGB
            // 
            this.ProfessorsGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfessorsGB.Controls.Add(this.label6);
            this.ProfessorsGB.Controls.Add(this.ProfWeek);
            this.ProfessorsGB.Controls.Add(this.label7);
            this.ProfessorsGB.Controls.Add(this.ProfessorsCMB);
            this.ProfessorsGB.Controls.Add(this.ProfessorsSCH);
            this.ProfessorsGB.Location = new System.Drawing.Point(7, 30);
            this.ProfessorsGB.Name = "ProfessorsGB";
            this.ProfessorsGB.Size = new System.Drawing.Size(1408, 743);
            this.ProfessorsGB.TabIndex = 16;
            this.ProfessorsGB.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Неделя:";
            // 
            // ProfWeek
            // 
            this.ProfWeek.AutoCompleteCustomSource.AddRange(new string[] {
            "Нечетная",
            "Четная"});
            this.ProfWeek.FormattingEnabled = true;
            this.ProfWeek.Items.AddRange(new object[] {
            "Четная",
            "Нечетная"});
            this.ProfWeek.Location = new System.Drawing.Point(539, 7);
            this.ProfWeek.Name = "ProfWeek";
            this.ProfWeek.Size = new System.Drawing.Size(158, 24);
            this.ProfWeek.TabIndex = 18;
            this.ProfWeek.SelectedIndexChanged += new System.EventHandler(this.ProfWeek_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Преподаватель:";
            // 
            // ProfessorsCMB
            // 
            this.ProfessorsCMB.FormattingEnabled = true;
            this.ProfessorsCMB.Location = new System.Drawing.Point(129, 8);
            this.ProfessorsCMB.Name = "ProfessorsCMB";
            this.ProfessorsCMB.Size = new System.Drawing.Size(312, 24);
            this.ProfessorsCMB.TabIndex = 16;
            this.ProfessorsCMB.SelectedIndexChanged += new System.EventHandler(this.ProfessorsCMB_SelectedIndexChanged);
            // 
            // ProfessorsSCH
            // 
            this.ProfessorsSCH.AllowUserToAddRows = false;
            this.ProfessorsSCH.AllowUserToDeleteRows = false;
            this.ProfessorsSCH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfessorsSCH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfessorsSCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfessorsSCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ProfessorsSCH.GridColor = System.Drawing.SystemColors.Control;
            this.ProfessorsSCH.Location = new System.Drawing.Point(11, 38);
            this.ProfessorsSCH.MultiSelect = false;
            this.ProfessorsSCH.Name = "ProfessorsSCH";
            this.ProfessorsSCH.ReadOnly = true;
            this.ProfessorsSCH.RowHeadersVisible = false;
            this.ProfessorsSCH.RowHeadersWidth = 51;
            this.ProfessorsSCH.RowTemplate.Height = 24;
            this.ProfessorsSCH.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfessorsSCH.Size = new System.Drawing.Size(1391, 689);
            this.ProfessorsSCH.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 56.14974F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№ пары";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 107.3084F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Понедельник";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 107.3084F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Вторник";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 107.3084F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Среда";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 107.3084F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Четверг";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 107.3084F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Пятница";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.FillWeight = 107.3084F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Суббота";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 785);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GroupsGB);
            this.Controls.Add(this.ProfessorsGB);
            this.Name = "Form1";
            this.Text = "Система составления расписания";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GroupsGB.ResumeLayout(false);
            this.GroupsGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).EndInit();
            this.ProfessorsGB.ResumeLayout(false);
            this.ProfessorsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessorsSCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileBttn;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripDropDownButton GroupMenu;
        private System.Windows.Forms.ToolStripMenuItem AddGroup;
        private System.Windows.Forms.ToolStripMenuItem DeleteGroup;
        private System.Windows.Forms.ToolStripStatusLabel Professors;
        private System.Windows.Forms.GroupBox GroupsGB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox AudTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LessonsCMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeOfLessCMB;
        private System.Windows.Forms.Button AddLessontoSch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Week;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupNamesCMB;
        private System.Windows.Forms.DataGridView ScheduleTable;
        private System.Windows.Forms.GroupBox ProfessorsGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProfWeek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ProfessorsCMB;
        private System.Windows.Forms.DataGridView ProfessorsSCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button DeleteLess;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripStatusLabel Help;
    }
}

