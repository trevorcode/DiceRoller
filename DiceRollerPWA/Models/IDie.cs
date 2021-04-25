namespace DiceRollerPWA.Models
{
    public interface IDie
    {
        string Name { get; set; }
        int Sides { get; set; }
        int? Result { get; set; }

        int RollDie();
    }
}