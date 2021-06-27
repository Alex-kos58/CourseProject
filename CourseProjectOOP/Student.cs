using System;

namespace CourseProjectOOP
{
    public class Student
    {
        private String FIO;
        private int countOfCompletedWorks;
        private String yearOfCompetition;
        private int attendance;
        private bool participation;

        public Student(string fio, int countOfCompletedWorks, String yearOfCompetition, int attendance, bool participation)
        {
            FIO = fio;
            this.countOfCompletedWorks = countOfCompletedWorks;
            this.yearOfCompetition = yearOfCompetition;
            this.attendance = attendance;
            this.participation = participation;   
        }

        public String getFIO()
        {
            return FIO; 
        }
        
        public int getCountOfCompletedWorks()
        {
            return countOfCompletedWorks; 
        }
        
        public String getYearOfCompetition()
        {
            return yearOfCompetition; 
        }
        
        public int getAttendance()
        {
            return attendance; 
        }

        public bool getParticipation()
        {
            return participation;
        }
        
        public void setFIO(String fio)
        {
            this.FIO = fio;
        }
        
        public void setCountOfCompletedWorks(int c)
        {
            this.countOfCompletedWorks = c;
        }
        
        public void setYearOfCompetition(String h)
        {
            this.yearOfCompetition = h;
        }
        
        public void setAttendance(int f)
        {
            this.attendance = f;
        }

        public void setParticipation(bool r)
        {
            this.participation = r;
        }

        public override bool Equals(object c)
        {
            Student obj = (Student) c;
            return this.FIO.Equals(obj.getFIO());
        }

        public override string ToString()
        {
            return FIO + "," + countOfCompletedWorks + "," + yearOfCompetition  + "," + attendance  + "," +  participation;
        }
    }
}