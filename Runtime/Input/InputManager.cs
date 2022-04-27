using Core.Game;
using Core.Input;

namespace Core.Input
{
    public class InputManager : Manager
    {
        public BaseInputActions InputActions { get; private set; }

        public override void Initialize()
        {
            InputActions = new BaseInputActions();
        
            InputActions.Enable();
        }
    }
}
