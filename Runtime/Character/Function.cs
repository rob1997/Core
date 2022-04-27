using System;
using Core.Game;
using UnityEngine;

namespace Core.Character
{
    public abstract class Function
    {
        #region FunctionCalled

        private delegate void FunctionCalled();

        private event FunctionCalled OnFunctionCalled;

        protected void InvokeFunctionCalled()
        {
            OnFunctionCalled?.Invoke();
        }

        #endregion

        #region FunctionInvoked

        private delegate void FunctionInvoked(params object[] objs);

        private event FunctionInvoked OnFunctionInvoked;

        protected void InvokeFunctionInvoked(params object[] objs)
        {
            OnFunctionInvoked?.Invoke(objs);
        }

        #endregion
    
        private Character _character;

        private Controller _controller;

        public virtual void Initialize(Controller controller)
        {
            _controller = controller;

            _character = _controller.GetCharacter();

            OnFunctionCalled += delegate { _character.InvokeFunctionCalled(this); };
            OnFunctionInvoked += objs => { _character.InvokeFunctionInvoked(this, objs); };
        }

        public abstract void Invoke(params object[] objs);

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
