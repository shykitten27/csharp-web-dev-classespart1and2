namespace SchoolPractice
{
    public class StudentBase
    {

        public override boolean Equals(object toBeCompared)
        {

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }
    }
}