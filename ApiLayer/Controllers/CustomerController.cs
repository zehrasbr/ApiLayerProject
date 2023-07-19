using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController (ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _customerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.TInsert(customer);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var value = _customerService.TGetByID(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteCustomer(int id)
        {
            var value = _customerService.TGetByID(id);
            _customerService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.TUpdate(customer);
            return Ok();
        }
    }
}
