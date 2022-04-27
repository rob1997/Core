using System.Collections.Generic;
using Core.Character;
using UnityEngine;

namespace Core.Character
{
    public abstract class Character : MonoBehaviour
    {
        #region FunctionCalled

        public delegate void FunctionCalled(Function function);

        public event FunctionCalled OnFunctionCalled;

        public void InvokeFunctionCalled(Function function)
        {
            OnFunctionCalled?.Invoke(function);
        }

        #endregion

        #region FunctionInvoked

        public delegate void FunctionInvoked(Function function, params object[] objs);

        public event FunctionInvoked OnFunctionInvoked;

        public void InvokeFunctionInvoked(Function function, params object[] objs)
        {
            OnFunctionInvoked?.Invoke(function, objs);
        }

        #endregion
    
        public string title;
    
        [TextArea]
        public string description;
    
        private List<Controller> _controllers;
        
        protected virtual void Start()
        {
            if (GameManager.Instance.IsReady)
            {
                Initialize();
            }

            else
            {
                GameManager.Instance.OnReady += Initialize;
            }
        }

        protected virtual void Initialize()
        {
            _controllers = new List<Controller>(GetComponentsInChildren<Controller>());

            _controllers.ForEach(c => 
            {
                c.Initialize(this);
            });
        }

        public bool GetController<T>(out T controller) where T : Controller
        {
            controller = null;

            controller = (T) _controllers.Find(c => c is T);
        
            return controller != null;
        }
    
        public void InvokeFunction<T>() where T : Function
        {
            if (GetFunction(out T function))
            {
                function.Invoke();
            }
        }
    
        public bool GetFunction<T>(out T function) where T : Function
        {
            function = null;

            foreach (Controller c in _controllers)
            {
                if (c.GetFunction(out function))
                {
                    break;
                }
            }

            return function != null;
        }
    }
}
