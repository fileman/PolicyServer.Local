using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace n4notech.AspNetCore.Http
{
    //
    // Summary:
    //     A function that can process an HTTP request.
    //
    // Parameters:
    //   context:
    //     The AuthenticationState for the request.
    //
    // Returns:
    //     A task that represents the completion of request processing.
    public delegate Task RequestDelegate(AuthenticationState context);
}
