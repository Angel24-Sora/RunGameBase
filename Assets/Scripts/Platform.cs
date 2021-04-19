using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;
    private bool stepped = false;

    private void OnEnable()
    {
        stepped = false;
        for(int i = 0; i < obstacles.Length; i++)
        {
            if (Random.Range(0, 3) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }
    void OnColiisionEnter2D(Collision2D collision)
    {
        Debug.Log("1");
        if(collision.collider.tag == "Player" && !stepped)
        {
            Debug.Log("2");
            stepped = true;
            GameManager.instance.AddScore(1);
        }
    }
}
