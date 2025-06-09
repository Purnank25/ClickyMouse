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
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpwanTarget());
        UpdateScore(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpwanTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spwanRate);
            int index = UnityEngine.Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    void UpdateScore(int scoreToAdd)
    {
        score = 0;
        scoreText.text = "Score: " + score; 
    }
    
}
