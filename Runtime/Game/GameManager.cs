using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core.Game;
using Core.Utils;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    #region Ready

    public delegate void Ready();

    //all Managers have been initialized
    public event Ready OnReady;

    public bool IsReady { get; private set; }
    
    private void InvokeReady()
    {
        if (IsReady)
        {
            Debug.LogError($"{nameof(GameManager)} already ready");
        }

        else
        {
            OnReady?.Invoke();

            IsReady = true;
        }
    }

    #endregion
    
    List<Manager> _managers;

    private void Start()
    {
        Initialize();
        
        _managers.ForEach(m => m.Initialize());
        
        InvokeReady();
    }

    private void Initialize()
    {
        _managers = new List<Manager>(GetComponentsInChildren<Manager>());
    }

    public bool GetManager<T>(out T manager) where T : Manager
    {
        manager = null;

        manager = (T) _managers.Find(m => m is T);

        if (manager == null)
        {
            Debug.LogError($"can't find manager {typeof(T)}");
        }
        
        return manager != null;
    }
}
