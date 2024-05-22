namespace Lesson_7___22._05._2024
{
    public class Developer
    {
        private sbyte _age;
        private sbyte _experience;

        public string Name { get; set; }
        public string Surname { get; set; }
        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                    _age = value;
            }
        }
        public sbyte Experience 
        {
            get 
            {
                return _experience;
            }
            set
            {
                if (value >= 0)
                    _experience = value;
            } 
        }


    }
}
