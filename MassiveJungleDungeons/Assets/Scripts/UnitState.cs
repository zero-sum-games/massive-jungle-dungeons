﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//==============================================================================
public class UnitState : MonoBehaviour
{
    //==========================================================================

    public enum ElementalState
    {
        FIRE        = 0,
        WATER       = 1,
        ELECTRIC    = 2
    }

    public ElementalState elementalState = ElementalState.FIRE;

    //==========================================================================

    // set the color of the game object according to current elemental state
    protected void SetColor()
    {
        // Color32 allows for byte values instead of floats from 0.0f - 1.0f
        Color32 color;
        switch (elementalState)
        {
            default:
            case ElementalState.FIRE:
                color = new Color32(242, 94, 61, 1);
                break;

            case ElementalState.WATER:
                color = new Color32(77, 125, 247, 1);
                break;

            case ElementalState.ELECTRIC:
                color = new Color32(242, 220, 78, 1);
                break;
        }

        GetComponent<Renderer>().material.color = color;
    }

    //==========================================================================

    private void Start()
    {
        SetColor();
    }
}