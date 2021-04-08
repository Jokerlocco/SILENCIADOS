﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrucosDelJuego : MonoBehaviour
{
    [SerializeField] bool llaveAlfilEnElInventarioDelJugador = false;
    [SerializeField] bool llaveCaballoEnElInventarioDelJugador = false;
    [SerializeField] bool llavePeonEnElInventarioDelJugador = false;
    [SerializeField] bool llaveReyEnElInventarioDelJugador = false;
    [SerializeField] bool llaveTorreEnElInventarioDelJugador = false;
    [SerializeField] bool ganzuaEnElInventarioDelJugador = false;
    [SerializeField] bool extintorEnElInventarioDelJugador = false;
    [SerializeField] bool jarronEnElInventarioDelJugador = false;
    [SerializeField] bool grifoMarmolEnElInventarioDelJugador = false;
    [SerializeField] bool grifoMaderaEnElInventarioDelJugador = false;
    [SerializeField] bool grifoBronceEnElInventarioDelJugador = false;
    [SerializeField] bool vinagreEnElInventarioDelJugador = false;
    [SerializeField] bool acetonaEnElInventarioDelJugador = false;
    [SerializeField] bool eterEnElInventarioDelJugador = false;
    [SerializeField] bool disolventeDeSiliconaEnElInventarioDelJugador = false;

    private void Update()
    {
        if (llaveAlfilEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                LlaveAlfilEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                LlaveAlfilEnElInventario = false;

        if (llaveCaballoEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                LlaveCaballoEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                LlaveCaballoEnElInventario = false;

        if (llavePeonEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                LlavePeonEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                LlavePeonEnElInventario = false;

        if (llaveReyEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                LlaveReyEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                LlaveReyEnElInventario = false;

        if (llaveTorreEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                LlaveTorreEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                LlaveTorreEnElInventario = false;

        if (ganzuaEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                GanzuaEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                GanzuaEnElInventario = false;

        if (extintorEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                ExtintorEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                ExtintorEnElInventario = false;

        if (jarronEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                JarronEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                JarronEnElInventario = false;

        if (grifoMarmolEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                GrifoMarmolEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                GrifoMarmolEnElInventario = false;

        if (grifoMaderaEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                GrifoMaderaEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                GrifoMaderaEnElInventario = false;

        if (grifoBronceEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                GrifoBronceEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                GrifoBronceEnElInventario = false;

        if (vinagreEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                VinagreEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                VinagreEnElInventario = false;

        if (eterEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                EterEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                EterEnElInventario = false;

        if (acetonaEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                AcetonaEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                AcetonaEnElInventario = false;

        if (disolventeDeSiliconaEnElInventarioDelJugador)
            FindObjectOfType<InventarioJugador>().
                DisolventeDeSiliconaEnElInventario = true;
        else
            FindObjectOfType<InventarioJugador>().
                DisolventeDeSiliconaEnElInventario = false;
    }
}
