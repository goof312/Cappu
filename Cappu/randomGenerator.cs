using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cappu
{
    public class randomGenerator
    {
        public string GenerateRandomOrderId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] orderIdArray = Enumerable.Range(0, 7)
            .Select(_ => chars[random.Next(chars.Length)])
             .ToArray();

            // Fisher-Yates shuffle
            for (int i = orderIdArray.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = orderIdArray[i];
                orderIdArray[i] = orderIdArray[j];
                orderIdArray[j] = temp;
            }

            string randomOrderId = new string(orderIdArray);

            string combinedId = $"{randomOrderId}-{DateTime.UtcNow:MMddHHss}";

            return combinedId;
        }

    }
}