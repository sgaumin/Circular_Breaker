using UnityEngine;

public class DestroyOnLoad : MonoBehaviour
{
    [SerializeField] private float timeToDestroy;

    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
