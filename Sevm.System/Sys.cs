using System;
using Sevm.Engine;

namespace Sevm.Library {

    [Script("")]
    public class Sys {

        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("获取系统运行毫秒数")]
        public static Sevm.MemoryPtr GetTickCount(NativeFunctionArgs args) {
            return Environment.TickCount;
        }

    }
}
