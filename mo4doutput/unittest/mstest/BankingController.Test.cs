// ===== BEGIN GENERATED CODE BY ATOS POLARIS AI FOR DEVELOPMENT ON 2025-09-10 16:17:32 ========
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;


using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BankingApi.Controllers;

namespace BankingSystem.Tests
{
    public partial class BankingControllerTests
    {
        //private BankingController _controller;
        [TestInitialize]
        public void Setup(BankingController _controller)
        {
            _controller = new BankingController();
        }

        [TestMethod]
        public void AddCustomer_ShouldReturnOk_WhenCustomerIsValid()
        {
            // Arrange
            var newCustomer = new Customer
            {
                Id = 3,
                Name = "Alice Cooper"
            };
            // Act
            var result = _controller.AddCustomer(newCustomer) as OkObjectResult;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(newCustomer, result.Value);
        }

        [TestMethod]
        public void AddCustomer_ShouldThrowException_WhenCustomerIsNull()
        {
            // Arrange
            Customer nullCustomer = null;
            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => _controller.AddCustomer(nullCustomer));
        }

        [TestMethod]
        public void GetCustomers_ShouldReturnAllCustomers()
        {
            // Act
            var result = _controller.GetCustomers() as OkObjectResult;
            var customers = result.Value as List<Customer>;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, customers.Count);
        }

        private BankingController _controller;
        private Mock<List<Agent>> _mockAgents;
        private Mock<List<Appointment>> _mockAppointments;
        [TestInitialize]
        public void Setup()
        {
            _mockAgents = new Mock<List<Agent>>();
            _mockAppointments = new Mock<List<Appointment>>();
            //_controller = new BankingController(_mockAgents.Object, _mockAppointments.Object);
        }

        [TestMethod]
        public void AddAgent_ShouldReturnOk_WhenAgentIsAdded()
        {
            // Arrange
            var agent = new Agent
            {
                Id = 1,
                Name = "John Doe"
            };
            // Act
            var result = _controller.AddAgent(agent) as OkObjectResult;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(agent, result.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddAgent_ShouldThrowException_WhenAgentIsNull()
        {
            // Act
            var result = _controller.AddAgent(null);
        }

        [TestMethod]
        public void GetAgents_ShouldReturnOk_WhenAgentsExist()
        {
            // Arrange
            var agentsList = new List<Agent>
            {
                new Agent
                {
                    Id = 1,
                    Name = "John Doe"
                },
                new Agent
                {
                    Id = 2,
                    Name = "Jane Doe"
                }
            };
            _mockAgents.Setup(a => a).Returns(agentsList);
            // Act
            var result = _controller.GetAgents() as OkObjectResult;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(agentsList, result.Value);
        }

        [TestMethod]
        public void GetAgents_ShouldReturnOk_WhenNoAgentsExist()
        {
            // Arrange
            _mockAgents.Setup(a => a).Returns(new List<Agent>());
            // Act
            var result = _controller.GetAgents() as OkObjectResult;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, ((List<Agent>)result.Value).Count);
        }
    }
}
// ===== END GENERATED CODE BY ATOS POLARIS AI FOR DEVELOPMENT =====
