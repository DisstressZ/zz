using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem
{
    [Serializable]
    public class Lection: lesson
    {

        //группы на лекции

        public Lection(string name, string groups, string professorName)
            :base(name, professorName)
        {
            //проверяем входные данные
            if (groups == "" )
                throw new ArgumentException();
            
            base.Group = groups;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " Лекция\n";
        }
    }
}
