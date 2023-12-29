namespace techstack.team.builder.blazor.web.Services
{
    public interface ISelectionService
    {
        event Action OnSelectionChanged;
        string SelectedRole { get; set; }
        string SelectedSkillset { get; set; }
        string SelectedSkillLevel { get; set; }
        int SelectedQuantity { get; set; }
    }
}
