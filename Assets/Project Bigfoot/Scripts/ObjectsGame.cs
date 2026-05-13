using UnityEngine;
using Sirenix.OdinInspector;
using System;
using Unity.VisualScripting;


[CreateAssetMenu(fileName = "ObjectsGame", menuName = "Scriptable Objects/ObjectsGame")]
public class ObjectsGame : ScriptableObject
{
    [FoldoutGroup("Object Data")]
    public int ID;
    [FoldoutGroup("Object Data")]
    public string objectName;
    [FoldoutGroup("Object References"), PreviewField(150)]
    public Sprite Icon;
    [FoldoutGroup("Settings"), TextArea(3, 10)]
    public string Description;
}
