namespace OBP200_RolePlayingGame;

public class Rouge : ICharacterStats
{
    public string ClassType => "Rouge";
            
    public int HealthPoints => 32;

    public int AttackPower => 8;
            
    public int DefenseStat => 3;
            
    public int MaxHealth => 32;
            
    public int PotionAmount => 3;
            
    public int GoldAmount => 20;
    
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