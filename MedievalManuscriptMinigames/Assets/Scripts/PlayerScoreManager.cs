using UnityEngine;
using TMPro;

public class PlayerScoreManager : MonoBehaviour
{
    [Header("Score")]
    public TextMeshProUGUI scoreText;
    public int score = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
    }
    

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            score++;
            UpdateScore();
            Destroy(other.gameObject);
        }
    }
    
    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
    
}
