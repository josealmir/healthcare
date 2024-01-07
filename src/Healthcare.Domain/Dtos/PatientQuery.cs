using Healthcare.Domain.Enuns;

namespace Healthcare.Domain.Dtos
{
    public sealed class PatientQuery
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public EGender Gender { get; set; }
        public DateTimeOffset? UpdatedIn { get; set; }
    }
}