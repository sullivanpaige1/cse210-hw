using System;

namespace EventProgram
{
    class Address
    {
        private string Street, City, State, Country;

        public Address(string street, string city, string state, string country)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Street}\n{City}, {State}\n{Country}";
        }
    }

    class Event
    {
        protected string Title, Description, Date, Time;
        protected Address Address;

        public Event(string title, string description, string date, string time, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"{Title}\n{Description}\n{Date} {Time}\n{Address}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDescription()
        {
            return $"{Title} - {Date}";
        }
    }

    class Lecture : Event
    {
        private string Speaker;
        private int Capacity;

        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }

        public override string GetShortDescription()
        {
            return $"Lecture: {Title} - {Date}";
        }
    }

    class Reception : Event
    {
        private string Email;

        public Reception(string title, string description, string date, string time, Address address, string email)
            : base(title, description, date, time, address)
        {
            Email = email;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Reception\nRSVP: {Email}";
        }

        public override string GetShortDescription()
        {
            return $"Reception: {Title} - {Date}";
        }
    }

    class OutdoorGathering : Event
    {
        private string Weather;

        public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
            : base(title, description, date, time, address)
        {
            Weather = weather;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
        }

        public override string GetShortDescription()
        {
            return $"Outdoor: {Title} - {Date}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address addr = new Address("123 Center St", "Rexburg", "ID", "USA");

            Event lecture = new Lecture("AI Talk", "Learn about AI", "April 10", "6:00 PM", addr, "Dr. Smith", 100);
            Event reception = new Reception("Networking Night", "Meet professionals", "April 12", "7:00 PM", addr, "rsvp@email.com");
            Event outdoor = new OutdoorGathering("Picnic", "Fun outside", "April 15", "12:00 PM", addr, "Sunny");

            List<Event> events = new List<Event> { lecture, reception, outdoor };

            foreach (var e in events)
            {
                Console.WriteLine("STANDARD DETAILS:");
                Console.WriteLine(e.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("FULL DETAILS:");
                Console.WriteLine(e.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("SHORT DESCRIPTION:");
                Console.WriteLine(e.GetShortDescription());
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}