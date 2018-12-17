using System.Collections.Generic;
using System.Linq;
using ElectricityBilling.Data;
using ElectricityBilling.Models;

namespace ElectricityBilling.Repository{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context){
            _context = context;
        }
        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void Edit(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetSingleCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(p=>p.customer_id == id);
            return customer;
        }
    }
}