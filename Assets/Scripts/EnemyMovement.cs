using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public int enemyHP;
    public float speed;
    private Waypoints Wpoints;
    private GameManagerBehavior gameManager;
    private int waypointIndex;
    public GameObject explosion;

    public Text HealthText;
    private int health = 5;

    public void Damage()
    {
        enemyHP--;
        if (enemyHP == 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        gameManager.Gold += 25;
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
        HealthText.GetComponent<Text>().text = "HEALTH: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.GetComponent<Text>().text = "HEALTH: " + health;
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
        {
            if(waypointIndex < Wpoints.waypoints.Length -1)
            {
                waypointIndex++;
            }
            else
            {
                Destroy(gameObject);
                health--;
                
            }
        }

        if(health == 0)
        {
            SceneManager.LoadScene(3);
        }

        if (gameManager.Gold == 500)
        {
            SceneManager.LoadScene(2);
        }
    }
}
