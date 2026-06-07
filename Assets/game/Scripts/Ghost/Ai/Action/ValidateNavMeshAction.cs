using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Validate NavMesh", story: "Validate NavMesh from [AI]", category: "Action", id: "552be25a65270c5d1816fe18a00851c1")]
public partial class ValidateNavMeshAction : Action
{
    [SerializeReference] public BlackboardVariable<GhostAIController> AI;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if(AI.Value == null)
        {
            return Status.Failure;
        }

        if(AI.Value.NavMeshAgent == null)
        {
            return Status.Failure;
        }

        if(AI.Value.NavMeshAgent.isActiveAndEnabled == false)
        {
            return Status.Failure;
        }

        if(AI.Value.NavMeshAgent.isOnNavMesh == false)
        {
            return Status.Failure;
        }
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

