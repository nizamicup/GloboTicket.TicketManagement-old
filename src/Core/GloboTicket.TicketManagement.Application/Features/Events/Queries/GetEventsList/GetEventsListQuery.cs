using System;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;

public class GetEventsListQuery : IRequest<List<EventListVm>>
{

}
