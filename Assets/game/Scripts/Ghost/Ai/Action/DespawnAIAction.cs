using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Despawn AI", story: "Despawn [AI]", category: "Action", id: "37ed3b517c960942e1ec29783db07654")]
public partial class DespawnAIAction : Action
{
    [SerializeReference] public BlackboardVariable<GhostAIController> AI;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if(AI.Value != null)
        {
            return Status.Failure;
        }
        AI.Value.Despawn();
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

