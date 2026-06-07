using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 Instance { get; private set; }

    public GameStatus2 currentStatus;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeStatus(GameStatus2.MenuPrincipal);
    }

    public void ChangeStatus(GameStatus2 newStatus)
    {
        currentStatus = newStatus;

        if (currentStatus == GameStatus2.Pausa || currentStatus == GameStatus2.MenuPrincipal)
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (currentStatus == GameStatus2.EnCaceria)
        {
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else if (currentStatus == GameStatus2.Derrota || currentStatus == GameStatus2.Victoria)
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void StartGame()
    {
        ChangeStatus(GameStatus2.EnCaceria);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ChangeStatus(GameStatus2.EnCaceria);
    }

    public void FinishGame()
    {
        ChangeStatus(GameStatus2.Victoria);
    }
}