using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ERC721BalanceOfExample : MonoBehaviour
{
    public GameObject ineligible;
    async void Start()
    {
        string chain = "polygon";
        string network = "mainnet"; 
        string contract = "0xB9790B87a55982e2905E56f68B67cF9BAd502A73";
        string account = PlayerPrefs.GetString("Account");

        int balance = await ERC721.BalanceOf(chain, network, contract, account);
        if (balance > 0)
        {
            // Load the game scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else {
            // Activate the insufficient token object
            ineligible.SetActive(true);
        }
    }
}
