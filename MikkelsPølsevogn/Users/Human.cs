namespace MikkelsPølsevogn.Users
{
    public abstract class Human
    {
        public string Name { get; private set; }

        public Human(string name)
        {
            Name = name;
        }
    }
}