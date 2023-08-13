namespace Dependency_Injection
{
    public class GuidGenerator : IGuidGenerator
    {
        public Guid NewGuid { get; set; } = Guid.NewGuid();
        public GuidGenerator() { }
        public Guid RandomGuid()
        {
            return NewGuid;
        }
    }

    public interface IGuidGenerator
    {
        Guid RandomGuid();
    }
}
