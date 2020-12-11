using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public GameObject gameOverScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle") || other.CompareTag("Obstaclee"))
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
            UIManager.instance.score.text = "Score: " + Score.instance.score.text;
            if (Convert.ToInt32(Score.instance.score.text) > PlayerPrefs.GetInt("HighestScore", 0))
                PlayerPrefs.SetInt("HighestScore", Convert.ToInt32(Score.instance.score.text));
            UIManager.instance.highestScore.text = "Highest Score: " + PlayerPrefs.GetInt("HighestScore").ToString();
        }
        if(other.CompareTag("Gold"))
        {
            ParticleManager.instance.goldParticle.transform.position = other.transform.position;
            ParticleManager.instance.goldParticle.Clear();
            ParticleManager.instance.goldParticle.Play();

            Destroy(other.gameObject);
        }
    }
    
}
