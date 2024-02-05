using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int score = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        FindObjectOfType<sliderController>().ToSlide(score);
    }

    public void LooseScore()
    {
        score--;
        FindObjectOfType<sliderController>().ToSlide(score);
    }
}
