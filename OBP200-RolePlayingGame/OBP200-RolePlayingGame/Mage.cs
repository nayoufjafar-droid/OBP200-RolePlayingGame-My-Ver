namespace OBP200_RolePlayingGame;

public class Mage : ICharacterStats
{
    public string ClassType => "Mage";
            
    public int HealthPoints => 28;

    public int AttackPower => 10;
            
    public int DefenseStat => 2;
            
    public int MaxHealth => 28;
            
    public int PotionAmount => 2;
            
    public int GoldAmount => 15;
    
    public  int ExpAmount => 0;

    public int PlayerLvl => 0;

    public string PlayerInv => "Wooden Sword;Cloth Armor";

    public void GetStats()
    {
        Console.WriteLine(ClassType);
        Console.WriteLine(HealthPoints);
        Console.WriteLine(AttackPower);
        Console.WriteLine(DefenseStat);
        Console.WriteLine(MaxHealth);
        Console.WriteLine(PotionAmount);
        Console.WriteLine(GoldAmount);
        Console.WriteLine(ExpAmount);
        Console.WriteLine(PlayerLvl);
        Console.WriteLine(PlayerInv);
    }
}