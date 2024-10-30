namespace Bupa.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string PrimaryColour { get; set; }
        public DateOnly motTestExpiryDate { get; set; }
        public int LastMileage { get; set; }

        public Car(string make, string model, string colour, DateOnly date, int lastMileage) 
        {
            this.Make = make;
            this.Model = model;
            this.PrimaryColour = colour;
            this.motTestExpiryDate = date;
            this.LastMileage = lastMileage;
        }
    }
}
