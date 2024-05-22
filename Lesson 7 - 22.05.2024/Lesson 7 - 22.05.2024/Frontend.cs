namespace Lesson_7___22._05._2024
{
    public class Frontend : Developer
    {
        private sbyte _reactExperienceYear;
        public sbyte ReactExperienceYear 
        {
            get 
            { 
                return _reactExperienceYear; 
            }
            set
            {
                if (value >= 0 && Age > value)
                    _reactExperienceYear = value;
            }
        }
    }
}
