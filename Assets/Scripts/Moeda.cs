﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moeda : MonoBehaviour{

    private int novoLevel;

    // Start is called before the first frame update
    void Start(){
        novoLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        SceneManager.LoadScene(novoLevel);
    }
}
