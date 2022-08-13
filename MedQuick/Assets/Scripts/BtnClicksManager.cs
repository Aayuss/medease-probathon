using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BtnClicksManager : MonoBehaviour
{ 
    [Header("Search Bar")]
    public GameObject searchBarBefore;
    public Button invisibleButtonOfSearchBar;

    [Header("Doctor's Lists")] public GameObject doctorsListPanel;

    [Header("Doctor's Profile")] public GameObject doctorsProfilePanel;
    public GameObject db_confirmRequest;

    private void Start()
    {
        invisibleButtonOfSearchBar.gameObject.SetActive(false);
    }

    public void OnSearchSelected()
    {
        invisibleButtonOfSearchBar.gameObject.SetActive(true);
        searchBarBefore.GetComponent<Animator>().SetBool("Clicked", true);
    }
    
    public void OnSearchDeselected()
    {
        invisibleButtonOfSearchBar.gameObject.SetActive(false);
        searchBarBefore.GetComponent<Animator>().SetBool("Clicked", false);
    }
    
    public void OnSearchButtonPressed()
    {
        invisibleButtonOfSearchBar.gameObject.SetActive(false);
        doctorsListPanel.SetActive(true);
        
        searchBarBefore.GetComponent<Animator>().SetBool("TransToDoctorsList", true);
        
        doctorsListPanel.GetComponent<Animator>().SetBool("Appear", true);
    }

    public void OnInvisibleButtonOfSearchBarPressed()
    {
        print("Button Pressed");
        OnSearchDeselected();
    }

    public void OnBackButtonOfDoctorsListPanelPressed()
    {
        doctorsListPanel.GetComponent<Animator>().SetBool("Appear", false);
        
        searchBarBefore.SetActive(true);
        searchBarBefore.GetComponent<Animator>().SetBool("TransToDoctorsList", false);
        searchBarBefore.GetComponent<Animator>().SetBool("Clicked", false);
        
    }

    public void OnDoctorsIconOnListPressed()
    {
        doctorsProfilePanel.GetComponent<Animator>().SetBool("Appear", true);
    }


    public void OnBackButtonOfDoctorsProfilePanelPressed()
    {
        doctorsProfilePanel.GetComponent<Animator>().SetBool("Appear", false);
    }

    public void OnRequestToPressed()
    {
        db_confirmRequest.GetComponent<Animator>().SetBool("Appear", true);
    }

    public void OnRequestToClosed()
    {
        db_confirmRequest.GetComponent<Animator>().SetBool("Appear", false);
    }
}
