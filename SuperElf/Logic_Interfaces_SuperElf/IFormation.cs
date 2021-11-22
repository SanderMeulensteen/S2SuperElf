namespace Logic_Interfaces_SuperElf
{
    public interface IFormation
    {
        int formationId { get; }
        string formationName { get; }
        void UpdateFormation(int formationId, string newFormationName);
    }
}