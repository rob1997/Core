using System.Collections.Generic;
using Core.Character;
using UnityEngine;

namespace Core.Character
{
    public abstract class Controller : MonoBehaviour
    {
        private List<Function> _functions = new List<Function>();

        private Character _character;
    
        public virtual void Initialize(Character character)
        {
            _character = character;
        }

        public void AddFunctions(List<Function> functions)
        {
            functions.ForEach(function =>
            {
                if (_functions.Find(a => a.GetType() == function.GetType()) == null)
                {
                    _functions.Add(function);
            
                    function.Initialize(this);
                }

                else
                {
                    Debug.LogError($"function {function} already exists");
                }
            });
        }
    
        public void InvokeFunction<T>(params object[] objs) where T : Function
        {
            if (GetFunction(out T function))
            {
                function.Invoke(objs);
            }
        }
    
        public bool GetFunction<T>(out T function) where T : Function
        {
            function = null;

            function = (T) _functions.Find(a => a is T);

            if (function == null)
            {
                Debug.LogError($"can't find function {typeof(T)}");
            }
        
            return function != null;
        }
    
        public Character GetCharacter()
        {
            return _character;
        }
    }
}
