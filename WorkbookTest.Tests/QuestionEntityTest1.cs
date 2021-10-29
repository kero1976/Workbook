using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Workbook.Domain.Entities;

namespace WorkbookTest.Tests
{
    [TestClass]
    public class QuestionEntityTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            QuestionEntity entity = new QuestionEntity(1,
                "優先度に基づくプリエンプティブなスケジューリングを行うリアルタイムOSで，二つのタスクA，Bをスケジューリングする。Aの方がBより優先度が高い場合にリアルタイムOSが行う動作のうち，適切なものはどれか。",
                new List<string>(
                    )
                { "Aの実行中にBに起動がかかると，Aを実行可能状態にしてBを実行する。",
                "Aの実行中にBに起動がかかると，Aを待ち状態にしてBを実行する。",
                "Bの実行中にAに起動がかかると，Bを実行可能状態にしてAを実行する。",
                "Bの実行中にAに起動がかかると，Bを待ち状態にしてAを実行する。"},
                "Bの実行中にAに起動がかかると，Bを実行可能状態にしてAを実行する。");

            Assert.AreEqual(false, entity.isCorrect("Bの実行中にAに起動がかかると，Bを待ち状態にしてAを実行する。"));
        }
    }
}
