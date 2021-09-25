namespace Zork
{
    class Room
    {
        public string Name { get; }

        public string Description { get; set; }
        public Room(string name, string description = "")
            //This is a constructor initializes name and description so that it can never be changed
        {
            Name = name;
            Description = description;
        }
        public override string ToString() => Name;
    }
}
