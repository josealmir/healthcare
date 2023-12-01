using Healthcare.Domain.Enuns;

namespace Healthcare.Domain.Patients
{
    public sealed partial class Patient : Audit
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public EGender Gender { get; private set; } = EGender.M;
        public Address Address { get; private set; }
        public string Name => FirstName + LastName;
        public override bool IsActive => !DeletedIn.HasValue;

        private Patient()
        {}

        public Patient(string firstName, string lastName, EGender gender)
        {
            ArgumentException.ThrowIfNullOrEmpty(firstName, nameof(firstName));
            ArgumentException.ThrowIfNullOrEmpty(lastName, nameof(lastName));
            
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}