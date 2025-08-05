using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsole2
{
    
        internal class SalesReportManager
        {
            private List<Order> orders;

            public SalesReportManager(List<Order> orderList)
            {
                orders = orderList;
            }


       
        public List<Order> GetPendingOrders()
        {
            return orders.Where(o => o.OrderState == "Pending").ToList();
        }

        public List<Order> GetRejectedOrders()
        {
            return orders.Where(o => o.OrderState != null && o.OrderState.StartsWith("Rejected")).ToList();
        }

        public List<Order> GetProcessedOrders()
        {
            return orders.Where(o => o.OrderState == "Processed" || o.OrderState == "Processed with Discount").ToList();
        }
    }
    }

