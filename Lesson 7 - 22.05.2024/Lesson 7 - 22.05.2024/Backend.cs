namespace Lesson_7___22._05._2024
{
    public class Backend : Developer
    {
        private sbyte _sqlExperienceYear;
        public sbyte SqlExperienceYear
        {
            get
            {
                return _sqlExperienceYear;
            }
            set
            {
                if (value >= 0 && Age > value)
                {
                    _sqlExperienceYear = value;
                }
            }
        }
    }
}
