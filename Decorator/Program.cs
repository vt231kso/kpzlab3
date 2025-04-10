namespace Decorator
{
  internal class Program
  {
    static void Main()
    {
      
      IHero warrior = new Warrior("Thor");
      IHero mage = new Mage("Gandalf");
      IHero paladin = new Paladin("Arthur");

      
      warrior = new Sword(warrior);
      warrior = new Armor(warrior);

      mage = new Artifact(mage);
      mage = new Armor(mage);

      paladin = new Sword(paladin);
      paladin = new Artifact(paladin);
      paladin = new Armor(paladin);

      
      Console.WriteLine($"{warrior.GetDescription()} - Power: {warrior.GetPower()}");
      Console.WriteLine($"{mage.GetDescription()} - Power: {mage.GetPower()}");
      Console.WriteLine($"{paladin.GetDescription()} - Power: {paladin.GetPower()}");
    }
  }
}
