using Healthcare.Domain.Enuns;

namespace Healthcare.Domain.Dtos
{
    public record AddressDto
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public EUF UF { get; set; }

        public static implicit operator Address(AddressDto dto)
            => new(dto.Street, dto.City, dto.ZipCode, dto.District, dto.UF);
    }
}
