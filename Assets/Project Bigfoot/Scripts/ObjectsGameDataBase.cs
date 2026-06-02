using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ObjectsGameDataBase", menuName = "Scriptable Objects/ObjectsGameDataBase")]
public class ObjectsGameDataBase : SerializedScriptableObject
{
    public Dictionary<int, ObjectsGame> objectsGameDataBase = new Dictionary<int, ObjectsGame>();

    public ObjectsGame GetObjectByID(int id)
    {
        if (objectsGameDataBase.TryGetValue(id, out ObjectsGame obj))
        {
            return obj;
        }

        Debug.Log($"No existe objeto con ID: {id}");
        return null;
    }
}