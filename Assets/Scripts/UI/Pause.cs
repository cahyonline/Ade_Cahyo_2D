using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    private bool isPaused = false;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (isPaused){
                Resume();
                
            }
            else
            Pause();

        }
    }

    private void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0; 
        isPaused = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; 
        isPaused = false;
    }
}
