using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score_man : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI curr_score;
    [SerializeField] private TextMeshProUGUI high_score;
    public static score_man instance;
    public int highest;

    public int score = 0;

    void Awake()
    {
        instance = this;
        score = 0;
        curr_score.text = "Score: " + score.ToString();
        highest = PlayerPrefs.GetInt("High", 0); 

        high_score.text = "Highest Score: " + highest.ToString();
    }

    public void increment_score()
    {
        score += 1;
        curr_score.text = "Score: " + score.ToString();
    }

    public void score_reset()
    {
        if (score > highest)
        {
            PlayerPrefs.SetInt("High", score);
        }
        score = 0;
        curr_score.text = "Score: " + score.ToString();
        high_score.text = "Highest Score: " + PlayerPrefs.GetInt("High", 0).ToString();
        
    }


}
