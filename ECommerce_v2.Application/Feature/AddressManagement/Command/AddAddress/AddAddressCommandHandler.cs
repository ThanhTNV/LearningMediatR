using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce_v2.Domain.Entity;
using ECommerce_v2.Domain.Interface.Repository;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.AddAddress
{
    public class AddAddressCommandHandler: IRequestHandler<AddAddressCommand, int>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public AddAddressCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(AddAddressCommand request, CancellationToken cancellationToken)
        {
            var address = _mapper.Map<AddAddressCommand, Address>(request);
            try
            {
                await _unitOfWork.BeginTransactionAsync(cancellationToken);
                await _unitOfWork.Repository<Address>().AddAsync(address, cancellationToken);
                int changeCounter = await _unitOfWork.SaveChangesAsync(cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);
                return changeCounter;
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw new Exception("Failed to add address!");
            }
        }
    }
}
