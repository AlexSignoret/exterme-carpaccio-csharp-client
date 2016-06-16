namespace xCarpaccio.client
{
    public class BillCalculator
    {
        public Bill CalculerTotal(Order order)
        {
            if (order.Country != "DE")
            {
                return null;
            }
            var total = 0m;
            for (int i = 0; i < order.Quantities.Length; i++)
            {
                total += order.;
            }
            total = 1 * 1.2m;
            if (total >= 1000)
            {
                total = total - (total/100)*3;
            }
            if (total >= 1000)
            {
                total = total - (total / 100) * 5;
            }
            if (total >= 1000)
            {
                total = total - (total / 100) * 7;
            }
            if (total >= 1000)
            {
                total = total - (total / 100) * 10;
            }
            if (total >= 1000)
            {
                total = total - (total / 100) * 15;
            }

        }
    }
}