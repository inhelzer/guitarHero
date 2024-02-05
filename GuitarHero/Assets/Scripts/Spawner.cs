using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject onePrefab;
    double[] timeOne = { 2.31, 2.79, 6.09, 6.58, 8, 8.45, 11.79, 12.1, 12.57, 15.63, 17.48, 17.92, 19.38, 19.83, 21.29, 21.72, 23.17, 24.13, 25.09, 30.77, 33.63, 34.58, 42.25, 42.45, 42.69, 42.94, 43.2, 43.42, 43.67, 43.9, 44.14, 44.37, 44.62, 44.85, 45.1, 45.53, 48.8, 49.26, 51.17, 55.42, 55.89, 56.41, 56.86 };
    int counterOne = 0;

    [SerializeField] GameObject twoPrefab;
    double[] timeTwo = { 5.13, 5.62, 7.06, 7.51, 10.84, 11.31, 12.32, 12.57, 12.82, 13.05, 13.26, 13.46, 13.72, 13.99, 14.23, 14.46, 14.73, 14.98, 15.22, 16.54, 18.42, 18.87, 21.29, 21.72, 22.25, 26.06, 26.33, 26.53, 26.79, 27.01, 27.21, 27.4, 27.63, 27.93, 28.18, 28.42, 28.68, 28.92, 29.18, 29.4, 29.59, 29.88, 30.12, 30.38, 31.73, 32.69, 35.52, 40.8, 41.72, 46.95, 47.39, 50.24, 51.65, 52.14, 53.56, 54.5 };
    int counterTwo = 0;

    [SerializeField] GameObject threePrefab;
    double[] timeThree = { 3.24, 3.7, 6.1, 6.57, 8.92, 9.41, 17, 17.48, 17.93, 19.37, 19.82, 20.32, 20.78, 23.66, 24.59, 25.55, 31.24, 32.19, 33.16, 34.08, 36.48, 37.18, 37.7, 38.21, 38.71, 39.19, 39.64, 40.11, 42.25, 42.44, 42.69, 42.95, 43.2, 43.42, 43.66, 43.9, 44.13, 44.37, 44.62, 44.84, 45.09, 45.54, 47.83, 48.31, 50.71, 55.43, 55.88, 56.41, 56.86 };
    int counterThree = 0;

    [SerializeField] GameObject fourPrefab;
    double[] timeFour = { 4.18, 4.65, 7.07, 7.52, 9.91, 10.37, 16.1, 18.42, 18.87, 20.32, 20.78, 22.67, 26.32, 26.54, 26.8, 27.02, 27.22, 27.41, 27.65, 27.93, 28.18, 28.42, 28.68, 28.93, 29.18, 29.4, 29.58, 29.89, 30.13, 30.38, 35.04, 35.97, 36.96, 37.43, 37.94, 38.47, 38.94, 39.4, 39.83, 40.36, 41.27, 41.73, 45.99, 46.51, 49.76, 52.63, 53.11, 54.03, 54.96 };
    int counterFour = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnOne();
        SpawnTwo();
        SpawnThree();
        SpawnFour();
    }

    private void SpawnOne()
    {
        if(counterOne < timeOne.Length)
        {
            if (Time.timeSinceLevelLoad + 0.5 >= timeOne[counterOne])
            {
                Instantiate(onePrefab, transform.position, Quaternion.identity);
                counterOne++;
            }
        }
    }

    private void SpawnTwo()
    {
        if (counterTwo < timeTwo.Length)
        {
            if (Time.timeSinceLevelLoad + 0.5 >= timeTwo[counterTwo])
            {
                Instantiate(twoPrefab, transform.position, Quaternion.identity);
                counterTwo++;
            }
        }
        
    }

    private void SpawnThree()
    {
        if(counterThree < timeThree.Length)
        {
            if (Time.timeSinceLevelLoad + 0.5 >= timeThree[counterThree])
            {
                Instantiate(threePrefab, transform.position, Quaternion.identity);
                counterThree++;
            }
        }
        
    }

    private void SpawnFour()
    {
        if(counterFour < timeFour.Length)
        {
            if (Time.timeSinceLevelLoad + 0.5 >= timeFour[counterFour])
            {
                Instantiate(fourPrefab, transform.position, Quaternion.identity);
                counterFour++;
            }
        }
        
    }
}
