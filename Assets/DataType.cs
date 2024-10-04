using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    public int umur;
    public float tinggiBadan;
    public char inisial;
    public string nama;

    public enum vote { shap, mantap, woke}
    public vote komentar;
    string myText;
    public Vector2 Koordinat2D;
    public Vector3 Koordinat3D;
    // Start is called before the first frame update
    void Start()
    {
    if (komentar == vote.shap)
        {
            myText = "ntapps";
        }
    else
        {
            myText = "Woke Ndan";
        }
        //Tampilkan di console

        Debug.Log("Umur : " + umur + "\nTinggi Badan : " + tinggiBadan + "\nInisial : " + inisial + "\nNama : " + nama + "\nKomentar : " + myText +
            "\n2D : " + Koordinat2D.ToString() + " \n3D : " + Koordinat3D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
