using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Lecture event
            LectureEvent lecture = new LectureEvent("The Future of Technology", "Join us for a discussion on the future of technology with industry experts.", new DateTime(2022, 1, 15, 10, 0, 0), new Address("123 Main St", "New York", "NY", "10001"), "John Smith", 50);

            // Create a Reception event
            ReceptionEvent reception = new ReceptionEvent("Holiday Party", "Celebrate the holidays with us!", new DateTime(2021, 12, 10, 18, 0, 0), new Address("456 Elm St", "Los Angeles", "CA", "90001"), "rsvp@eventplanning.com");

            // Create an Outdoor event
            OutdoorEvent outdoor = new OutdoorEvent("Summer Festival", "Join us for a day of fun in the sun!", new DateTime(2022, 7, 4, 12, 0, 0), new Address("789 Oak St", "Miami", "FL", "33101"), "Sunny and hot");

            // Generate standard details for each event
            Console.WriteLine(lecture.GetStandardDetails());
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine(outdoor.GetStandardDetails());

            // Generate full details for each event
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine(outdoor.GetFullDetails());

            // Generate short description for each event
            Console.WriteLine(lecture.GetShortDescription());
            Console.WriteLine(reception.GetShortDescription());
            Console.WriteLine(outdoor.GetShortDescription());
        }
    }

    class Address
    {
        private string street;
        private string city;
        private string state;
        private string zip;

        public Address(string street, string city, string state, string zip)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public string GetAddress()
        {
            return $"{street}, {city}, {state} {zip}";
        }
    }

    class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private Address address;

        public Event(string title, string description, DateTime date, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.address = address;
        }

        public string GetStandardDetails()
        {
            return $"{title}\n{description}\n{date}\n{address.GetAddress()}";
        }

        public string GetFullDetails()
        {
            return $"{title}\n{description}\n{date}\n{address.GetAddress()}";
        }

        public string GetShortDescription()
        {
            return $"{GetType().Name}: {title} - {date.ToShortDateString()}";
        }
    }

    class LectureEvent : Event
    {
        private string speaker;
        private int capacity;

        public LectureEvent(string title, string description, DateTime date, Address address, string speaker, int capacity) : base(title, description, date, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        public new string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
        }
    }

    class ReceptionEvent : Event
    {
        private string rsvpEmail;

        public ReceptionEvent(string title, string description, DateTime date, Address address, string rsvpEmail) : base(title, description, date, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public new string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nRSVP Email: {rsvpEmail}";
        }
    }

    class OutdoorEvent : Event
    {
        private string weather;

        public OutdoorEvent(string title, string description, DateTime date, Address address, string weather) : base(title, description, date, address)
        {
            this.weather = weather;
        }

        public new string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nWeather: {weather}";
        }
    }
}
// Tafadzwa Chingore