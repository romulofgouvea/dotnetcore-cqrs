using cqrs.Domain.Commands.Requests;
using cqrs.Domain.Commands.Response;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace cqrs.Domain.Handlers
{
    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommandRequest, CreateCandidateCommandResponse>
    {
        private readonly IMediator _mediator;

        public CreateCandidateCommandHandler(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public async Task<CreateCandidateCommandResponse> Handle(CreateCandidateCommandRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCandidateCommandResponse
            {
                Id = Guid.NewGuid()
            };

            return await Task.FromResult(result);
        }
    }
}