using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    void Awake()
    {
        Instance = this;
    }

    public void InitGame()
    {
        // Aquí se pueden inicializar controladores, variables globales, etc.
        Debug.Log("Game initialized!");
    }

    public void StartGame()
    {
        Debug.Log("Game started");
    }
}
