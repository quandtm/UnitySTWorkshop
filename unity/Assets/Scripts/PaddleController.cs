using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour
{
    public float MinX;
    public float MaxX;
    public float Speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var currentPos = transform.position;
        var delta = Speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            currentPos.x -= delta;
        else if (Input.GetKey(KeyCode.RightArrow))
            currentPos.x += delta;

        if (currentPos.x < MinX)
            currentPos.x = MinX;
        else if (currentPos.x > MaxX)
            currentPos.x = MaxX;

        transform.position = currentPos;
    }
}
