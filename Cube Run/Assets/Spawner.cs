using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public float Delay;
    public Transform LeftPos;
    public Transform RightPos;
    public Transform MidPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, Delay);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawn()
    {
        int randomPos = Random.Range(1, 4);

        if (randomPos == 1)
        {
            Instantiate(Enemy, LeftPos);
        }
        else if (randomPos == 2)
        {
            Instantiate(Enemy, RightPos);
        }
        else
        {
            Instantiate(Enemy, MidPos);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);

        }

    }
}






