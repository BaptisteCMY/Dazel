using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isPlaying = true;

    [SerializeField]
    private GameObject m_EndingCanvas;

    [SerializeField]
    private TMP_Text m_EndingText;

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame(bool win)
    {
        if (!_isPlaying)
        {
            return;
        }

        _isPlaying = false;

        m_EndingCanvas.SetActive(true);

        m_EndingText.text = win ? "GG WP" : "OH NO";

        FindObjectOfType<PlayerController>().enabled = false;
    }
}
