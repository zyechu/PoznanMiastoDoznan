using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    private int currentPosition = 1;
    private Transform transform2;

    void Start()
    {
        transform2 = this.GetComponent<Transform>();
        Vector3 position = transform2.position;
    }

    public void move(int number)
    {
        Debug.Log("currentPosition" + currentPosition);
        Debug.Log("number: " + number);
        int newPosition = (currentPosition + number) % 40;
        if (newPosition == 0) newPosition = 1;
        Debug.Log(newPosition);
        string tag = "Field" + newPosition;
        Debug.Log(tag);
        Vector3 finalPosition =
GameObject.FindGameObjectWithTag(tag).transform.position;
        Debug.Log(finalPosition);
        transform.position = finalPosition;
        currentPosition = newPosition;
    }
}
