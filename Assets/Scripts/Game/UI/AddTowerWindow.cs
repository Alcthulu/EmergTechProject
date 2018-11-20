using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTowerWindow : MonoBehaviour
{
  //1
  public GameObject towerSlotToAddTowerTo;
  //2
  public void AddTower(string towerTypeAsString)
  {
    //3
    TowerType type = (TowerType)Enum.Parse(typeof(TowerType), towerTypeAsString, true);
    //4
    if (TowerManager.Instance.GetTowerPrice(type) <= GameManager.Instance.gold)
    {
      //5
      GameManager.Instance.gold -= TowerManager.Instance.GetTowerPrice(type);
      gameObject.SetActive(false);
    }
  }

}
