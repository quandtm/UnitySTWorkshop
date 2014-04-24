using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
