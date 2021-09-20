using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChemicalReactions : MonoBehaviour
{
    private bool ice;
    private bool fire;
    private bool boom;

    private bool crystal;
    private bool dac;

    private bool s;
    private bool m;

    private bool hp;
    private bool dl;

    private bool table1;
    private bool table2;
    private bool table3;

    public GameObject table1Correct;
    public GameObject table2Correct;
    public GameObject table3Correct;
    public GameObject table1Origin;
    public GameObject table2Origin;
    public GameObject table3Origin;

 
    void Update()
    {
        if (table1 == true && table2 == false && table3 == false)
        {
            CheckT1();
            if (ice == true)
            {
                t1Correct();
            }
           
        }
        if(table2 == true && table3 == false && table1 == false)
        {
            CheckT2();
            if (fire == true)
            {
                t2Correct();
            }
         
        }
        if (table3 == true && table1 == false && table2 == false)
        {
            CheckT3();
            if (boom == true)
            {
                t3Correct();
            }
        }
    }

    public void Wrong()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
    private void CheckT1()
    {
        if(crystal == true && dac == true && s == false && m == false && dl == false && hp == false)
        {
            ice = true;
            Debug.Log("wooo");
        }
        if(s == true || m == true || dl == true || hp == true)
        {
            Wrong();
        }
    }
    private void CheckT2()
    {
        if (crystal == false && dac == false && s == true && m == true && dl == false && hp == false)
        {
            fire = true;
            Debug.Log("wooo");
        }
        if (crystal == true || dac == true || dl == true || hp == true)
        {
            Wrong();
        }
    }
    private void CheckT3()
    {
        if(crystal == false && dac == false && s == false && m == false && dl == true && hp == true)
        {
            boom = true;
            Debug.Log("wooo");
        }
        if(crystal == true || dac == true || s == true || m == true)
        {
            Wrong();
        }
    }

    public void t3Correct()
    {
        table3Correct.SetActive(true);
        table3Origin.SetActive(false);
        Debug.Log("wooo");
    }
    public void t2Correct()
    {
        table2Correct.SetActive(true);
        table2Origin.SetActive(false);
        Debug.Log("wooo");
    }
    public void t1Correct()
    {
        table1Correct.SetActive(true);
        table1Origin.SetActive(false);
        Debug.Log("wooo");
    }
    public void SetFalse()
    {
        crystal = false;
        dac = false;
        s = false;
        m = false;
        hp = false;
        dl = false;

    }

    public void Crystal()
    {
        crystal = true;
    }
    public void DAC()
    {
        dac = true;
    }
    public void S()
    {
        s = true;
    }
    public void M()
    {
        m = true;
    }
    public void HP()
    {
        hp = true;
    }
    public void DL()
    {
        dl = true;
    }
    public void Table1A()
    {
        table1 = true;
    }
    public void Table2A()
    {
        table2 = true;
    }
    public void Table3A()
    {
        table3 = true;
    }  
    public void Table1D()
    {
        table1 = false;
    }
    public void Table2D()
    {
        table2 = false;
    }
    public void Table3D()
    {
        table3 = false;
    }
}
