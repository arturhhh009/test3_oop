namespace Lab3_App
{
    public class PlaneClass : IEquatable<PlaneClass>
    {
        private int maxSpeed;
        private int passengerCapacity;

        // Властивості класу
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int PassengerCapacity
        {
            get => passengerCapacity;
            set
            {
                if (value < 0)
                {
                    passengerCapacity = 0;
                }
                else passengerCapacity = value;
            }
        }
        public int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value < 0)
                {
                    maxSpeed = 0;
                    IsReadyToFly = false;
                }
                else maxSpeed = value;
            }
        }
        public bool IsReadyToFly { get; set; }

        // Контруктор
        public PlaneClass(string model, string manufacturer, int capacity, int speed, bool isReadyToFly = true)
        {
            IsReadyToFly = isReadyToFly;
            Model = model;
            Manufacturer = manufacturer;
            PassengerCapacity = capacity;
            MaxSpeed = speed;
        }

        // Метод для знаходження ідентичного об'єкта
        public bool Equals(PlaneClass? other)
        {
            if (other == null) return false;

            return Model == other.Model &&
                    Manufacturer == other.Manufacturer &&
                    PassengerCapacity == other.PassengerCapacity &&
                    MaxSpeed == other.MaxSpeed &&
                    IsReadyToFly == other.IsReadyToFly;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Manufacturer, PassengerCapacity, MaxSpeed);
        }

        // Те, що буде виводитися, коли об'єкт перетворюватиметься в рядок
        public override string ToString()
        {
            return $"Модель: {Model} \n" +
                $"Виробник: {Manufacturer} \n" +
                $"Дозволена кількість пасажирів: {PassengerCapacity} \n" +
                $"Максимальна швидкість: {MaxSpeed} \n" +
                $"Готовність до польоту: {IsReadyToFly}";
        }
    }
}
