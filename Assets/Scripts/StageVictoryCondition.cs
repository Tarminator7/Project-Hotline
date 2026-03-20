using UnityEngine;
using UnityEngine.SceneManagement;

public class StageVictoryCondition : MonoBehaviour
{
    [SerializeField] SceneSettings sceneSettings;
    private GameObject[] enemies;

    void Start()
    {
        // Find all enemies in the scene and count them
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void Update()
    {
        if (AllEnemiesDefeated())
        {
            LoadNewScene();
        }
    }

    bool AllEnemiesDefeated()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                return false; // At least one enemy is still alive
            }
        }
        return true; // All enemies are defeated

    }


    private void Shop()
    {
        //Here to add code go to shop after stage clear
    }

    private void LoadNewScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(sceneSettings.SceneNumber); // FIX THIS!!!
    }
}
