using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageVictoryCondition : MonoBehaviour
{
    private int stage = 2;

    private void Shop()
    {
        //Here to add code go to shop after stage clear
    }

    private void LoadNewScene()
    {
        SceneManager.LoadScene(stage);
        stage++;
    }
}
