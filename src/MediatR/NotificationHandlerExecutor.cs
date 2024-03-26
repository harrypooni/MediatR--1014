using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Contracts;

namespace MediatR;

public record NotificationHandlerExecutor(object HandlerInstance, Func<INotification, CancellationToken, Task> HandlerCallback);