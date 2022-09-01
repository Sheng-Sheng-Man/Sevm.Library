using System;
using Sevm.Engine;

namespace Sevm.Library {

    [Script("")]
    public class Test {

        /// <summary>
        /// 获取测试
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("获取测试")]
        public static Sevm.Engine.Memory.Value GetTickCount(Params args) {
            return "这是声声慢测试库";
        }

    }
}
