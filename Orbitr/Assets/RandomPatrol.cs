using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{
    //Map position border things
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    public float minSpeed;
    public float maxSpeed;

    float speed;

    //Difficulty timer over time more difficult thing
    public float secondsToMaxDifficulty;
    
    
    void Start()
    {
        targetPosition = GetRandomPosition();
    }

    void Update()
    {
        speed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());

        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        } else {
            targetPosition = GetRandomPosition(); 
        }
    }

    Vector2 GetRandomPosition() 
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }

    

    float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);


    }

    
}
