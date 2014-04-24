using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public GameObject Bat;
    public float LaunchForce;

    // Use this for initialization
    void Start()
    {
        transform.parent = Bat.transform;
    }

    void FixedUpdate()
    {
        // Only do this if the object is being simulated (isKinematic = false)
        if (!rigidbody.isKinematic)
        {
            var vel = rigidbody.velocity;
            vel.z = 0;
            rigidbody.velocity = vel;
        }
        var pos = transform.position;
        pos.z = 0;
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.parent = null;
            rigidbody.isKinematic = false;
            rigidbody.AddForce(Vector3.up * LaunchForce);
        }
    }
}
