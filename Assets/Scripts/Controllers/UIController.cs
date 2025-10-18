using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController Instance;

    void Awake()
    {
        Instance = this;
    }

    public void InitUI()
    {
        // Aquí más adelante pondremos menús, HUD, etc.
        Debug.Log("UI initialized!");
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("FarmScene");
    }

    public void OpenShop()
    {
        Debug.Log("Shop opened");
    }
}