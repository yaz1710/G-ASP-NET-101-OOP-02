using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment oop2
internal class Program
{
    static void Main(string[] args)
    {


        #region  Question 1
        // A - What is the difference between a class and a struct?

        //Class: Reference type, supports inheritance


        //Struct: Value type, doesn't support inheritance

        //B - Why are classes more suitable than structs for large applications?

        // Classes are better for large applications because they support inheritance, encapsulation, and polymorphism

        #endregion

        #region question2 

        //  a- Which class is the parent class?

        // Shipment
        //  b- Which class is the child class?

        //    ExpressShipment
        // c- What members are inherited by ExpressShipment?

        //  TrackingCode
        // d- Why is inheritance better than duplicating the same code?

        // It avoids code duplication and makes the code easier to maintain.




        #endregion



        #region part 02 question 1
        public struct DeliveryAddress
    {
        public string City { get; set; }
        public string Street { get; set; }

        public DeliveryAddress(string city, string street)
        {
            City = city;
            Street = street;
        }

        public override string ToString()
        {
            return Street + ", " + City;
        }
    }
    public class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }

        public Shipment()
        {
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
            {
                DeliveryFee = newFee;
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("Tracking Code: " + TrackingCode);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Delivery Fee: " + DeliveryFee);
            Console.WriteLine("Destination: " + Destination);
            Console.WriteLine("Estimated Cost: " + EstimatedCost);
        }
    }
    #endregion








}
}
}