﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : Item {

    public virtual void UseTool() {

    }

    public virtual void Equip() { }

    public virtual void Unequip() { }

    public virtual void InitModel() { }

    public virtual void UnequipModel() { }
}