using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [Header("Player")]
    [SerializeField]
    private MonoDynamicEntity player;

    [Header("Move")]
    [SerializeField]
    private MoveRigidbodyController moveController;

    [Header("Jump")]
    [SerializeField]
    private JumpWithRigidbody jumpController;

    [Header("Rigidbody")]
    [SerializeField]
    private Rigidbody2D rb;

    public override void InstallBindings()
    { 
        Container.Bind<IDynamicEntity>().FromInstance(player);

        Container.Bind<IMoveController>().FromInstance(moveController);
        Container.Bind<IJumpController>().FromInstance(jumpController);
        Container.Bind<Rigidbody2D>().FromInstance(rb);
    }
}
 