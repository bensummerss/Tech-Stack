using System.ComponentModel.DataAnnotations;
using static techstack.team.builder.blazor.web.Pages.TeamBuilder.TeamBuilderFormRow;

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
