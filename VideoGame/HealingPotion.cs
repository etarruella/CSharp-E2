namespace VideoGame.Inventory;

public class HealingPotion : Item
{
    private readonly int maxUses;
    private int remainingUses;

    public int MaxUses
    {
        get { return maxUses; }
    }

    public int RemainingUses
    {
        get { return remainingUses; }
        set
        {
            if (value > maxUses)
            {
                return;
            }
            remainingUses = value;
        }
    }

    public HealingPotion(int maxUses, int remainingUses) : base("Healing Potion")
    {
        this.maxUses = maxUses;
        if (remainingUses > maxUses)
        {
            this.remainingUses = maxUses;
            return;
        }
        this.remainingUses = remainingUses;
    }

    public void Use()
    {
        if (remainingUses <= 0)
        {
            Console.WriteLine("Not remaining uses...");
            return;
        }

        remainingUses--;
        Console.WriteLine("Healing...");
    }
}