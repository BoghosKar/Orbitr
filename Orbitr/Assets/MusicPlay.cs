using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{

    private static bool created = false;

    void Awake()
{
    if (!created)
    {
        // If this is the first instance of the background music, mark it as created
        created = true;
        DontDestroyOnLoad(transform.gameObject);
    }
    else
    {
        // If the background music has already been created, destroy the new instance
        Destroy(gameObject);
    }
}
}
