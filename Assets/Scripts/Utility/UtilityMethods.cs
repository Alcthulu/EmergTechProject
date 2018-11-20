using UnityEngine;

public static class UtilityMethods {
  public static void MoveUiElementToWorldPosition(RectTransform rectTransform, Vector3 worldPosition) {
    Vector2 screenPoint = Camera.main.WorldToScreenPoint(worldPosition);
    rectTransform.position = screenPoint;
  }
}

