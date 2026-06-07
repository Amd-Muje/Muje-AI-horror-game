using System;
using Unity.Behavior;
using UnityEngine;
using UnityEngine.AI;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Wait Until Reach Destionation", story: "[AI] wait until reach destination", category: "Action", id: "d9ac389478516c8b79dc7d5759bdf613")]
public partial class WaitUntilReachDestionation : Action
{
    [SerializeReference] public BlackboardVariable<GhostAIController> AI;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if (AI.Value == null)
        {
            return Status.Failure;
        }

        NavMeshAgent agent = AI.Value.NavMeshAgent;

        if (agent == null)
        {
            return Status.Failure;
        }

        if (agent.pathPending == true)
        {
            return Status.Running;
        }

        if (agent.remainingDistance > agent.stoppingDistance + 0.5f)
        {
            return Status.Running;
        }

        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

