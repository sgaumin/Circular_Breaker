using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance; 

    [HideInInspector] public List<Ball> balls = new List<Ball>();

    private void Awake()
    {
        if (instance = null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        // TO DO: When ball go outside the level, relaod level

        //if (other.GetComponent<Ball>())
        //{
        //    GameSystem.instance.ReloadLevel();
        //}
    }
}
