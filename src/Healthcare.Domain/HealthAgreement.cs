using System.Collections.Immutable;
using Healthcare.Domain.Patients;

namespace Healthcare.Domain
{
    public sealed class HealthAgreement : Audit
    {
        public string Name { get; private set; } = string.Empty;
        public string Cnpj { get; private set; } = string.Empty;
        
        private ICollection<Patient> _patinets;
        public IReadOnlyCollection<Patient> Patinets => _patinets.ToImmutableList();

        public override bool IsActive => DeletedIn.HasValue;

        public HealthAgreement(string name, string cnpj)        
        {
            ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
            ArgumentException.ThrowIfNullOrEmpty(cnpj, nameof(cnpj));

            Name = name;
            Cnpj = cnpj;    
            _patinets = new HashSet<Patient>();    
        }

        public void AddPatientToAgreement(Patient patient)
        {
            ArgumentNullException.ThrowIfNull(patient, nameof(patient));
            _patinets.Add(patient);
        }

        public void RemovePatientToAgreement(Patient patient)
        {
            ArgumentNullException.ThrowIfNull(patient, nameof(patient));
            _patinets.Remove(patient);
        }
    }
}