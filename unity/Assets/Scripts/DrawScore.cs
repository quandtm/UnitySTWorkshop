using Assets.Scripts;
using UnityEngine;
using System.Collections;

public class DrawScore : MonoBehaviour
{
    void OnGUI()
    {
        GUI.TextArea(new Rect(10, 10, 100, 20), string.Format("Score: {0}", GameManager.Instance.CurrentScore));
    }
}
