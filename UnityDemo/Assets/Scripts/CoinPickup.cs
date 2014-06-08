using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour
{
    public float RotationSpeed = 50;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * RotationSpeed);
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.GetComponent<PlayerMovement>() != null)
        {
            // This script is only on the player
            Destroy(gameObject);
        }
    }
}
