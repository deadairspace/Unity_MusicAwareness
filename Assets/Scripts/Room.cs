using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MusicAwareness/Room")]
public class Room : ScriptableObject
{
    public string description;
    public string roomName;
    public Exit[] exits;


}
