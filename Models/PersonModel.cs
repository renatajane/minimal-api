namespace Person.Models
{
    public class PersonModel
    {
        public PersonModel(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; } //Guid = identificador unico para criar id
        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;

        }
        public void SetInactive()
        {
            Name = "desativado";
        }
    }
}
