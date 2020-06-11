using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoAdjust : MonoBehaviour
{
    // Left
    public UnityEngine.UI.Button leftPosButton;
    public UnityEngine.UI.Button leftNegButton;
    public UnityEngine.UI.Text leftTempoText;
    public int leftTempo;

    // Right
    public UnityEngine.UI.Button rightPosButton;
    public UnityEngine.UI.Button rightNegButton;
    public UnityEngine.UI.Text rightTempoText;
    public int rightTempo;

    // Start is called before the first frame update
    void Start(){
        leftTempo = int.Parse(leftTempoText.text);
        rightTempo = int.Parse(rightTempoText.text);
    } 
    public void incrementTempo(string side){
        if(side == "left" && leftTempo < 20){
            leftTempo++;
            leftTempoText.text = ""+leftTempo;
        }
        else if(side == "right" && rightTempo < 20){
            
            rightTempo++;
            rightTempoText.text = ""+rightTempo;
        
        }
    }

    public void decrementTempo(string side){
        if(side == "left" && leftTempo > 0){
            leftTempo--;
            leftTempoText.text = ""+leftTempo;
        }
        else if(side == "right" && rightTempo > 0){
            
            rightTempo--;
            rightTempoText.text = ""+rightTempo;
        
        }
    }
}
