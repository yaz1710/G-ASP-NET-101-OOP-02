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
       // public struct DeliveryAddress
    {
        //public string City { get; set; }
       // public string Street { get; set; }

       // public DeliveryAddress(string city, string street)
       // {
          //  City = city;
          //  Street = street;
        //}

       // public override string ToString()
      //  {
          //  return Street + ", " + City;
        //}
   // }
    //public class Shipment
   // {
        //public string TrackingCode { get; set; }
       // public string Description { get; set; }
        //public decimal Weight { get; set; }
       // public decimal DeliveryFee { get; set; }
       // public DeliveryAddress Destination { get; set; }

       // public Shipment()
       // {
       // }
//
       // public Shipment(
          //  string trackingCode,
           // string description,
           // decimal weight,
           // decimal deliveryFee,
           // DeliveryAddress destination)
       // {
           // TrackingCode = trackingCode;
           // Description = description;
           // Weight = weight;
           // DeliveryFee = deliveryFee;
           // Destination = destination;
       // }

        //public virtual decimal EstimatedCost
        //{
          //  get
            //{
                //return DeliveryFee + (Weight * 5);
          //  }
        //}

       // public void UpdateDeliveryFee(decimal newFee)
       // {
       //     if (newFee >= 0)
           // {
                ///DeliveryFee = newFee;
            //}
       // }

       // public virtual void PrintShipment()
       // {
           // Console.WriteLine("Tracking Code: " + TrackingCode);
            //Console.WriteLine("Description: " + Description);
            ///Console.WriteLine("Weight: " + Weight);
           // Console.WriteLine("Delivery Fee: " + DeliveryFee);
           // Console.WriteLine("Destination: " + Destination);
          //  Console.WriteLine("Estimated Cost: " + EstimatedCost);
       // }
   // }
    #endregion


    #region question 2 p2
   // public class StandardShipment : Shipment
    //{
       // public StandardShipment(
          //  string trackingCode,
          //  string description,
          //  decimal weight,
          //  decimal deliveryFee,
          //  DeliveryAddress destination)
          //  : base(trackingCode, description, weight, deliveryFee, destination)
        //{
       // }
   // }
   /// public class ExpressShipment : Shipment
   // {
   //     private decimal extraFee;

       // public decimal ExtraFee
       // {
          //  get
           // {
         //       return extraFee;
          //  }
           // set
          //  {
               // if (value >= 0)
               // {
                    extraFee = value;
               // }
           // }
       // }

        //public ExpressShipment(
          //  string trackingCode,
          //  string description,
           // decimal weight,
           // decimal deliveryFee,
           // DeliveryAddress destination,
           // decimal extraFee)
           // : base(trackingCode, description, weight, deliveryFee, destination)
        //{
           // ExtraFee = extraFee;
        //}

       // public override decimal EstimatedCost
       // {
          //  get
          //  {
                //return DeliveryFee + (Weight * 5) + ExtraFee;
          //  }
        //}
    //}
    //public class InternationalShipment : Shipment
   // {
     //   private string destinationCountry;
      //  private decimal customsFee;

      //  public string DestinationCountry
      //  {
        //    get
         //   {
             //   return destinationCountry;
          //  }
          //  set
           // {
               // if (!string.IsNullOrWhiteSpace(value))
                //{
                    destinationCountry = value;
               // }
            //}
        //}

       // public decimal CustomsFee
       // {
          //  get
           // {
              //  return customsFee;
           // }
            //set
           // {
           //     if (value >= 0)
               // {
                    customsFee = value;
            // }
            // }
            // }

            // public InternationalShipment(
            // string trackingCode,
            // string description,
            // decimal weight,
            // decimal deliveryFee,
            //  DeliveryAddress destination,
            // string destinationCountry,
            // decimal customsFee)
            // : base(trackingCode, description, weight, deliveryFee, destination)
            ///{
            //  DestinationCountry = destinationCountry;
            //  CustomsFee = customsFee;
            //}

            // public override decimal EstimatedCost
            // {
            // get
            // {
            // return DeliveryFee + (Weight * 5) + CustomsFee;
            // }
            // }
            //}
            #endregion

            #region question 3 p2
            public class DeliveryCenter
    {
        public string CenterName { get; set; }

        private Shipment[] shipments;

        private int count;

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
            count = 0;
        }

        public void AddShipment(Shipment shipment)
        {
            if (count < 20)
            {
                shipments[count] = shipment;
                count++;
            }
            else
            {
                Console.WriteLine("Delivery Center is full.");
            }
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return shipments[index];
                }

                return null;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[count - 1] = null;
                    count--;

                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("\n===== All Shipments =====");

            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
                Console.WriteLine("-------------------------");
            }
        }
    }
            #endregion


}
    }
}