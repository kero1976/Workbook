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
                "�D��x�Ɋ�Â��v���G���v�e�B�u�ȃX�P�W���[�����O���s�����A���^�C��OS�ŁC��̃^�X�NA�CB���X�P�W���[�����O����BA�̕���B���D��x�������ꍇ�Ƀ��A���^�C��OS���s������̂����C�K�؂Ȃ��̂͂ǂꂩ�B",
                new List<string>(
                    )
                { "A�̎��s����B�ɋN����������ƁCA�����s�\��Ԃɂ���B�����s����B",
                "A�̎��s����B�ɋN����������ƁCA��҂���Ԃɂ���B�����s����B",
                "B�̎��s����A�ɋN����������ƁCB�����s�\��Ԃɂ���A�����s����B",
                "B�̎��s����A�ɋN����������ƁCB��҂���Ԃɂ���A�����s����B"},
                "B�̎��s����A�ɋN����������ƁCB�����s�\��Ԃɂ���A�����s����B");

            Assert.AreEqual(false, entity.isCorrect("B�̎��s����A�ɋN����������ƁCB��҂���Ԃɂ���A�����s����B"));
        }
    }
}
