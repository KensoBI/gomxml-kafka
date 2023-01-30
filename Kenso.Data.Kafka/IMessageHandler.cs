using Confluent.Kafka;

namespace Kenso.Data.Kafka
{
    public interface IMessageHandler<TK, TV>
    {
        Task Handle(Message<TK, TV> cr);
    }
}
