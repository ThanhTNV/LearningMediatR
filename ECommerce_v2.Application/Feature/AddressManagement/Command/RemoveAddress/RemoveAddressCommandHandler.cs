using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce_v2.Domain.Entity;
using ECommerce_v2.Domain.Interface.Repository;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.RemoveAddress
{
    public class RemoveAddressCommandHandler : IRequestHandler<RemoveAddressCommand, int>
    {
        private IUnitOfWork _unitOfWork;
        public RemoveAddressCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(RemoveAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _unitOfWork.Repository<Address>().FindAsync(request.AddressId, cancellationToken);
            if(address == null)
            {
                throw new Exception($"Address {request.AddressId} not found");
            }
            try
            {
                await _unitOfWork.BeginTransactionAsync(cancellationToken);
                await _unitOfWork.Repository<Address>().RemoveAsync(request.AddressId, cancellationToken);
                var changesCount = await _unitOfWork.SaveChangesAsync(cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);
                return changesCount;
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw new Exception($"Failed to remove address {request.AddressId}");
            }
        }
    }
}
