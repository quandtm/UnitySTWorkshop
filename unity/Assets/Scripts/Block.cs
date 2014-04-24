using Assets.Scripts;
using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    public float Score;

    void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.AddScore(Score);
        Destroy(gameObject);
    }
}
