using System;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events;

public class GetEventDetailQuery : IRequest<EventDetailVm>
{
    public Guid Id { get; set; }
}