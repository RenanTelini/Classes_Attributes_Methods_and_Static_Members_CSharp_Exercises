namespace Exercise05
{
    class Student
    {
        public string Name;
        public double Grade1;
        public double Grade2;
        public double Grade3;

        public double CalcGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public double CalcReprovedGrade()
        {
            double reproved = 60 - CalcGrade();
            return reproved;
        }
    }
}