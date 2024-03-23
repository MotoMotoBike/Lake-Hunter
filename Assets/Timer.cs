
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private GameObject gameOverScreen;
    public static float time = 0; 
    void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        timeText.text = $"{((int)time).ToString()}:{(time - (int)time).ToString().Substring(2, 2)}";
        if (time >= 60)
        {
            gameOverScreen.SetActive(true);
        }
    }
}
