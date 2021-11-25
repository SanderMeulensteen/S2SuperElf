namespace Logic_Interfaces_SuperElf
{
    public interface IFormation
    {
        int formationId { get; }
        string formationName { get; }
        void UpdateFormation(IFormation formationId, string newFormationName);
    }
}