using System.Collections.Generic;

namespace Workbook.Domain.Entities
{
    /// <summary>
    /// 問題データ格納用
    /// </summary>
    public sealed class QuestionEntity
    {

        public QuestionEntity(int questionId, string qestionString, List<string> choice, string correct)
        {
            this.questionId = questionId;
            this.qestionString = qestionString;
            this.choice = choice;
            this.correct = correct;
        }

        /// <summary>
        /// 問題番号
        /// </summary>
        public int questionId { get; }

        /// <summary>
        /// 問題文
        /// </summary>
        public string qestionString { get; }

        /// <summary>
        /// 回答選択肢
        /// </summary>
        public List<string> choice { get; }

        /// <summary>
        /// 正解文
        /// </summary>
        public string correct { get; }

        /// <summary>
        /// 回答が正解かを判定する
        /// </summary>
        /// <param name="choice">回答</param>
        /// <returns>true:正解、false:不正解</returns>
        public bool isCorrect(string choice)
        {
            return this.correct.Equals(choice);
        }
    }
}
