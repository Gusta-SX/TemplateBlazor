namespace TemplateBlazor.Services
{
    public class FiltrosMobileBusca
    {
        public bool IsActive { get; private set; } = false;

        public event Action OnToggle;

        public void Toggle()
        {
            IsActive = !IsActive;
            OnToggle?.Invoke();
        }
    }

}
