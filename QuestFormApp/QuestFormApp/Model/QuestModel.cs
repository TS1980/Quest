using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestFormApp.Model
{
    public class QuestModel
    {
        private string quest;

        public string Que
        {
            get { return quest; }
            set { quest = value; }
        }

        private char cv;

        public char CV
        {
            get { return cv; }
            set { cv = value; }
        }

        private string Var;

        public string VAR
        {
            get { return Var; }
            set { Var = value; }
        }


        static void CountSys(List<QuestModel> Q, int count)
        {
            char vrn = Char.Parse(Console.ReadLine());
            for (int i = 0; i < Q.Count; i++)
            {
                if (vrn == Q[i].cv)
                    count++;
            }
        }

        private string v1;
        private string v2;
        private char v3;

        public QuestModel(string v1, string v2, char v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}

