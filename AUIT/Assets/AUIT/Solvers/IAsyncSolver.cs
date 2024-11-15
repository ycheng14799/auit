using System.Collections.Generic;
using UnityEngine;
using AUIT.AdaptationObjectives.Definitions;
using AUIT.Extras;
using Cysharp.Threading.Tasks;
using AUIT.AdaptationObjectives;
//using AUIT.Constraints;

namespace AUIT.Solvers
{
    [System.Serializable]
    public abstract class IAsyncSolver
    {
        //[SerializeReference]
        //public List<Constraint> constraints;
        public void Initialize(AdaptationManager adaptationManager)
        {
            AdaptationManager = adaptationManager;
        }
        public void Destroy() {}
        public abstract UniTask<OptimizationResponse> OptimizeCoroutine(
            List<Layout> initialLayouts, 
            List<List<LocalObjective>> objectives
        );

        [System.NonSerialized]
        public AdaptationManager AdaptationManager;
    }
}