﻿using MediatR;
using Moq;
using Northwind.Application.Commands.CreateCustomer;
using Northwind.Application.Tests.Infrastructure;
using System.Threading;
using Xunit;

namespace Northwind.Application.Tests.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandTests : CommandTestBase
    {
        [Fact]
        public void Handle_GivenValidRequest_ShouldRaiseCustomerCreatedNotification()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var sut = new CreateCustomerCommand.Handler(_context, mediatorMock.Object);
            var newCustomerId = "QAZQ1";

            // Act
            var result = sut.Handle(new CreateCustomerCommand { Id = newCustomerId }, CancellationToken.None);


            // Assert
            mediatorMock.Verify(m => m.Publish(It.Is<CustomerCreated>(cc => cc.CustomerId == newCustomerId), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
