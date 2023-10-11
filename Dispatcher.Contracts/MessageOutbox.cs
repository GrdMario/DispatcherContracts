namespace Dispatcher.Contracts
{
    using System;

    public class MessageOutbox
    {
        public int Id { get; set; }

        public Guid? ConversationId { get; set; }

        public Guid? CorrelationId { get; set; }

        public Guid MessageId { get; set; }

        public string PayloadType { get; set; } = default!;

        public short PayloadVersion { get; set; }

        public string Payload { get; set; } = default!;

        public string Destination { get; set; } = default!;

        public int Status { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? ProcessedAt { get; set; }
    }
}