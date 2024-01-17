namespace CharacterCreation
{
    internal abstract class Database
    {
        public abstract void Insert(Character c);
        public abstract void Display(Character c);
        public abstract void Display();
        public abstract void Delete();
    }
}