using SO.Client.Base;
using System.Collections.Generic;

namespace SO.Client.Post
{
    public class QuestionResponseSM: BaseResponseSM
    {
        public List<QuestionSM> items { get; set; }
    }
}
