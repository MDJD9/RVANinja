using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    [SerializeField] ScoreManager gameManager;
    [SerializeField] int vegetablePoints = 30;
    [SerializeField] int fruitPoints = 50;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ingridient ingridient))
        {

            if ((int)ingridient.ingridientType == 1)
            {
                gameManager.AddScore(fruitPoints);
            }
            else
            {
                gameManager.AddScore(vegetablePoints);
            }
        }
    }
}
