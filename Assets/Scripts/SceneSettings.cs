using UnityEngine;

[CreateAssetMenu(fileName = "Scene Settings", menuName = "Scenes/Scene Settings")]
public class SceneSettings : ScriptableObject
{
    [field: SerializeField] public int SceneNumber { get; private set; }
}
