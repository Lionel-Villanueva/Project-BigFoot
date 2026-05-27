using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ObjectsGameDataBase", menuName = "Scriptable Objects/ObjectsGameDataBase")]
public class ObjectsGameDataBase : SerializedScriptableObject
{
    public Dictionary<int, ObjectsGame> objectsGaneDataBase = new Dictionary<int, ObjectsGame>();
}
