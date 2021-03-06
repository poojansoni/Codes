using System;

namespace StudentGrade
{
    
    public class MarksCalculations
    {
        
        public double AvgMark(int s1, int s2,int s3,int s4, int s5) 
        {
            double avg = (s1 + s2 + s3 + s4 + s5) / 5;
            return avg; 
        }


        public string CalcGradeif(double Avg) 
        {
            string grade = null;
            if (Avg >= 90) { grade = "A+"; }
            else if (Avg >= 80 && Avg< 90) { grade = "A"; }
            else if (Avg >= 70 && Avg < 80) { grade = "B"; }
            else if (Avg >= 60 && Avg < 70) { grade = "c"; }
            else if (Avg < 60) { grade = "Fail"; }
            return grade;
        }    


        public string CalcGradeSwitch(double Avg)
        {
            string grade = null;
            switch (Avg>=90 ? "A+" : 
                    Avg>= 80 ? "A" :
                    Avg >=70 ? "B" :
                    Avg >=60 ? "C" : "Fail")
            {
                case "A+":
                    grade = "A+";
                    break;
                
                case "A":
                    grade = "A";
                    break;
               
                case "B":
                    grade = "B";
                    break;

                case "C":
                    grade = "C";
                    break;

                case "Fail":
                    grade = "Fail";
                    break;

            }

            return grade;
        }
    }
}
