namespace techstack.team.builder.blazor.web.Models
{
    public class FormModel
    {
        public List<TeamBuilderFormItem> TeamBuilderFormItems { get; set; } = new List<TeamBuilderFormItem>();
    }

    public class TeamBuilderFormItem
    {
        public string? SelectedValues { get; set; }
    }
}
