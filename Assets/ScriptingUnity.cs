using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingUnity : MonoBehaviour
{
    float totalScore;
    float rataRata;
    // Start is called before the first frame update
    void Start()
    {
        ForWhileLoop();
        Array();
        IfElsesIfCondition();
        ComparisonOperator();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ForWhileLoop()
    {
        for (int healt = 100; healt < 0; healt++)
        {
            Debug.Log("Jumlah healt :" + healt);
        }

        int nyawa = 100;
        while (nyawa > 0)
        {
            nyawa -= 10;
            Debug.Log("nyawa tersisa: " + nyawa);
        }
        Debug.Log("Pemain Mati");
    }

    void Array()
    {
        int[] scores = { 100, 90, 85, 70, 60 };

        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("Skor ke- " + (i + 1) + ":" + scores[i]);
            totalScore += scores[i];
        }

        rataRata = totalScore / scores.Length;
        Debug.Log("Rata-Rata : " + rataRata);

        bool kualitasPlayer = false;
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > 80)
            {
                kualitasPlayer = true;
                break;
            }
        }
        if (kualitasPlayer)
        {
            Debug.Log("Pemain Berkualitas Tinggi");
        }
        else
        {
            Debug.Log("Pemain Butuh Latihan");
        }
    }
    void IfElsesIfCondition()
    {
        int healt = 60;

        if (healt > 50)
        {
            Debug.Log("Pemain Sehat");
        }
        else if (healt > 20)
        {
            Debug.Log("Pemain Perlu Berhati hati");
        }
        else
        {
            Debug.Log("Pemain dalam Bahaya");
        }
    }

    void ComparisonOperator()
    {
        int Armor = 40;
        int healt = 60;
        if (Armor >= 30 && healt >= 50)
        {
            Debug.Log("Pemain Siap Bertarung");
        }
        else
        {
            Debug.Log("Pemain Perlu Bersiap");
        }
    }
}
