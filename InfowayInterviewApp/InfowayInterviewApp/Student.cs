namespace InfowayInterviewApp
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public int TotalMarks { get; set; }

        public string calculateResult(int TotalMarks)
            {
        {
            if (TotalMarks > 80)
                return string.Format($"Student {StudentName} has been selected for next Round of Interview !!!");
            }
            else
            {
                return string.Format($"Student {StudentName} has been rejected for next Round of Interview !!!");
            }

        }
    }
}
