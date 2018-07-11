using SO.Client.Base;
using System.Threading.Tasks;

namespace SO.Client.Badges
{
    public class BadgeClient: BaseClient
    {
        public async Task<BadgeResponseSM> GetBadges()
        {
            return await base.GetResponse<BadgeResponseSM, object>("/2.2/badges?order=desc&sort=rank&site=stackoverflow", null, null, false);
        }
    }
}
