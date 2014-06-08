using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    public float RotationSpeed = 50;
    private float _rotation;

    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0, 5, -8);
        transform.LookAt(Player.transform);
        transform.RotateAround(Player.transform.position, Vector3.up, _rotation);

        if (Input.GetAxis("Horizontal") > 0)
        {
            // Right
            _rotation += Time.deltaTime * RotationSpeed;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            // Left
            _rotation -= Time.deltaTime * RotationSpeed;
        }
    }
}
