
using Aplication.Interfaces;

namespace Shared.Services
{
    public class DateTimeService : IDateTimeService
    {

        DateTime IDateTimeService.NowUtc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
