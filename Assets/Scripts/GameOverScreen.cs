using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _panel;

    private void Start()
    {
        _panel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        Debug.Log("UPDATE");


        if (_player.CurrHealth <= 0)
            OnDied();
        else
            return;
    }

    private void OnDied()
    {
        print("DIED");
        _panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton()
    {
        print("RESTART");
        _panel.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}