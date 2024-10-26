using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace SchedulingSystem
{
    public partial class Form1 : Form
    {
        //все существующие расписания
        public List<Schedule> ScheduleList = new List<Schedule>();
        //флаг того какая вкладка  выбрана
        bool groups = true;
        string typeoflection;
        string typeofseminar;

        public Form1()
        {
            InitializeComponent();
            ScheduleTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ScheduleTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ProfessorsSCH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProfessorsSCH.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Lection l = new Lection(" ", " ", " ");
            Seminar s = new Seminar(" ", " ", " ");
            typeoflection = l.GetType().ToString();
            typeofseminar = s.GetType().ToString();
            ReDraw();
        }

        //обновление списка групп и преподавателей в комбобоксах
        void UpdGroupsAndProfs()
        {
            GroupNamesCMB.Items.Clear();
            ProfessorsCMB.Items.Clear();

            foreach(Schedule schedule in ScheduleList)
            {
                if (schedule.IsGroup)
                    GroupNamesCMB.Items.Add(schedule.Name);
                else
                    ProfessorsCMB.Items.Add(schedule.Name);
            }

        }
        
        //перерисовка иаблицы
        void ReDraw()
        {
            int rowsminh;

            ScheduleTable.Rows.Clear();
            ProfessorsSCH.Rows.Clear();
            //рисуем пустую таблицу
            for (int i = 0; i < Schedule.MaxCountOfLess; i++)
            {
                //добавление записи в таблицу
                ScheduleTable.Rows.Add();
                ProfessorsSCH.Rows.Add();

                ScheduleTable.Rows[i].Cells[0].Value = i + 1;
                ProfessorsSCH.Rows[i].Cells[0].Value = i + 1;

                for (int j = 1; j < 7; j++)
                {
                    ScheduleTable.Rows[i].Cells[j].Value = "";
                    ProfessorsSCH.Rows[i].Cells[j].Value = "";
                }
            }

            if(groups)
            {
                rowsminh = (ScheduleTable.Height - ScheduleTable.ColumnHeadersHeight) / Schedule.MaxCountOfLess;
                for(int i = 0; i < Schedule.MaxCountOfLess; i++)
                {
                    ScheduleTable.Rows[i].MinimumHeight = rowsminh;
                }

                if (GroupNamesCMB.SelectedIndex == -1)
                    return;

                int numofgr = -1;
                for(int i = 0; i < ScheduleList.Count(); i++)
                {
                    if(ScheduleList[i].IsGroup && ScheduleList[i].Name == GroupNamesCMB.SelectedItem.ToString())
                    {
                        numofgr = i;
                        break;
                    }
                }
                for (int i = 0; i < Schedule.MaxCountOfLess; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Week.SelectedIndex == 0)
                            ScheduleTable.Rows[i].Cells[j + 1].Value = ScheduleList[numofgr].GetLessonInfo(true, j, i, !ScheduleList[numofgr].IsGroup);

                        if (Week.SelectedIndex == 1)
                            ScheduleTable.Rows[i].Cells[j + 1].Value = ScheduleList[numofgr].GetLessonInfo(false, j, i, !ScheduleList[numofgr].IsGroup);
                    }
                }
            }
            else
            {
                rowsminh = (ProfessorsSCH.Height - ProfessorsSCH.ColumnHeadersHeight) / Schedule.MaxCountOfLess;
                for (int i = 0; i < Schedule.MaxCountOfLess; i++)
                {
                    ProfessorsSCH.Rows[i].MinimumHeight = rowsminh;
                }

                if (ProfessorsCMB.SelectedIndex == -1)
                    return;

                int numofprof = -1;
                for (int i = 0; i < ScheduleList.Count(); i++)
                {
                    if (!ScheduleList[i].IsGroup && ScheduleList[i].Name == ProfessorsCMB.SelectedItem.ToString())
                    {
                        numofprof = i;
                        break;
                    }
                }
                for (int i = 0; i < Schedule.MaxCountOfLess; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (ProfWeek.SelectedIndex == 0)
                            ProfessorsSCH.Rows[i].Cells[j + 1].Value = ScheduleList[numofprof].GetLessonInfo(true, j, i, !ScheduleList[numofprof].IsGroup);

                        if (ProfWeek.SelectedIndex == 1)
                            ProfessorsSCH.Rows[i].Cells[j + 1].Value = ScheduleList[numofprof].GetLessonInfo(false, j, i, !ScheduleList[numofprof].IsGroup);
                    }
                }
            }
            
        }

        //чтение сохраненного рапсисания
        private void FileOpen_Click(object sender, EventArgs e)
        {
            string filePath = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != openFileDialog1.InitialDirectory)
                filePath = openFileDialog1.FileName;

            try
            {

                if (File.Exists(filePath))
                {
                    ScheduleList.Clear();
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    ScheduleList = JsonConvert.DeserializeObject<List<Schedule>>(File.ReadAllText(filePath), settings);
                }
            }
            catch
            {
                MessageBox.Show("Файл поврежден или имет некорректный формат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            UpdGroupsAndProfs();
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            AddGroup addGroup = new AddGroup(this);

            //вызываем форму для ввода данных о новой группе
            addGroup.ShowDialog();
            UpdGroupsAndProfs();

        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {

            if (GroupNamesCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Группа, которую вы хотите удалить, не выбрана!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = -1;
            for (int i = 0; i < ScheduleList.Count(); i++)
            {
                if (ScheduleList[i].Name == GroupNamesCMB.SelectedItem.ToString())
                    index = i;
            }
            if (index > -1)
                ScheduleList.RemoveAt(index);

            GroupNamesCMB.Text = "";

            UpdGroupsAndProfs();
            ReDraw();
        }
        private void Professors_Click(object sender, EventArgs e)
        {
            GroupsGB.Visible = false;
            ProfessorsGB.Visible = true;
            groups = false;
            ReDraw();

            GroupNamesCMB.SelectedIndex = -1;
            GroupNamesCMB.Text = "";
            Week.SelectedIndex = -1;
            Week.Text = "";
            TypeOfLessCMB.SelectedIndex = -1;
            TypeOfLessCMB.Text = "";
            LessonsCMB.Items.Clear();
            LessonsCMB.Text = "";
            AudTB.Text = "";
        }

        private void GroupMenu_Click(object sender, EventArgs e)
        {
            GroupsGB.Visible = true;
            ProfessorsGB.Visible = false;
            groups = true;
            ReDraw();

            ProfessorsCMB.SelectedIndex = -1;
            ProfessorsCMB.Text = "";
            ProfWeek.SelectedIndex = -1;
            ProfWeek.Text = "";
        }
        private void TypeOfLessCMB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (GroupNamesCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Группа, которой вы хотите назначить занятие, не выбрана!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numofgr = -1;
            for (int i = 0; i < ScheduleList.Count(); i++)
            {
                if (ScheduleList[i].IsGroup && ScheduleList[i].Name == GroupNamesCMB.SelectedItem.ToString())
                {
                    numofgr = i;
                    break;
                }
            }
            string type;
            if (TypeOfLessCMB.SelectedIndex == 0)
                type = typeoflection;
            else
                type = typeofseminar;

            LessonsCMB.Items.Clear();
            LessonsCMB.Text = "";
            AudTB.Text = "";

            for (int i = 0; i < ScheduleList[numofgr].Lessons.Count(); i++)
            {
                if (ScheduleList[numofgr].Lessons[i].Item1.GetType().ToString() == type)
                    LessonsCMB.Items.Add(ScheduleList[numofgr].Lessons[i].Item1.Name);
            }    
        }

        void Add()
        {
            if (ScheduleTable.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("Не выбран день и время проведения занятия.\nНажмите на ячейку таблицы которая соответствует нужному дню и времени.", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Week.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана неделя!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GroupNamesCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Группа, которой вы хотите назначить занятие, не выбрана!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TypeOfLessCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран тип занятия!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LessonsCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Дисциплина не выбрана!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int day = ScheduleTable.CurrentCell.ColumnIndex - 1;
            int les = ScheduleTable.CurrentCell.RowIndex;

            string type;
            if (TypeOfLessCMB.SelectedIndex == 0)
                type = typeoflection;
            else
                type = typeofseminar;

            int numofgr = -1;
            for (int i = 0; i < ScheduleList.Count(); i++)
            {
                if (ScheduleList[i].IsGroup && ScheduleList[i].Name == GroupNamesCMB.SelectedItem.ToString())
                {
                    numofgr = i;
                    break;
                }
            }

            if (Week.SelectedIndex == 0)
            {
                if (ScheduleList[numofgr].EvenWeek[day][les].Item1 != null)
                {
                    MessageBox.Show("В это время уже есть занятие!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (Week.SelectedIndex == 1)
            {
                if (ScheduleList[numofgr].NotEvenWeek[day][les].Item1 != null)
                {
                    MessageBox.Show("В это время уже есть занятие!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //занятие, которое хотим добавить 
            lesson l;
            //в случае если день и время не заняты ни кем:
            if (type == typeoflection)
                l = new Lection(" ", " ", " ");
            else
                l = new Seminar(" ", " ", " ");
            //находим объект класса lesson по названию
            for (int m = 0; m < ScheduleList[numofgr].Lessons.Count; m++)
            {
                if (LessonsCMB.SelectedItem.ToString() == ScheduleList[numofgr].Lessons[m].Item1.Name && ScheduleList[numofgr].Lessons[m].Item1.GetType().ToString() == type)
                {
                    l = ScheduleList[numofgr].Lessons[m].Item1;
                    break;
                }
            }


            foreach (Schedule schedule in ScheduleList)
            {
                if (!schedule.IsGroup)
                    continue;
                //случай четной недели
                if (Week.SelectedIndex == 0)
                {
                    //если день и время у группы пустые, то нет смысла проверять 
                    if (schedule.EvenWeek[day][les].Item1 == null)
                        continue;

                    //если совпадает аудитория
                    if (schedule.EvenWeek[day][les].Item2 == AudTB.Text)
                    {
                        //если в выбранной аудитории не лекция
                        if (schedule.EvenWeek[day][les].Item1.GetType().ToString() != typeoflection || type != typeoflection)
                        {
                            MessageBox.Show("Аудитория занята!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AudTB.Clear();
                            return;
                        }
                        //если в выбранной аудитории лекция
                        if (schedule.EvenWeek[day][les].Item1.GetType().ToString() == typeoflection)
                        {
                            //если добавляемое занятие не лекция
                            if (type != typeoflection)
                            {
                                MessageBox.Show("Аудитория занята!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                AudTB.Clear();
                                return;
                            }

                            //если добавляем лекцию, то смотрим, должна ли наша группа быть на этой лекции
                            string[] groups = schedule.EvenWeek[day][les].Item1.GetGroup().Replace(",", "").Trim('\r').Split(' ');
                            //смотрим список групп, которые должны быть на этом предмете
                            for (int k = 0; k < groups.Length; k++)
                            {
                                //в списке групп на лекции нашлась наша
                                if (groups[k] == ScheduleList[numofgr].Name)
                                {
                                    //находим объект класса lesson в списке дисциплин группы
                                    lesson less = new Lection(" ", " ", " ");

                                    less = schedule.EvenWeek[day][les].Item1;

                                    try
                                    {
                                        if(l.Name == less.Name && l.ProfessorName == less.ProfessorName )
                                        {
                                            //добавляем этот объект в нужную ячейку нашего расписания
                                            ScheduleList[numofgr].AddToSchedule(!Convert.ToBoolean(Week.SelectedIndex), day, les, less, AudTB.Text);
                                            ReDraw();
                                            TypeOfLessCMB.SelectedIndex = -1;
                                            TypeOfLessCMB.Text = "";
                                            LessonsCMB.Items.Clear();
                                            LessonsCMB.Text = "";
                                            AudTB.Text = "";
                                            return;
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Что-то не так, попробуйте изменить параметры", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            MessageBox.Show("Аудитория занята!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AudTB.Clear();
                            return;
                        }
                    }
                    else
                        continue;

                }
                //аналогичный алгоритм для нечетной недели
                if (Week.SelectedIndex == 1)
                {
                    if (schedule.NotEvenWeek[day][les].Item1 == null)
                        continue;

                    if (schedule.NotEvenWeek[day][les].Item2 == AudTB.Text)
                    {

                        if (schedule.NotEvenWeek[day][les].Item1.GetType().ToString() != typeoflection || type != typeoflection)
                        {
                            MessageBox.Show("Аудитория занята!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AudTB.Clear();
                            return;
                        }
                        //если в выбранной аудитории лекция
                        if (schedule.NotEvenWeek[day][les].Item1.GetType().ToString() == typeoflection)
                        {
                            //если добавляемое занятие не лекция
                            if (type != typeoflection)
                            {
                                MessageBox.Show("Аудитория занята!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                AudTB.Clear();
                                return;
                            }
                            //если добавляем лекцию, то смотрим, должна ли наша группа быть на этой лекции
                            string[] groups = schedule.NotEvenWeek[day][les].Item1.GetGroup().Replace(",", "").Trim('\r').Split(' ');
                            //смотрим список групп, которые должны быть на этом предмете
                            for (int k = 0; k < groups.Length; k++)
                            {
                                //в списке групп на лекции нашлась наша
                                if (groups[k] == ScheduleList[numofgr].Name)
                                {
                                    //находим объект класса lesson в списке дисциплин группы
                                    lesson less = new Lection(" ", " ", " ");

                                    less = schedule.NotEvenWeek[day][les].Item1;

                                    try
                                    {
                                        if (l.Name == less.Name && l.ProfessorName == less.ProfessorName)
                                        {
                                            //добавляем этот объект в нужную ячейку нашего расписания
                                            ScheduleList[numofgr].AddToSchedule(!Convert.ToBoolean(Week.SelectedIndex), day, les, less, AudTB.Text);
                                            ReDraw();
                                            TypeOfLessCMB.SelectedIndex = -1;
                                            TypeOfLessCMB.Text = "";
                                            LessonsCMB.Items.Clear();
                                            LessonsCMB.Text = "";
                                            AudTB.Text = "";
                                            return;
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Что-то не так, попробуйте изменить параметры", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            MessageBox.Show("Аудитория занята!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AudTB.Clear();
                            return;
                        }
                    }
                    else
                        continue;
                }
            }

            try
            {
                
                //находим преподавателя, который должен вести предмет
                int indofprof = -1;

                for (int i = 0; i < ScheduleList.Count(); i++)
                {
                    if (!ScheduleList[i].IsGroup)
                    {
                        if (ScheduleList[i].Name == l.ProfessorName)
                        {
                            indofprof = i;
                            break;
                        }
                    }
                }
                if (!ScheduleList[indofprof].AddToSchedule(!Convert.ToBoolean(Week.SelectedIndex), day, les, l, AudTB.Text))
                {
                    MessageBox.Show("У преподавателя, который ведет этот предмет есть занятие в это время!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //добавляем его в расписание
                ScheduleList[numofgr].AddToSchedule(!Convert.ToBoolean(Week.SelectedIndex), day, les, l, AudTB.Text);
            }
            catch
            {
                MessageBox.Show("Что-то не так, попробуйте изменить параметры", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            ReDraw();

            TypeOfLessCMB.SelectedIndex = -1;
            TypeOfLessCMB.Text = "";
            LessonsCMB.Items.Clear();
            LessonsCMB.Text = "";
            AudTB.Text = "";
        }

        private void AddLessontoSch_Click_1(object sender, EventArgs e)
        {
            Add();
        }

        private void Week_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TypeOfLessCMB.SelectedIndex = -1;
            TypeOfLessCMB.Text = "";
            LessonsCMB.Items.Clear();
            LessonsCMB.Text = "";
            AudTB.Text = "";
            ReDraw();
        }

        private void ProfessorsCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void ProfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void GroupNamesCMB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //обновляем таблицу
            ReDraw();

            TypeOfLessCMB.SelectedIndex = -1;
            TypeOfLessCMB.Text = "";
            LessonsCMB.Items.Clear();
            LessonsCMB.Text = "";
            AudTB.Text = "";
        }
        void Remove()
        {
            int day = ScheduleTable.CurrentCell.ColumnIndex - 1;
            int les = ScheduleTable.CurrentCell.RowIndex;
            bool evenweek;
            string aud;
            int numofgr = -1;

            if (GroupNamesCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Группа не выбрана!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ScheduleTable.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("Не выбран день и время проведения занятия.\nНажмите на ячейку таблицы которая соответствует нужному дню и времени.", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Week.SelectedIndex == -1)
            {
                MessageBox.Show("Не указана неделя(четная/нечетная)!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Week.SelectedIndex == 0)
                evenweek = true;
            else
                evenweek = false;

            for (int i = 0; i < ScheduleList.Count(); i++)
            {
                if (ScheduleList[i].IsGroup && ScheduleList[i].Name == GroupNamesCMB.SelectedItem.ToString())
                {
                    numofgr = i;
                    break;
                }
            }
            lesson less = new lesson(" ", " ");
            //сохраняем предмет, который потом будем удалять у всех
            if (evenweek)
            {
                less = ScheduleList[numofgr].EvenWeek[day][les].Item1;
                aud = ScheduleList[numofgr].EvenWeek[day][les].Item2;
            }
            else
            {
                less = ScheduleList[numofgr].NotEvenWeek[day][les].Item1;
                aud = ScheduleList[numofgr].NotEvenWeek[day][les].Item2;
            }
            if (less == null)
                return;

            try
            {
                foreach (Schedule schedule in ScheduleList)
                {
                    if (evenweek)
                    {
                        //проверяем нужно ли что-то удалять
                        if (schedule.EvenWeek[day][les].Item1 != null)
                            //смотрим совпадает ли пара и аудитория
                            if (schedule.EvenWeek[day][les].Item1.ToString() == less.ToString())  
                                if(schedule.EvenWeek[day][les].Item2 == aud)
                                {//удаляем из расписания конкретной группы/преподавателя
                                    schedule.RemoveFromSch(evenweek, day, les);
                                }
                    }
                    else
                    {//проверяем нужно ли что-то удалять
                        if (schedule.NotEvenWeek[day][les].Item1 != null)
                            //смотрим совпадает ли пара и аудитория
                            if (schedule.NotEvenWeek[day][les].Item1.ToString() == less.ToString())
                                if(schedule.NotEvenWeek[day][les].Item2 == aud)
                                {//удаляем из расписания конкретной группы/преподавателя
                                    schedule.RemoveFromSch(evenweek, day, les);
                                }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. попробуйте еще раз!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReDraw();
        }
        private void DeleteLess_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            try
            {

                string filePath = "";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != saveFileDialog1.InitialDirectory)
                    filePath = saveFileDialog1.FileName;

                filePath += ".json";

                if (ScheduleList.Count != 0)//если ассортимент был удален полностью, то сохранять ничего не нужно
                {
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    JsonSerializer json = JsonSerializer.Create(settings);
                    using (StreamWriter sw = new StreamWriter(filePath))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        json.Serialize(writer, ScheduleList);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Пожалуйста попробуйте снова или обратитесь к специалистую", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            string filePath = "";
            folderBrowserDialog1.ShowDialog();
            filePath = folderBrowserDialog1.SelectedPath;
            try 
            {
                string name = DateTime.Now.ToString() + " Расписания ";
                name = name.Replace(":", "-");
                name = name.Replace("/", "_");

                Directory.CreateDirectory(filePath);
                foreach (Schedule schedule in ScheduleList)
                {
                    using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, name + schedule.Name + ".xls"), false, Encoding.GetEncoding(1251)))
                    {
                        sw.WriteLine("Четная неделя");
                        sw.WriteLine("№ пары\tПонедельник\tВторник\tСреда\tЧетверг\tПятница\tСуббота");
                        for (int i = 0; i < Schedule.MaxCountOfLess; i++)
                        {
                            string str = (i + 1).ToString() + "\t";
                            for (int j = 0; j < 6; j++)
                                str += (schedule.GetLessonInfo(true, j, i, !schedule.IsGroup) + "\t");
                            str = str.Replace("\n", "");
                            sw.WriteLine(str);
                        }
                        sw.WriteLine();
                        sw.WriteLine("Нечетная неделя");
                        sw.WriteLine("№ пары\tПонедельник\tВторник\tСреда\tЧетверг\tПятница\tСуббота");
                        for (int i = 0; i < Schedule.MaxCountOfLess; i++)
                        {
                            string str = (i + 1).ToString() + "\t";
                            for (int j = 0; j < 6; j++)
                            {
                                if (schedule.IsGroup)
                                    str += (schedule.GetLessonInfo(false, j, i, !schedule.IsGroup) + "\t");
                            }
                            str = str.Replace("\n", "");
                            sw.WriteLine(str);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Пожалуйста попробуйте снова или обратитесь к специалистую", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Расписания скопированы в папку\n " + filePath , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (GroupNamesCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Группа не выбрана!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numofgr = -1;
            for (int i = 0; i < ScheduleList.Count(); i++)
            {
                if (ScheduleList[i].IsGroup && ScheduleList[i].Name == GroupNamesCMB.SelectedItem.ToString())
                {
                    numofgr = i;
                    break;
                }
            }
            if (ScheduleList[numofgr].Check())
                MessageBox.Show("Расписание выбранной группы соответствует учебному плану по количеству часов.", "Успешно:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else MessageBox.Show("Расписание выбранной группы не соответствует учебному плану по количеству часов.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            string path = "help.txt";
            string info;

            using (StreamReader sr = new StreamReader(path))
                info = sr.ReadToEnd();

            MessageBox.Show(info, "Справка:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileBttn_Click(object sender, EventArgs e)
        {

        }
    }   
}
