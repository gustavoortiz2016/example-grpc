using grpc_service;
using Grpc.Core;

namespace grpc_service.Services;

public class HealthService : Health.HealthBase
{
  private readonly ILogger<HealthService> _logger;
  public HealthService(ILogger<HealthService> logger)
  {
    _logger = logger;
  }

  public override Task<CheckReply> Check(CheckRequest request, ServerCallContext context)
  {
    return Task.FromResult(new CheckReply
    {
      IsSuccess = true,
      Message = "Servicio en linea",
      Code = "",
      TransactionId = "",
      Result = ""
    });
  }
}
