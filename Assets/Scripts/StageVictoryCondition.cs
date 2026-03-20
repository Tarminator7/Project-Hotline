using UnityEngine;
using UnityEngine.SceneManagement;

public class StageVictoryCondition : MonoBehaviour
{
    [SerializeField] SceneSettings sceneSettings;
    private GameObject[] enemies;
    private bool hasLoaded = false;

    void Start()
    {
        // Find all enemies in the scene and count them
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void Update()
{
    if (!hasLoaded && AllEnemiesDefeated())
    {
        hasLoaded = true;
        LoadNewScene();
    }
}

bool AllEnemiesDefeated()
{
    return GameObject.FindGameObjectsWithTag("Enemy").Length == 0;
}

   private void LoadNewScene()
{
    sceneSettings.SceneNumber++; // Grows the scene number
     Debug.Log("SceneNumber nyt: " + sceneSettings.SceneNumber);
     int maxScenes = SceneManager.sceneCountInBuildSettings;

    SceneManager.LoadScene(sceneSettings.SceneNumber); // Loads the new scene based on the updated scene number

    // Shop: SceneManager.LoadScene("ShopScene"); Replace "ShopScene" with the actual name of your shop scene when it is ready.

}
}
