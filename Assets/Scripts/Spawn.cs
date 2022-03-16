using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    public float rate;
    public GameObject[] enemies;
    public int waves = 1;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", rate, rate);
    }

    /*private void Update()
    {
        timer++;
        if(timer == 10000)
        {
            SceneManager.LoadScene(2);
        }
    }*/

    
    void SpawnEnemy()
    {
        for (int i = 0; i < waves; i++)
        {
            Instantiate(enemies[(int)Random.Range(0, enemies.Length)], new Vector3(-12, 0, 0), Quaternion.identity);
        }
    }
}
