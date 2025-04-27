using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce_v2.Domain.Entity;
using ECommerce_v2.Domain.Interface.Repository;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public UpdateAddressCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var existingAddress = await _unitOfWork.Repository<Address>().FindAsync(request.AddressId, cancellationToken);
            if (existingAddress == null)
                throw new Exception($"Not found address {request.AddressId}");

            var updateAddress = _mapper.Map<UpdateAddressCommand, Address>(request);
            try
            {
                await _unitOfWork.BeginTransactionAsync(cancellationToken);
                _unitOfWork.Repository<Address>().Update(updateAddress);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw new Exception($"Failed to update address {request.AddressId}");
            }
        }
    }
}
