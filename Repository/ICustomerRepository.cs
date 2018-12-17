using System.Collections.Generic;
using ElectricityBilling.Models;

namespace ElectricityBilling.Repository{
    public interface ICustomerRepository{
        void Create(Customer customer);
        void Edit(Customer customer);
        Customer GetSingleCustomer(int id);
        void Delete (Customer customer);
        List<Customer> GetAllCustomers();

    }
}