using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Serializable: Lets you embed a class with sub
properties in the inspector you can use this to 
display variable in the inspactor similar to how a 
vector 3 shows up in the inspector.*/

[System.Serializable]
public class Exit
{
    public string keyString;
    public string exitDescription;
    public Room valueRoom;
}