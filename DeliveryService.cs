using ExceptionProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();
        public void start(Deleviry deleviry)
        {
            try
            {
                process(deleviry);
                ship(deleviry);
                InTransit(deleviry);
                deliver(deleviry);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Contact us...");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Yahia's delivery service !!");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        private void process(Deleviry delivery)
        {
            loading("Processing", 200);

            if(random.Next(1, 10) % 2 == 0)
            {
                throw new InvalidOperationException ("Processing failed : Try again!");
            }

            delivery.Status = DeleviryStatus.PROCESSING;
        }

        private void ship(Deleviry delivery)
        {
            loading("Shipping", 200);

            if (random.Next(1, 10) % 2 == 0)
            {
                throw new InvalidOperationException("Shipping failed : Parcel drobbed");
            }

            delivery.Status = DeleviryStatus.SHIPPED;
        }
        
        private void InTransit(Deleviry delivery)
        {
            loading("InTransit", 300);

            if(random.Next(1, 10) % 2 == 0)
            {
                throw new InvalidOperationException("InTransit failed : An accedent");
            }

            delivery.Status = DeleviryStatus.IN_TRANSIT;
        }

        private void deliver(Deleviry delivery)
        {
            loading("Out for delivery..", 300);

            if(random.Next(1, 10) % 2 == 0)
            {
                throw new InvalidOperationException("Delivery failed : Customer not found");
            }

            delivery.Status = DeleviryStatus.Delivered;
        }

       

       private void loading(string title, int millisecondsTimeout)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write(".");           
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write(".");           
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write("."); 
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write(".");
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write(".");
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write(".");
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write(".");
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.Write(".");
            System.Threading.Thread.Sleep(millisecondsTimeout);
            Console.WriteLine(".");
        }
    }
}
