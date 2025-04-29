using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string playerName;
    public string playerClass;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject); // Mantener entre escenas si cambias de escena
    }

    public void StartGame(string name, string playerClass)
    {
        this.playerName = name;
        this.playerClass = playerClass;

        Debug.Log("Iniciando juego con nombre: " + name + " y clase: " + playerClass);

   
    }
}
