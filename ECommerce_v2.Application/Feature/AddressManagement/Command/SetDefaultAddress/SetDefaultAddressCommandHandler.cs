using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Entity;
using ECommerce_v2.Domain.Interface.Repository;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.SetDefaultAddress
{
    public class SetDefaultAddressCommandHandler : IRequestHandler<SetDefaultAddressCommand>
    {
        private IUnitOfWork _unitOfWork;
        public SetDefaultAddressCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(SetDefaultAddressCommand request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.Repository<Customer>().FindAsync(request.CustomerId, cancellationToken);
            if (customer == null)
                throw new Exception($"Not found customer {request.CustomerId}");
            var address = await _unitOfWork.Repository<Address>().FindAsync(request.AddressId, cancellationToken);
            if (customer == null)
                throw new Exception($"Not found address {request.AddressId}");
            try
            {
                await _unitOfWork.BeginTransactionAsync(cancellationToken);
                address.IsDefault = true;
                _unitOfWork.Repository<Address>().Update(address);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw new Exception($"Failed to set defaut address {request.AddressId} to customer {request.CustomerId}");
            }
        }
    }
}
