using UnityEngine;
// using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI money_text;
    private int score = 0;
    private int money = 0;
    public AudioSource big_sound;
    [SerializeField] private AudioClip soundEffect; 
    public void QuitGame()
    {
        // Closes the application if running a built game
        Application.Quit();

        // Closes play mode if testing inside the Unity Editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void AddScore()
    {
        score ++;
        score_text.SetText($"SCORE: {score}");
    }

    public void Shop()
    {
        if(score >= 25)
        {
            score -= 25;
            money ++;
            big_sound.PlayOneShot(soundEffect);
            score_text.SetText($"SCORE: {score}");
            money_text.SetText($"Big money: {money}");
        }
    }
}

