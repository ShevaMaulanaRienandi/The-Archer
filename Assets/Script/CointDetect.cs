using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CointDectect : MonoBehaviour
{
    public Text debugText;

    void Start()
    {
        // Pastikan ada komponen Text yang terpasang pada objek kosong
        if (debugText == null)
        {
            Debug.LogError("Komponen Text tidak ditemukan. Pastikan Anda telah menambahkannya.");
            return;
        }

        // Set teks awal
        debugText.text = "Hello, Debug!";
    }

    void Update()
    {
        // Contoh perubahan teks pada setiap frame
        debugText.text = "Frame: " + Time.frameCount;
    }
}