using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    [SerializeField] Transform towerFollow;
    public GameObject TowerPrefab;
    public GameObject Tower2Prefab;
    private GameObject Tower;
    private GameObject Tower2;
    private GameManagerBehavior gameManager;
    //public Rigidbody2D rb;
    public Camera cam;

    Vector2 mousePos;

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

 

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }


    private bool CanPlaceTower()
    {
        return Tower == null;
    }

    void OnMouseDown()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rotation = Quaternion.LookRotation(mousePos - towerFollow.transform.position, towerFollow.transform.TransformDirection(Vector3.forward));
        towerFollow.transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);



        if (CanPlaceTower() && gameManager.Gold >= 100)
        {
            Tower = (GameObject)
                Instantiate(TowerPrefab, transform.position, Quaternion.identity);
                /*Vector3 lookDir = mousePos - Tower.transform.position;
                float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
                Tower.transform.rotation = angle;*/
            Destroy(this.gameObject);
            

            // TODO: PLAY SOUND
            gameManager.Gold -= 100;
            
        }
        /*else if(CanPlaceTower() && gameManager.Gold >= 150)
        {
            Tower2 = (GameObject)
                Instantiate(TowerPrefab, transform.position, Quaternion.identity);

            // TODO: PLAY SOUND
            gameManager.Gold -= 150;
        }*/
    }

}

