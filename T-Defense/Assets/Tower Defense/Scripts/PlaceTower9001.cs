using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower9001 : MonoBehaviour
{
  public GameObject Tower;

  public GameObject World;

  public GameObject Purse;
  public static event Action OnTowerPlaced;
    // Start is called before the first frame update
    void Start()  
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
          if (hit.transform.CompareTag("TowerSpot"))
          {
            //Book keeping
            // if good 
            if (Purse.GetComponent<CoinTracker>().GetCurrentTotal() >= 6)
            {
              hit.transform.gameObject.SetActive(false);
                        PlaceTower(hit.transform.position);
            }
            else
            {
              print("Not Enough Coins!");
            }
          }
        else
          print("I'm looking at nothing!");
        
    }

    //raycast
    //hitplace
    //purse script $$$$
    //instantiate a tower

  }

    void PlaceTower(Vector3 position)
    {
      //Book keeping
      OnTowerPlaced?.Invoke();
        Instantiate(Tower, position, Quaternion.identity, World.transform);
    }
}
