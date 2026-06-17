using MediCore.App.Core.Models;
//using MediCore.Core.Models;
using System.Collections.Generic;

namespace MediCore.App.Core.Contracts
{
    public interface IBillingService
    {
        List<Bill> GetAllBills();

        Bill GetBillById(int id);

        void AddBill(Bill bill);

        void UpdateBill(Bill bill);

        void DeleteBill(int id);
    }
}
