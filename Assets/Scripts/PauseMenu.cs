#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private InputActionReference pause;
    public GameObject container;
    public UnityEvent OnPause;
    public UnityEvent OnResume;

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        container.SetActive(true);
    //        Time.timeScale = 0;
    //    }
    //}

    private void OnEnable()
    {
        pause.action.Enable();
        pause.action.performed += OnPausePerformed;
    }

    private void OnPausePerformed(InputAction.CallbackContext context)
    {
        container.SetActive(true);
        Time.timeScale = 0;
        OnPause.Invoke();
    }

    public void ResumeButton()
    {
        container.SetActive(false);
        Time.timeScale = 1;
        OnResume.Invoke();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
        container.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
