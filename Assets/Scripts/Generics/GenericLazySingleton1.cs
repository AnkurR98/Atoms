using UnityEngine;

/* Used by Singletons which are destroyed every scene */

public class GenericLazySingleton<T> : MonoBehaviour where T : GenericLazySingleton<T>
{
    private static T instance;
    public static T Instance { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
