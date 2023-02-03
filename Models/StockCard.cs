using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CollectionView.Models
{
    public class StockCard
    {

        public StockCard(bool u_Animate = false)
        {
            this.Name = RandomString(10);
            this.Price = RandomPrice(5);
            this.Animate = u_Animate;
        }

        public string Name { get; set; }

        public string Price { get; set; }

        public bool Animate { get; set; }

        private Random random = new Random();

        public string RandomString(int length)
        {
            try
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string RandomPrice(int length)
        {
            try
            {
                const string chars = "123456789";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
