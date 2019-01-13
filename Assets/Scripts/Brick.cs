using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] private ParticleSystem blickBroken;

    private void OnCollisionEnter(Collision collision)
    {
        ParticleSystem toInstanciate = Instantiate(blickBroken, transform.position, Quaternion.identity);
        toInstanciate.transform.SetParent(transform.parent);

        Destroy(gameObject);
    }
}
