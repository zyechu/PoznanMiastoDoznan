using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCollider : MonoBehaviour
{
    private int valueOfFirstDie = 1;
    private int valueOfSecondDie = 1;
    private int valueOfBothDie;

    void Start()
    {
        Instantiate(GameObject.FindGameObjectWithTag("Pionek1"));
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "1x1")
        {
            valueOfFirstDie = 1;
        }
        if (collision.gameObject.tag == "1x2")
        {
            valueOfFirstDie = 2;
        }
        if (collision.gameObject.tag == "1x3")
        {
            valueOfFirstDie = 3;
        }
        if (collision.gameObject.tag == "1x4")
        {
            valueOfFirstDie = 4;
        }
        if (collision.gameObject.tag == "1x5")
        {
            valueOfFirstDie = 5;
        }
        if (collision.gameObject.tag == "1x6")
        {
            valueOfFirstDie = 6;
        }
        if (collision.gameObject.tag == "2x1")
        {
            valueOfSecondDie = 1;
        }
        if (collision.gameObject.tag == "2x2")
        {
            valueOfSecondDie = 2;
        }
        if (collision.gameObject.tag == "2x3")
        {
            valueOfSecondDie = 3;
        }
        if (collision.gameObject.tag == "2x4")
        {
            valueOfSecondDie = 4;
        }
        if (collision.gameObject.tag == "2x5")
        {
            valueOfSecondDie = 5;
        }
        if (collision.gameObject.tag == "2x6")
        {
            valueOfSecondDie = 6;
        }
        valueOfBothDie = valueOfFirstDie + valueOfSecondDie;

        GameObject.FindGameObjectWithTag("Pionek1").GetComponent<Pawn>().move(valueOfBothDie);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 100), "Value of both die: " +
valueOfBothDie.ToString());
    }
}

