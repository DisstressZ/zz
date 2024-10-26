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

namespace SchedulingSystem
{
    public partial class AddGroup : Form
    {
        private Form1 form1;
        string filePath = "";
        public AddGroup(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(GroupNameTB.Text == "")
            {
                MessageBox.Show("Номер группы не заполнен!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Schedule s in form1.ScheduleList)
            {
                if(s.Name.ToLower().Trim() == GroupNameTB.Text.ToLower().Trim())
                {
                    MessageBox.Show("Группа с таким номером уже существует!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(filePath == "")
            {
                MessageBox.Show("Учебный план не выбран!", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try 
            {
                Schedule schedule = new Schedule(GroupNameTB.Text, true, true);
                //читаем учебный план группы для того чтобы записать дисциплины
                string text;
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    text = sr.ReadToEnd();
                schedule.SetGroupLessons(text);

                //добавляем расписание группы(пока пустое) в массив расписаний
                form1.ScheduleList.Add(schedule);
                List<Schedule> professors = new List<Schedule>();
                bool flag = true;

                //смотрим всех преподавателей новой группы и если для них еще не создано расписание, то создаем объект и добавляем в коллекцию
                for(int i = 0; i < schedule.Lessons.Count(); i++)
                {
                    //смотрим уже созданных преподавателей
                    for (int j = 0; j < form1.ScheduleList.Count(); j++)
                    {
                        if (!form1.ScheduleList[j].IsGroup)
                        {
                            if (form1.ScheduleList[j].Name == schedule.Lessons[i].Item1.ProfessorName)
                            {
                                flag = false;
                                break;
                            }

                        }
                    }
                    if (!flag)
                        continue;
                    //смотрим преподавателей, которых добавили только что и еще не сохранили в общий список
                    for (int k = 0; k < professors.Count(); k++)
                    {
                        if (professors[k].Name == schedule.Lessons[i].Item1.ProfessorName)
                        {
                            flag = false;
                            break;
                        }
                        flag = true;
                    }
                    
                    if(flag)
                    {
                        //добавляем нового преподавателя
                        Schedule professor = new Schedule(schedule.Lessons[i].Item1.ProfessorName, false, true);
                        professors.Add(professor);
                    }
                }
                //выгружаем список добавленных преподавателей в общий список расписаний
                foreach(Schedule schedule1 in professors)
                {
                    form1.ScheduleList.Add(schedule1);
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так, попробуйте снова :( ", "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получаем имя выбранного файла с учебным планом
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != openFileDialog1.InitialDirectory)
                filePath = openFileDialog1.FileName;    
        }
    }
}
