using System.Threading.Tasks;

namespace Actio.Common.Commands
{
    public interface ICommandHandler<in T> where T: IEvent
    {
        Task HandleAsync(T command);

    }
}
