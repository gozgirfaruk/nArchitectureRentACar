using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommand : IRequest<CreateBrandResponse>
    {
        public string Name { get; set; }

        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreateBrandResponse>
        {
            public Task<CreateBrandResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                CreateBrandResponse response = new CreateBrandResponse();
                response.Name = request.Name;
                response.Id = new Guid();
                return null;
            }
        }
    }
}
