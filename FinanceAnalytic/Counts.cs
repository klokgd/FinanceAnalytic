using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public interface Counts //интерфейс для всех счетов
    {
        double Sum { get; set; }
        string Name { get; set; }
        void TransferBetweenCounts();
        


    }

}
