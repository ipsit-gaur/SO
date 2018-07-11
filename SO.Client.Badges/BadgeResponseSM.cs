using SO.Client.Base;
using System.Collections.Generic;

namespace SO.Client.Badges
{
    public class BadgeResponseSM : BaseResponseSM
    {
        public List<BadgeSM> items { get; set; }
    }
}
