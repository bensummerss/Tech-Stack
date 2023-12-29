namespace techstack.team.builder.blazor.web.Services
{
    public class SelectionService : ISelectionService
    {
        public event Action OnSelectionChanged;
        public string _selectedRole { get; set; }
        public string SelectedRole
        {
            get => _selectedRole;
            set
            {
                _selectedRole = value;
                NotifySelectionChanged();
            }
        }
        public string _selectedSkillset { get; set; }
        public string SelectedSkillset
        {
            get => _selectedSkillset;
            set
            {
                _selectedSkillset = value;
                NotifySelectionChanged();
            }
        }
        public string _selectedSkillLevel { get; set; }
        public string SelectedSkillLevel
        {
            get => _selectedSkillLevel;
            set
            {
                _selectedSkillLevel = value;
                NotifySelectionChanged();
            }
        }
        public int _selectedQuantity { get; set; }
        public int SelectedQuantity
        {
            get => _selectedQuantity;
            set
            {
                _selectedQuantity = value;
                NotifySelectionChanged();
            }
        }
        private void NotifySelectionChanged()
        {
            OnSelectionChanged?.Invoke();
        }
    }
}
