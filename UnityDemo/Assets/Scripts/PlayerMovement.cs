using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float Power = 40;
    public float JumpPower = 300;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            var forward = transform.position - Camera.main.transform.position;
            forward.y = 0;
            forward.Normalize();
            rigidbody.AddForce(forward * (Power * Time.deltaTime));
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            var backward = Camera.main.transform.position - transform.position;
            backward.y = 0;
            backward.Normalize();
            rigidbody.AddForce(backward * (Power * Time.deltaTime));
        }

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector3.up * JumpPower);
        }
    }
}
