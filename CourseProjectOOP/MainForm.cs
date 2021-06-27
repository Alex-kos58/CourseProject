using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

// чтение из файла, меню сохранение в файл, всплывающие окно 
namespace CourseProjectOOP
{
    public partial class MainForm : Form
    {
       
        public List<Student> listSQL = new List<Student>();
        public MainForm()
        {
            HelloForm helloForm = new HelloForm();
            helloForm.Show();
            Thread.Sleep(3000);
            helloForm.Close();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            
            String FIO = textBox1.Text;
            if (!Regex.Match(FIO, "^[A-zА-я]+[ ]+[A-zА-я]+[ ]+[A-zА-я]+[ ]*$").Success)
            {
                info.Text = "ФИО некоректно";
                return;
            }
            
            String countOfWorks = textBox2.Text;
            int countOf = int.Parse(countOfWorks);
            
            if (countOf <= 0)
            {
                info.Text = "Количество работ не может быть отрицательным";
                return;
            }

            String yearOfCompetition = textBox4.Text;

            if (!Regex.Match(yearOfCompetition, "^[2][0][0-2][0-9][-][2][0][0-2][0-9]$").Success)
            {
                info.Text = "Недопустимые года";
                return;
            }
            
            
            String attendance = textBox3.Text;
            int attendanceInt = int.Parse(attendance);

            if (attendanceInt < 0)
            {
                info.Text = "Количество часов посещаемости не может быть отрицательным";
                return;
            }

            bool participationRes = false;
            String exam = textBox6.Text;
            if (exam.Equals("Да"))
            {
                participationRes = true;
            } 
            else if (exam.Equals("Нет"))
            {
                participationRes = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Участие в конкурсе|";
                return;
            }

            Student client = new Student(FIO, countOf, yearOfCompetition, attendanceInt, participationRes);

            if (listSQL.Contains(client))
            {
                info.Text = "Такой участник уже есть";
                return;
            }
            listSQL.Add(client);
            viewList();
            info.Text = "Добавлен";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            String FIO = textBox1.Text;
            if (!Regex.Match(FIO, "^[A-zА-я]+[ ]+[A-zА-я]+[ ]+[A-zА-я]+[ ]*$").Success)
            {
                info.Text = "ФИО некоректно";
                return;
            }
            
            String countOfWorks = textBox2.Text;
            int countOf = int.Parse(countOfWorks);
            
            if (countOf <= 0)
            {
                info.Text = "Количество работ не может быть отрицательным";
                return;
            }

            String yearOfCompetition = textBox4.Text;

            if (!Regex.Match(yearOfCompetition, "^[2][0][0-2][0-9][-][2][0][0-2][0-9]$").Success)
            {
                info.Text = "Недопустимые года";
                return;
            }
            
            
            String attendance = textBox3.Text;
            int attendanceInt = int.Parse(attendance);

            if (attendanceInt < 0)
            {
                info.Text = "Количество часов посещаемости не может быть отрицательным";
                return;
            }

            bool participationRes = false;
            String exam = textBox6.Text;
            if (exam.Equals("Да"))
            {
                participationRes = true;
            } 
            else if (exam.Equals("Нет"))
            {
                participationRes = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Участие в конкурсе|";
                return;
            }

            Student client = new Student(FIO, countOf, yearOfCompetition, attendanceInt, participationRes);

            if (listSQL.Contains(client))
            {
                info.Text = "Данный участник найден";
            }
            else
            {
                info.Text = "Данный участник не найден";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            String FIO = textBox1.Text;
            if (!Regex.Match(FIO, "^[A-zА-я]+[ ]+[A-zА-я]+[ ]+[A-zА-я]+[ ]*$").Success)
            {
                info.Text = "ФИО некоректно";
                return;
            }
            
            String countOfWorks = textBox2.Text;
            int countOf = int.Parse(countOfWorks);
            
            if (countOf <= 0)
            {
                info.Text = "Количество работ не может быть отрицательным";
                return;
            }

            String yearOfCompetition = textBox4.Text;

            if (!Regex.Match(yearOfCompetition, "^[2][0][0-2][0-9][-][2][0][0-2][0-9]$").Success)
            {
                info.Text = "Недопустимые года";
                return;
            }
            
            
            String attendance = textBox3.Text;
            int attendanceInt = int.Parse(attendance);

            if (attendanceInt < 0)
            {
                info.Text = "Количество часов посещаемости не может быть отрицательным";
                return;
            }

            bool participationRes = false;
            String exam = textBox6.Text;
            if (exam.Equals("Да"))
            {
                participationRes = true;
            } 
            else if (exam.Equals("Нет"))
            {
                participationRes = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Участие в конкурсе|";
                return;
            }

            Student client = new Student(FIO, countOf, yearOfCompetition, attendanceInt, participationRes);

            listSQL.Remove(client);
            viewList();
            info.Text = "Удалено";
        }
        
        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            Student valuePair = listSQL[0];
            ListViewItem item = new ListViewItem(valuePair.getFIO());
            item.SubItems.Add(valuePair.getCountOfCompletedWorks().ToString());
            item.SubItems.Add(valuePair.getYearOfCompetition().ToString());
            item.SubItems.Add(valuePair.getAttendance().ToString());
            item.SubItems.Add(valuePair.getParticipation().ToString());
            e.Item = item;
        }
        

