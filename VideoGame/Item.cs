namespace VideoGame.Inventory
{
    public class Item
    {
        protected readonly string name;

        public string Name
        {
            get { return name; }
        }

        public Item(string name)
        {
            this.name = name;
        }
    }
}