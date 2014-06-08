using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0, 5, -10);
        transform.LookAt(Player.transform);
    }
}
