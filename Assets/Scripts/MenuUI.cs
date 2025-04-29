using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public InputField nameInput;
    public Dropdown classDropdown;
    public Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        string playerName = nameInput.text;
        string selectedClass = classDropdown.options[classDropdown.value].text;

        if (string.IsNullOrEmpty(playerName))
        {
            Debug.LogWarning("El nombre del jugador está vacío.");
            return;
        }

        GameManager.Instance.StartGame(playerName, selectedClass);
    }
}
