using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControl
{
    private TankModel m_tankModel;
    private TankView m_tankView;

    public TankControl(TankModel tankModel,TankView tankPrefab)
    {
        m_tankModel = tankModel;
        m_tankView = GameObject.Instantiate<TankView>(tankPrefab);
    }

}
