using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    protected int score;

    private void Start()
    {
        scoreText.text = $"Score: {score}";
    }
}
