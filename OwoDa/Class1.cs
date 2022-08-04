namespace OwoDa
{
    public class Class1
    {
        public int Amount(int carTypefare, int numberOfTrips)
        {
            int totalAmount = carTypefare * numberOfTrips;
            return totalAmount;
        }


        public double discount(int totalAmount)
        {
            double Final_discount = totalAmount * 0.7;
            return Final_discount;
        }



    }

}

