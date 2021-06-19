namespace APPracticalExam
{
    class People
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string gender;
            if (Gender)
                gender = "Male";
            else
                gender = "Female";
            return $"Name = {Name}, Gender = {gender}, Age = {Age}";
        }
    }
}
