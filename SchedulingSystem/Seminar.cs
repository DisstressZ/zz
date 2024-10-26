using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem
{
    [Serializable]
    public class Seminar: lesson
    {

        public Seminar(string name, string group, string professorName)
            : base(name, professorName)
        {
            //проверяем входные данные
            if (group == "")
                throw new ArgumentException();
            
            //на семинаре одна группа
            Group = group;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " Семинар\n";
        }
    }
}
