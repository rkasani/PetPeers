namespace PetPeers.Domain.DTO
{
    public class PetDTO
    {
        public long? PetId { get; set; }

        public string PetName { get; set; }

        public string Place { get; set; }

        public int? Age { get; set; }

        public bool IsSold { get; set; }

    }
}
