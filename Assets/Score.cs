using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class Score : MonoBehaviour
    {
        public static int score = 0;
        public TextMeshProUGUI[] scoreText;
        
        private void Start()
        {
            score = 0;
        }

        public static void AddScore( int value)
        {
            score += value;
        }

        private void Update()
        {
            for (int i = 0; i < scoreText.Length; i++)
            {
                scoreText[i].text = score.ToString();
            }
        }
    }
}