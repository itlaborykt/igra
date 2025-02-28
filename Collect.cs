using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collect : MonoBehaviour
{
  public TextMeshProUGUI Text;

  void OnMouseDown()
  {
    Destroy(gameObject);
    Text.fontStyle = FontStyles.Strikethrough;
  }
}
