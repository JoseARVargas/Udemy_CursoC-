using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9_Exercicio03_Enum_Composicoes.Entities.Enums
{
    enum OrderStatus : int
    {
        endingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
