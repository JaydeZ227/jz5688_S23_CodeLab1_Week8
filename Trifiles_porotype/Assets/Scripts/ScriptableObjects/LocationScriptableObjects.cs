using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(
    fileName = "ScriptableObjects/Location",
    menuName = "ScriptableObjects/Location",
    order = 0
)]
public class LocationScriptableObjects : ScriptableObject
{
    
    public string locationName;
    public string locationDescription;

    public LocationScriptableObjects northLocation;
    public LocationScriptableObjects southLocation;
    public LocationScriptableObjects westLocation;
    public LocationScriptableObjects eastLocation;
}