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
    private bool isArrived = false;
    public bool IsArrived {  get { return isArrived; } set { isArrived = value; } }

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
        if (!isArrived)
        {
            textDistContainer.text = (int)(totalDistance - dist) + " m";
        }
    }

    public void ChangeWhereToGo(LocationPointScriptableObject locationPoint)
    {
        if (locationPoint.locationName.Length > 5) 
        {
            textPlace.text = locationPoint.locationName.Substring(0,5) + "...";
            return;
        }
        textPlace.text = locationPoint.locationName;
    }

    public void ChangeBoxContents()
    {
        textPlace.gameObject.SetActive(false);
        textDistContainer.text = "Item Collected!";
    }
}
