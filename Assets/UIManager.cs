using Mapbox.Unity.Map;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textDistContainer;
    [SerializeField] TextMeshProUGUI textPlace;
    private float totalDistance;

    public void InitializeUIDistance(float distanceTotal)
    {
        textDistContainer.text = distanceTotal + " m";
        totalDistance = distanceTotal;
        Debug.Log(totalDistance);
    }

    public void InitializeTotalDistanceBeforeRouting(float dist)
    {
        totalDistance -= dist;
    }

    public void KeepDistance (float dist)
    {
        totalDistance -= dist;
    }

    public void ChangeDistanceTravel(float dist)
    {
        //float distanceRemaining = totalDistance + dist;
        
        textDistContainer.text = (int)(totalDistance - dist) + " m";
    }

    public void ChangeWhereToGo(LocationPointScriptableObject locationPoint)
    {
        textPlace.text = locationPoint.locationName;
    }

    public void ChangeBoxContents()
    {
        textPlace.gameObject.SetActive(false);
        textDistContainer.text = "Item Collected!";
    }
}
