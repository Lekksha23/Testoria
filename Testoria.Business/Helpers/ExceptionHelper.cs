using Testoria.Business.Exceptions;

namespace Testoria.Business.Helpers
{
    internal static class ExceptionHelper
    {
        internal static void CheckIfEntityIsNull<T>(int id, T entity)
        {
            if (entity is null)
            {
                throw new EntityNotFoundException($"{typeof(T).Name} with Id {id} does not exist.");
            }
        }
    }
}
