﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityCompare
{
    [Serializable]
    public class GameObjectCompareInfo : CompareInfo
    {
        [SerializeField]
        private GameObjectCompareType m_GameObjectCompareType;

        public GameObjectCompareType gameObjectCompareType
        {
            get { return m_GameObjectCompareType; }
            set { m_GameObjectCompareType = value; }
        }


        [NonSerialized]
        private List<GameObjectCompareInfo> m_Children = new List<GameObjectCompareInfo>();

        public List<GameObjectCompareInfo> children
        {
            get { return m_Children; }
            set { m_Children = value; }
        }

        [NonSerialized]
        private List<ComponentCompareInfo> m_Components = new List<ComponentCompareInfo>();

        public List<ComponentCompareInfo> components
        {
            get { return m_Components; }
            set { m_Components = value; }
        }

        [NonSerialized]
        private GameObject m_LeftGameObject;

        public GameObject leftGameObject
        {
            get { return m_LeftGameObject; }
            set { m_LeftGameObject = value; }
        }

        [NonSerialized]
        private GameObject m_RightGameObject;

        public GameObject rightGameObject
        {
            get { return m_RightGameObject; }
            set { m_RightGameObject = value; }
        }

        public override bool AllEqual()
        {
            return m_GameObjectCompareType == GameObjectCompareType.allEqual;
        }

        public GameObjectCompareInfo(string name, int depth, int id) : base(name, depth, id)
        {

        }
    }
}