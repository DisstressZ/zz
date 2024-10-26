using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem
{
    [Serializable]
    public class Schedule
    {
        //массив на всю неделю. внешний массив - дни недели, внутренний - массив пар каждого дня недели + аудитория
        public List<List<(lesson, string)>> NotEvenWeek { get; }//нечетная неделя
        public List<List<(lesson, string)>> EvenWeek { get; }//четная неделя

        //при большом желании можно реализовать уникальное расписание на каждую неделю семестра,
        //создав отдельный массив на каждую учебную неделю.

        //кол-во пар в день
        public static int MaxCountOfLess = 6;

        //кол-во учебных недель(для подсчета часов в дальнейшем либо для создания уникального расписания)
        public static int CountOfWeeks = 9;//9 четных и 9 нечетных

        //название группы/фио преподавателя для которого составлено расписание
        public string Name;
        public bool IsGroup;

        //дисциплины которые есть у группы/преподавателя + кол-во часов
        public List<(lesson, int)> Lessons { get; }

        public Schedule(string name, bool isgroup, bool memory = false)
        {
            if (name == "")
                throw new ArgumentException();
            IsGroup = isgroup;
            EvenWeek= new List<List<(lesson, string)>>();//четная неделя
            NotEvenWeek = new List<List<(lesson, string)>>();//нечетная неделя
            Lessons = new List<(lesson, int)>();

            Name = name;

            //выделяем память

            if(memory)
            {
                for (int i = 0; i < 6; i++)
                {
                    List<(lesson, string)> list1 = new List<(lesson, string)>();
                    List<(lesson, string)> list2 = new List<(lesson, string)>();
                    for (int j = 0; j < MaxCountOfLess; j++)
                    {
                        list1.Add((null, ""));
                        list2.Add((null, ""));
                    }
                    EvenWeek.Add(list1);
                    NotEvenWeek.Add(list2);   
                }
            }
        }

        public bool Check()
        {
            for(int i = 0; i < Lessons.Count(); i++)
            {
                int hours = 0;

                for(int j = 0; j < EvenWeek.Count(); j++)
                {
                    for(int k = 0; k < EvenWeek[j].Count(); k++)
                    {
                        if (Lessons[i].Item1 == EvenWeek[j][k].Item1)
                            hours += 2;
                    }
                }
                for (int j = 0; j < NotEvenWeek.Count(); j++)
                {
                    for (int k = 0; k < NotEvenWeek[j].Count(); k++)
                    {
                        if (Lessons[i].Item1 == NotEvenWeek[j][k].Item1)
                            hours += 2;
                    }
                }

                hours *= 9;
                if (hours == Lessons[i].Item2)
                    continue;
                else return false;
            }
            return true;
        }
        public string GetLessonInfo(bool evenweek, int day, int num, bool groups)
        {
            if (day < 0 || day > 5 || num < 0 || num > 5)
                throw new ArgumentException();
            string res;
            if(!groups)
            {
                if (evenweek)
                {
                    if (EvenWeek[day][num].Item1 == null)
                        res = "";
                    else
                        res = EvenWeek[day][num].Item1.GetInfo() + " " + EvenWeek[day][num].Item2;
                }

                else
                {
                    if (NotEvenWeek[day][num].Item1 == null)
                        res = "";
                    else
                        res = NotEvenWeek[day][num].Item1.GetInfo() + " " + NotEvenWeek[day][num].Item2;
                }

            }

            else
            {
                if (evenweek)
                {
                    if (EvenWeek[day][num].Item1 == null)
                        res = "";
                    else
                        res = EvenWeek[day][num].Item1.GetInfo() + " " + EvenWeek[day][num].Item1.GetGroup() + " " + EvenWeek[day][num].Item2;
                }

                else
                {
                    if (NotEvenWeek[day][num].Item1 == null)
                        res = "";
                    else
                        res = NotEvenWeek[day][num].Item1.GetInfo() + " " + NotEvenWeek[day][num].Item1.GetGroup() + " " + NotEvenWeek[day][num].Item2;
                }

            }
            return res;
        }


        //ставим нужный предмет в нужное время
        public bool AddToSchedule(bool evenweek, int day, int num, lesson les, string auditorium = "")
        {
            int aud;
            if(day < 0 || day > 5 || num < 0 || num > 5 || les == null || !int.TryParse(auditorium, out aud))
                throw new ArgumentException();

            if(evenweek)
            {
                if (EvenWeek[day][num].Item1 == null)
                    EvenWeek[day][num] = (les, auditorium);
                else
                    return false;
            }

            else
            {
                if (NotEvenWeek[day][num].Item1 == null)
                    NotEvenWeek[day][num] = (les, auditorium);
                else
                    return false;
            }
            return true;
        }
        //удаляем ненужный предмет
        public void RemoveFromSch(bool evenweek, int day, int num)
        {
            if (day < 0 || day > 5 || num < 0 || num > 5)
                throw new ArgumentException();

            if (evenweek)
                EvenWeek[day][num] = (null, "");

            else
                NotEvenWeek[day][num] = (null, "");
        }

        //заполняем список дисциплин группы
        public void SetGroupLessons(string filetext)
        {
            if (filetext == "")
                throw new ArgumentException();

            //на входе содержимое текстового файла с учебным планом
            string[] strings = filetext.Split('\n');

            string[] words;
            for (int i = 1; i < strings.Length; i++)
            {
                if (strings[i] == "")
                    continue;
                words = strings[i].Split(';');
                for(int j = 0; j < words.Length; j++)
                {
                    if (words[j].First() == ' ')
                        words[j].Remove(0, 1);
                }

                if (words[2].Trim().ToLower() == "лекция")
                {
                    Lection l = new Lection(words[0], words[4], words[1]);
                    Lessons.Add((l, Convert.ToInt32(words[3])));
                }
                else
                {
                    Seminar s = new Seminar(words[0], Name, words[1]);
                    Lessons.Add((s, Convert.ToInt32(words[3])));
                }
            }
        }

    }
}
