using Assets.Scripts;
using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public GameObject Bat;
    public float LaunchForce;
    public float ScoreLossOnDeath;

    private Vector3 _origOffset;

    // Use this for initialization
    void Start()
    {
        // Use localposition to get relative to parent
        _origOffset = transform.localPosition;
    }

    void FixedUpdate()
    {
        // Only do this if the object is being simulated (isKinematic = false)
        if (!rigidbody.isKinematic)
        {
            var vel = rigidbody.velocity;
            vel.z = 0;
            rigidbody.velocity = vel.normalized * LaunchForce;
        }
        var pos = transform.position;
        pos.z = 0;
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.parent = null;
            rigidbody.isKinematic = false;
            rigidbody.velocity = Vector3.up * LaunchForce;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        var adjustment = Random.onUnitSphere;
        adjustment.z = 0;
        rigidbody.velocity = rigidbody.velocity + adjustment;
    }

    void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.AddScore(-ScoreLossOnDeath);
        Reset();
    }

    private void Reset()
    {
        if (!rigidbody.isKinematic)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
            rigidbody.isKinematic = true;
        }
        transform.parent = Bat.transform;
        transform.localPosition = _origOffset;
    }
}
