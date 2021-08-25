using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T _instance;
    //this is to make sure our singleton is thread safe
    private static Object m_lock = new Object();

    public static T Instance
    {
        get
        {
            lock (m_lock)
            {
                if(_instance is null)
                {
                    _instance = (T) FindObjectOfType(typeof(T));

                    if (FindObjectsOfType(typeof(T)).Length > 1)
                    {
                        Debug.LogError($"multiple instances of {typeof(T)} found.");
                    }
                    
                    if(_instance is null)
                    {
                        GameObject singleton = new GameObject();
                        _instance = singleton.AddComponent<T>();
                        singleton.name = typeof(T).ToString() + "Singleton";
                        DontDestroyOnLoad(singleton);
                    }
                    else
                    {
                        Debug.Log($"Trying to recreate instance of already existing {typeof(T)}Singleton class");
                    }
                }
                return _instance;
            }
        }
    }
}
