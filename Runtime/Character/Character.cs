﻿using System.Collections.Generic;
using Core.Character;
using Core.Damage;
using UnityEngine;

namespace Core.Character
{
    public abstract class Character : MonoBehaviour
    {
        #region ActionInitiated

        public delegate void ActionInitiated(Action action);

        public event ActionInitiated OnActionInitiated;

        public void InvokeActionInitiated(Action action)
        {
            OnActionInitiated?.Invoke(action);
        }

        #endregion

        #region ActionCompleted

        public delegate void ActionCompleted(Action action);

        public event ActionCompleted OnActionCompleted;

        public void InvokeActionCompleted(Action action)
        {
            OnActionCompleted?.Invoke(action);
        }

        #endregion
    
        public string title;
    
        [TextArea]
        public string description;

        [Space] 
    
        [SerializeField] private Damagable damagable;
    
        private List<Controller> _controllers;
    
        public Damager Damager { get; } = new Damager();
        public Damagable Damagable => damagable;
    
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

        public virtual void Initialize()
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
    
        public void TakeAction<T>() where T : Action
        {
            if (GetAction(out T action))
            {
                action.Execute();
            }
        }
    
        public bool GetAction<T>(out T action) where T : Action
        {
            action = null;

            foreach (Controller c in _controllers)
            {
                if (c.GetAction(out action))
                {
                    break;
                }
            }

            return action != null;
        }
    }
}