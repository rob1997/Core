using System;
using UnityEngine;

namespace Core.Game
{
    public abstract class Action
    {
        #region ActionInitiated

        private delegate void ActionInitiated();

        private event ActionInitiated OnActionInitiated;

        protected void InvokeActionInitiated()
        {
            OnActionInitiated?.Invoke();
        }

        #endregion

        #region ActionCompleted

        private delegate void ActionCompleted();

        private event ActionCompleted OnActionCompleted;

        protected void InvokeActionCompleted()
        {
            OnActionCompleted?.Invoke();
        }

        #endregion
    
        private Character _character;

        private Controller _controller;

        public virtual void Initialize(Controller controller)
        {
            _controller = controller;

            _character = _controller.GetCharacter();

            OnActionInitiated += delegate { _character.InvokeActionInitiated(this); };
            OnActionCompleted += delegate { _character.InvokeActionCompleted(this); };
        }

        public abstract void Execute(params object[] objs);

        protected T GetObj<T>(object obj)
        {
            try
            {
                return (T) obj;
            }
        
            catch (Exception e)
            {
                Debug.LogError($"Case Error ; Type Mismatch {e}");
            
                throw;
            }
        }
    
        public Character GetCharacter()
        {
            return _character;
        }
    
        public Controller GetController()
        {
            return _controller;
        }
    }
}
