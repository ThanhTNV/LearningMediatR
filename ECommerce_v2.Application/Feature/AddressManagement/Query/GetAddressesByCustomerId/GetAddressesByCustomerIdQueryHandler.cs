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

namespace ECommerce_v2.Application.Feature.AddressManagement.Query.GetAddressesByCustomerId
{
    public class GetAddressesByCustomerIdQueryHandler : IRequestHandler<GetAddressesByCustomerIdQuery, IEnumerable<AddressDto>>
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public GetAddressesByCustomerIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AddressDto>> Handle(GetAddressesByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.Repository<Customer>().FindAsync(request.CustomerId, cancellationToken);
            if (customer == null)
                throw new Exception($"Not found customer {request.CustomerId}");
            var addresses = _unitOfWork.Repository<Address>().Where(addr => addr.CustomerId == request.CustomerId).ToList();

            var addressDtos = _mapper.Map<IEnumerable<Address>, IEnumerable<AddressDto>>(addresses);
            return addressDtos;
        }
    }
}
