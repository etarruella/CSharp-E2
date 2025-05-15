using System;
using VideoGame.Inventory;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Armor
        Armor armor = new Armor("Steel Armor", 0.3f);
        Console.WriteLine($"Armor: {armor.Name}, Damage Reduction: {armor.DmgReduction}");

        // Probar reducción de daño
        float originalDamage = 100f;
        float reducedDamage = armor.ReduceDMG(originalDamage);

        // Cambiar el valor de DmgReduction a uno inválido (debería ser ignorado)
        armor.DmgReduction = 1.5f;
        Console.WriteLine($"Damage Reduction after invalid set: {armor.DmgReduction}");

        // Cambiar el valor de DmgReduction a uno válido
        armor.DmgReduction = 0.5f;
        Console.WriteLine($"Damage Reduction after valid set: {armor.DmgReduction}");

        // Crear una instancia de HealingPotion
        HealingPotion potion = new HealingPotion(3, 2);
        Console.WriteLine($"Healing Potion: {potion.Name}, Max Uses: {potion.MaxUses}, Remaining Uses: {potion.RemainingUses}");

        // Usar la poción dos veces
        potion.Use();
        Console.WriteLine($"Remaining Uses: {potion.RemainingUses}");

        potion.Use();
        Console.WriteLine($"Remaining Uses: {potion.RemainingUses}");

        // Intentar usar la poción sin usos restantes
        potion.Use();
        Console.WriteLine($"Remaining Uses: {potion.RemainingUses}");
    }
}
