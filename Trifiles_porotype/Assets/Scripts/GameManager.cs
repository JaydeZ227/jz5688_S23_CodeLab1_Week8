using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public LocationScriptableObjects currentLocation;
    
    public Button north;
    public Button south;
    public Button west;
    public Button east;
    
    void UpdateLocation()
    {
        title.text = currentLocation.locationName;
        description.text = currentLocation.locationDescription;
        
        if (currentLocation.northLocation == null)
        {
            north.gameObject.SetActive(false);
        }
        else
        {
            north.gameObject.SetActive(true);
            currentLocation.northLocation.southLocation = currentLocation;
        }
        
        if (currentLocation.southLocation == null)
        {
            south.gameObject.SetActive(false);
        }
        else
        {
            south.gameObject.SetActive(true);
            currentLocation.southLocation.northLocation = currentLocation;
        }
        
        if (currentLocation.eastLocation == null)
        {
            east.gameObject.SetActive(false);
        }
        else
        {
            east.gameObject.SetActive(true);
            currentLocation.eastLocation.westLocation = currentLocation;
        }
        
        if (currentLocation.westLocation == null)
        {
            west.gameObject.SetActive(false);
        }
        else
        {
            west.gameObject.SetActive(true);
            currentLocation.westLocation.eastLocation = currentLocation;
        }
    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
           case 1: //NORTH
               currentLocation = currentLocation.northLocation;
               break;
           case 2:
               currentLocation = currentLocation.southLocation;
               break;
           case 3:
               currentLocation = currentLocation.westLocation;
               break;
           case 4:
               currentLocation = currentLocation.eastLocation;
               break;
        }
        
        UpdateLocation();
    }

}
