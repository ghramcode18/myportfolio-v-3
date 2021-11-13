namespace Core1.Entities
{
    public class Owner : EntityBase
    {
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public string  FullName { get; set; }
        public Address Address { get; set; }

    }
}
