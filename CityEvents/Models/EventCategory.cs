namespace CityEvents.Models
{
    public class EventCategory
    {
        public readonly bool[] Categories = { false, false, false, false, false, false, false, false, false };

        public bool Kid
        {
            get => Categories[0];
            set => Categories[0] = value;
        }

        public bool Sport
        {
            get => Categories[1];
            set => Categories[1] = value;
        }

        public bool Culture
        {
            get => Categories[2];
            set => Categories[2] = value;
        }

        public bool Excursions
        {
            get => Categories[3];
            set => Categories[3] = value;
        }

        public bool Lifestyle
        {
            get => Categories[4];
            set => Categories[4] = value;
        }

        public bool Party
        {
            get => Categories[5];
            set => Categories[5] = value;
        }

        public bool Education
        {
            get => Categories[6];
            set => Categories[6] = value;
        }

        public bool Online
        {
            get => Categories[7];
            set => Categories[7] = value;
        }

        public bool Show
        {
            get => Categories[8];
            set => Categories[8] = value;
        }

    }
}