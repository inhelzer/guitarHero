using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject onePrefab;
    double[] timeOne = {  4, 8.5, 11 };
    int counterOne = 0;

    [SerializeField] GameObject twoPrefab;
    double[] timeTwo = { 1, 2, 3, 4, 5, 6, 7 };
    int counterTwo = 0;

    [SerializeField] GameObject threePrefab;
    double[] timeThree = { 1.5, 3, 4.5, 6, 7.5, 9, 10.5 };
    int counterThree = 0;

    [SerializeField] GameObject fourPrefab;
    double[] timeFour = { 2, 4, 6, 8, 10 };
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
        if(Time.timeSinceLevelLoad >= timeOne[counterOne])
        {
            Instantiate(onePrefab, transform.position, Quaternion.identity);
            counterOne++;
        }
    }

    private void SpawnTwo()
    {
        if (Time.timeSinceLevelLoad >= timeTwo[counterTwo])
        {
            Instantiate(twoPrefab, transform.position, Quaternion.identity);
            counterTwo++;
        }
    }

    private void SpawnThree()
    {
        if (Time.timeSinceLevelLoad >= timeThree[counterThree])
        {
            Instantiate(threePrefab, transform.position, Quaternion.identity);
            counterThree++;
        }
    }

    private void SpawnFour()
    {
        if (Time.timeSinceLevelLoad >= timeFour[counterFour])
        {
            Instantiate(fourPrefab, transform.position, Quaternion.identity);
            counterFour++;
        }
    }
}
