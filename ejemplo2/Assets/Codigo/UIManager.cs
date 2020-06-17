﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se debe exportar esto
using TMPro;

public class UIManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    
    //Nuevo Metodo

    public void AddScore(int punto)
    {
        score += punto;
        scoreText.text= score.ToString();
    }
}
