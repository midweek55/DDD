using Cenit.Admon.Application.Customers.Commands;
using Cenit.Admon.Domain.Services.Interfaces;
using MediatR;

namespace Cenit.Admon.Application.Customers.Handlers
{

    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        #region fields 
        private readonly ICustomerService _customerService;
        #endregion
        public CreateCustomerCommandHandler(ICustomerService customer)
        {
            _customerService = customer;
        }

        public async Task<bool> Handle(CreateCustomerCommand command, CancellationToken cancellation)
        {
            _customerService.Save();
            return false;
        }
    }
}
