using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spwanRate = 1.0f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score = 0;
    public bool isGameActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpwanTarget());
        UpdateScore(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpwanTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spwanRate);
            int index = UnityEngine.Random.Range(0, targets.Count);
            Instantiate(targets[index]);
           
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        
        score += scoreToAdd;
        scoreText.text = "Score: " + score; 
    }
    public void GameOver ()
    {
        gameOverText.gameObject.SetActive(true);      
        isGameActive = false;
    }
    
}
