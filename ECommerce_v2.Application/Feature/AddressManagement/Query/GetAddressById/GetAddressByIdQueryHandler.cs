using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce_v2.Application.Common.Dto.AddressManagement;
using ECommerce_v2.Domain.Entity;
using ECommerce_v2.Domain.Interface.Repository;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Query.GetAddressById
{
    public class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQuery, AddressDto>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public GetAddressByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<AddressDto> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var address = await _unitOfWork.Repository<Address>().FindAsync(request.AddressId, cancellationToken);
            if (address == null)
                throw new Exception($"Not found address {request.AddressId}");
            var addressDto = _mapper.Map<Address, AddressDto>(address);
            return addressDto;
        }
    }
}
