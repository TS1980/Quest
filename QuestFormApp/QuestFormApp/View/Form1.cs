using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestFormApp.Model;
using QuestFormApp.Presenter;
//using QuestFormApp.View;

namespace QuestFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Welcome! Click \"Next>\" to start...");
            QuestPresenter presenter = new QuestPresenter(this);
        }
        QuestModel q1 = new QuestModel("Их относили к растительному миру, потом изучив, выделили в особую группу.", "A.Водоросли B.Грибы C.Споровые", 'B');
        QuestModel q2 = new QuestModel("Сколько хромосом у человека ?", "А.5 В.47 C.46", 'C');
        QuestModel q3 = new QuestModel("Tорговый итальянский город:", "А.Милан В.Неаполь С.Вениция ", 'C');
        List<QuestModel> Questions = new List<QuestModel>();
        public int count = 0;
        public int correct_answers = 0;
        public char choosen_var;

        public void Checker()
        {
            Questions.Clear();
            Questions.Add(q1);
            Questions.Add(q2);
            Questions.Add(q3);
            listBox1.Items.Clear();
            //listBox1.Items.Add($"{count + 1}" + Questions[count].Que + Questions[count].VAR);
            if (count == 0)
                listBox1.Items.Add("Их относили к растительному миру, потом изучив, выделили в особую группу.A.Водоросли B.Грибы C.Споровые");
            else if (count == 1)
                listBox1.Items.Add("Сколько хромосом у человека ? А.5 В.47 C.46");
            else if (count == 2)
                listBox1.Items.Add("Tорговый итальянский город: А.Милан В.Неаполь С.Вениция D.Феррера ");
            listBox1.Show();
            if (count == 0)
                MessageBox.Show("Begin ...");
            else if (count == 3)
                MessageBox.Show($"{correct_answers} correct answers");
            else
            {
                if (choosen_var == Questions[count].CV)
                {
                    correct_answers++;
                    MessageBox.Show("CORRECT!!!");
                }
                else
                    MessageBox.Show("WRONG!!!");
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Checker();
            count++;
            choosen_var = '_';
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VarA_Click(object sender, EventArgs e)
        {
            choosen_var = 'A';
        }

        private void VarB_Click(object sender, EventArgs e)
        {
            choosen_var = 'B';
        }

        private void VarC_Click(object sender, EventArgs e)
        {
            choosen_var = 'C';
        }

        private void VarD_Click(object sender, EventArgs e)
        {
            choosen_var = 'D';
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(Questions[count].Que);
        }
    }
}

