using System;
using System.Reflection;
using System.Threading.Tasks;
using Actio.Shared.Commands;
using Actio.Shared.Events;
using RawRabbit;
using RawRabbit.Pipe;

namespace Actio.Shared.RabbitMq
{
    public static class Extensions{
        public static Task WithCommandHandlerAsync<TCommand>(this IBusClient bus, 
        ICommandHandler<TCommand> handler) where TCommand : ICommand
        {
            return bus.SubscribeAsync<TCommand>(
                msg => handler.HandleAsync(msg),
                ctx => ctx.UseSubscribeConfiguration(cfg => 
                    cfg.FromDeclaredQueue(q => q.WithName(GetQueueName<TCommand>()))
                    )
                );
        }

        public static Task WithEventHandlerAsync<TEvent>(this IBusClient bus, 
        IEventHandler<TEvent> handler) where TEvent : IEvent
        {
            if (handler == null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            return bus.SubscribeAsync<TEvent>(
                msg => handler.HandleAsync(msg),
                ctx => ctx.UseSubscribeConfiguration(cfg => 
                    cfg.FromDeclaredQueue(q => q.WithName(GetQueueName<TEvent>()))
                    )
                );
        }
        private static string GetQueueName<T>() => $"{Assembly.GetEntryAssembly().GetName()}/{typeof(T)}";

    }
}