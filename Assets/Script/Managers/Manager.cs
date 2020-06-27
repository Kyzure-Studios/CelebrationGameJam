using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Credit: Wingedevil
// https://github.com/TruckDefenseInstitute/Convoy/blob/master/Assets/Scripts/Managers/Manager.cs
public abstract class Manager<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;

    public static T Instance
    {
        get
        {
            return _instance;
        }

        private set
        {
            if (_instance == null)
            {
                _instance = value;
            }
            else if (_instance != value)
            {
                Destroy(value.gameObject);
            }
        }
    }

    // Start is called before the first frame update
    protected virtual void Awake()
    {
        Instance = this as T;
    }
}
