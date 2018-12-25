using ElectricityBilling.Data;
using ElectricityBilling.Models;
using ElectricityBilling.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityBilling.Controllers{
    public class CustomerController: Controller{
        private CustomerRepository _customerRepository;
        private ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
            _customerRepository = new CustomerRepository(_context);
        }
        public IActionResult Index(){
            var customers = _customerRepository.GetAllCustomers();
            return View(customers);
        }
        public IActionResult Details(int id){
            var customer = _customerRepository.GetSingleCustomer(id);
            return View(customer);
        }
        [HttpGet]
        public IActionResult New(){
            var customer = new Customer();
            return View(customer);
        }
        [HttpPost]
        public IActionResult New(Models.Customer customer){
            _customerRepository.Create(customer);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id){
            var customer = _customerRepository.GetSingleCustomer(id);
            _customerRepository.Delete(customer);
            return View();
        }

    }
}