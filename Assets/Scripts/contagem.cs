using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contagem : MonoBehaviour
{
    public TMP_Text timerText; // Referência ao componente Text da UI

    private float timeElapsed;

    void Update()
    {
        // Atualiza o tempo decorrido
        timeElapsed += Time.deltaTime;

        // Atualiza o texto com o tempo formatado
        timerText.text = "Tempo: " + timeElapsed.ToString("F2") + "s";
    }
}
