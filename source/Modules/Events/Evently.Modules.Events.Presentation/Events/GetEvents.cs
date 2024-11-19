using Evently.Common.Domain;
using Evently.Common.Presentation.ApiResults;
using Evently.Common.Presentation.Endpoints;
using Evently.Modules.Events.Application.Events.GetEvents;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Events;

internal class GetEvents : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("events", async (ISender sender) =>
            {
                Result<IReadOnlyCollection<EventResponse>> result = await sender.Send(new GetEventsQuery());

                return result.Match(Results.Ok, Common.Presentation.ApiResults.ApiResults.Problem);
            })
            .WithTags(Tags.Events);
    }
}
