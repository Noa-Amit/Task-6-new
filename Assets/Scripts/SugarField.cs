﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class SugarField : MonoBehaviour {
    private TextMeshPro textField;
    [SerializeField] public double initSugar;
    [SerializeField] public double maxSugarAllowed;
    [SerializeField] public double minSugarAllowed;
    private double sugar;

    void Start(){
        textField = GetComponent<TextMeshPro>();
        sugar = initSugar;
        textField.text = sugar.ToString();
    }

    public void SetNumber(double newNumber) {
        this.sugar = newNumber;
        this.textField.text = ((int)sugar).ToString();
    }

    public void AddToNumber(double newNumber) {
        this.sugar += newNumber;
        this.textField.text = ((int)sugar).ToString();
    }

    public void Init() {
        sugar = initSugar;
        this.textField.text = ((int)sugar).ToString();
    }

    public double GetSugar(){ return sugar;}

    public bool isValid(){//check if sugar too low or high
        if(sugar <= minSugarAllowed || sugar >= maxSugarAllowed){
            return false;
        }
        return true;
    }
}
