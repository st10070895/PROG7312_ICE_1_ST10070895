namespace PROG7312_ICE_1_ST10070895
{
    public class Student
    {
        private int studentID, mark;
        private string firstName, surname, subject;

        public Student(int studentID, string firstName, string Surname, string subject, int mark)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.surname = Surname;
            this.subject = subject;
            this.mark = mark;
        }
        public object this[int index]
        {
            get
            {
                return index switch
                {
                    0 => this.studentID,
                    1 => this.firstName,
                    2 => this.surname,
                    3 => this.subject,
                    4 => this.mark,
                    _ => null,
                };
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.studentID = (int)value;
                        break;
                    case 1:
                        this.firstName = (string)value;
                        break;
                    case 2:
                        this.surname = (string)value;
                        break;
                    case 3:
                        this.subject = (string)value;
                        break;
                    case 4:
                        this.mark = (int)value;
                        break;
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                return attrName.ToLower() switch
                {
                    "studentid" => this.studentID,
                    "firstname" => this.firstName,
                    "lastname" => this.surname,
                    "subject" => this.subject,
                    "mark" => this.mark,
                    _ => null,
                };
            }
            set
            {
                switch (attrName.ToLower())
                {
                    case "studentid":
                        this.studentID = (int)value;
                        break;
                    case "firstname":
                        this.firstName = (string)value;
                        break;
                    case "lastname":
                        this.surname = (string)value;
                        break;
                    case "subject":
                        this.subject = (string)value;
                        break;
                    case "mark":
                        this.mark = (int)value;
                        break;
                }
            }
        }
    }
}