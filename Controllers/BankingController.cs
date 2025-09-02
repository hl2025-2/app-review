using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BankingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private static List<Customer> _Customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe"},
            new Customer { Id = 2, Name = "Jane Smith"}
        };

        private static List<Agent> _Agents = new List<Agent>
        {
            new Agent { Id = 1, Name = "James Johnson"},
            new Agent { Id = 2, Name = "Emily Brown"}
        };

        private static List<Appointment> _appointments = new List<Appointment>
        {
            new Appointment { Id = 1, CustomerId = 1, AgentId = 1, Date = DateTime.Now.AddDays(7) },
            new Appointment { Id = 2, CustomerId = 2, AgentId = 2, Date = DateTime.Now.AddDays(14) }
        };

        [HttpPost("Customers")]
        public IActionResult AddCustomer([FromBody] Customer Customer)
        {
            _Customers.Add(Customer);
            return Ok(Customer);
        }

        [HttpGet("Customers")]
        public IActionResult GetCustomers()
        {
            return Ok(_Customers);
        }

        [HttpPost("Agents")]
        public IActionResult AddAgent([FromBody] Agent Agent)
        {
            _Agents.Add(Agent);
            return Ok(Agent);
        }

        [HttpGet("Agents")]
        public IActionResult GetAgents()
        {
            return Ok(_Agents);
        }

        [HttpPost("appointments")]
        public IActionResult AddAppointment([FromBody] Appointment appointment)
        {
            _appointments.Add(appointment);
            return Ok(appointment);
        }

        [HttpGet("appointments")]
        public IActionResult GetAppointments()
        {
            return Ok(_appointments);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        // Add other Customer properties as needed
    }

    public class Agent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        // Add other Agent properties as needed
    }

    public class Appointment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AgentId { get; set; }
        public DateTime Date { get; set; }
        // Add other appointment properties as needed
    }
}
