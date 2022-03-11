using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    public GameObject TowerPrefab;
    private GameObject Tower;
    

    private bool CanPlaceTower()
    {
        return Tower == null;
    }

    void OnMouseDown()
    {
        if(CanPlaceTower())
        {
            Tower = (GameObject)
                Instantiate(TowerPrefab, transform.position, Quaternion.identity);

            // TODO: PLAY SOUND
            // TODO: DEDUCT GOLD
        }
    }

}

