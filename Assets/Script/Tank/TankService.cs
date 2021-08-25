using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : Singleton<TankService>
{

    private TankModel m_tankModel;
    private TankControl m_tankController;

    [SerializeField]private TankView m_tankView;
    [SerializeField]private TankScriptableObject initialTankConfig;

    // The Singleton's constructor should always be private to prevent
    // direct construction calls with the `new` operator.
    private TankService(){ }

    private void Start()
    {
        spawnTank(initialTankConfig);
    }

    private void spawnTank(TankScriptableObject tankConfig)
    {
        m_tankModel = new TankModel(tankConfig);
        m_tankController = new TankControl(m_tankModel, m_tankView);
    }

}
