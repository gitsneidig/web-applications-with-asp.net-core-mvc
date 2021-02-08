using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class IOrderRepository
    {
        void CreateOrder(Order order);
        void CreatePieGiftOrder(PieGiftOrder pieGiftOrder);
    }
}