        private void viewList()
        {
            listView1.Items.Clear();
            
            foreach (Student valuePair in listSQL)
            {
                ListViewItem item = new ListViewItem(valuePair.getFIO());
                item.SubItems.Add(valuePair.getCountOfCompletedWorks().ToString());
                item.SubItems.Add(valuePair.getYearOfCompetition().ToString());
                item.SubItems.Add(valuePair.getAttendance().ToString());
                item.SubItems.Add(valuePair.getParticipation().ToString());
                listView1.Items.Add(item);
            }
            listView1.VirtualListSize = listSQL.Count;
            listView1.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listView1_RetrieveVirtualItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                int index = int.Parse(textBox7.Text);
                if (index < 0 || index >= listSQL.Count)
                {
                    info.Text = "Такого индекса нет";
                    return;
                }

                listSQL.RemoveAt(index);

            }
            catch (FormatException exception )
            {
                info.Text = "Неверный формат поля";
            }
            viewList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBox7.Text);
                if (index < 0 || index >= listSQL.Count)
                {
                    info.Text = "Такого индекса нет";
                    return;
                }

                Student client = listSQL[index];
                textBox1.Text = client.getFIO();
                textBox2.Text = client.getCountOfCompletedWorks().ToString();
                textBox4.Text = client.getYearOfCompetition().ToString();
                textBox3.Text = client.getAttendance().ToString();

                if (client.getParticipation())
                {
                    textBox6.Text = "Да";
                }
                else
                {
                    textBox6.Text = "Нет";
                }
                
                
            }
            catch (FormatException exception )
            {
                info.Text = "Неверный формат поля";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listSQL.Clear();
            viewList();
            info.Text = "Список удален";
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            
            for (int f = listSQL.Count - 1; f >= 1; f--)
            {
                for (int s = 0; s < f; s++)
                {
                    if (listSQL[s].getCountOfCompletedWorks() > listSQL[s + 1].getCountOfCompletedWorks())
                    {
                        Student c = listSQL[s];
                        listSQL[s] = listSQL[s + 1];
                        listSQL[s + 1] = c;
                    }
                }
                
            }
            viewList();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            for (int f = listSQL.Count - 1; f >= 1; f--)
            {
                for (int s = 0; s < f; s++)
                {
                    if (listSQL[s].getAttendance() > listSQL[s + 1].getAttendance())
                    {
                        Student c = listSQL[s];
                        listSQL[s] = listSQL[s + 1];
                        listSQL[s + 1] = c;
                    }
                }

            }
            viewList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String p = "^.*" + textBox8.Text + ".*$";
            List<Student> copyList = new List<Student>();

            for (int i = 0; i < listSQL.Count; i++)
            {
                if (Regex.IsMatch(listSQL[i].getFIO(), p))
                {
                    copyList.Add(listSQL[i]);
                }
            }
            listView1.Items.Clear();
            info.Text = copyList.Count.ToString();
            foreach (Student valuePair in copyList)
            {
                ListViewItem item = new ListViewItem(valuePair.getFIO());
                item.SubItems.Add(valuePair.getCountOfCompletedWorks().ToString());
                item.SubItems.Add(valuePair.getYearOfCompetition().ToString());
                item.SubItems.Add(valuePair.getAttendance().ToString());
                item.SubItems.Add(valuePair.getParticipation().ToString());
                listView1.Items.Add(item);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            
            String FIO = textBox1.Text;
            if (!Regex.Match(FIO, "^[A-zА-я]+[ ]+[A-zА-я]+[ ]+[A-zА-я]+[ ]*$").Success)
            {
                info.Text = "ФИО некоректно";
                return;
            }
            
            String countOfWorks = textBox2.Text;
            int countOf = int.Parse(countOfWorks);
            
            if (countOf <= 0)
            {
                info.Text = "Количество работ не может быть отрицательным";
                return;
            }

            String yearOfCompetition = textBox4.Text;

            if (!Regex.Match(yearOfCompetition, "^[2][0][0-2][0-9][-][2][0][0-2][0-9]$").Success)
            {
                info.Text = "Недопустимые года";
                return;
            }
            
            
            String attendance = textBox3.Text;
            int attendanceInt = int.Parse(attendance);

            if (attendanceInt < 0)
            {
                info.Text = "Количество часов посещаемости не может быть отрицательным";
                return;
            }

            bool participationRes = false;
            String exam = textBox6.Text;
            if (exam.Equals("Да"))
            {
                participationRes = true;
            } 
            else if (exam.Equals("Нет"))
            {
                participationRes = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Участие в конкурсе|";
                return;
            }

            Student client = new Student(FIO, countOf, yearOfCompetition, attendanceInt, participationRes);
            

            if (listSQL.Contains(client))
            {
                listSQL[listSQL.IndexOf(client)] = client;
            }
            else
            {
                info.Text = "Данного участника нет в списке";
                return;
            }
            viewList();
            info.Text = "Изменено";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            viewList();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            String str = "";
            for (int i = 0; i < listSQL.Count; i++)
            {
                str = str + listSQL[i].ToString() + "\n";
            }
            File.WriteAllText("output.txt", str);
            info.Text = "Сохранено";
        }

        private void DownlaodFile_Click(object sender, EventArgs e)
        {
            listSQL.Clear();
            string s;
            StreamReader f = new StreamReader("output.txt");
            while ((s = f.ReadLine()) != null)
            {
                string[] words = s.Split(new char[] { ',' });         
                Student clientSchool = new Student(words[0], Int32.Parse(words[1]), words[2],
                    Int32.Parse(words[3]), Boolean.Parse(words[4]));               
                listSQL.Add(clientSchool);

            }
            f.Close();
            info.Text = "Загружено";
            viewList();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Console.Out.Write("ДЛЯ ГЕЯ");
        }
    }
}