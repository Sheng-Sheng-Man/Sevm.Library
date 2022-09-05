using System;
using Sevm.Engine;

namespace Sevm.Library {

    [Script("")]
    public class Console {

        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("他说")]
        public static Sevm.MemoryPtr Say(NativeFunctionArgs e) {
            Sevm.MemoryObject obj = e.Params[0].GetObject(e.Memory);
            System.Console.WriteLine(obj.Values.GetItemContent(0).GetString());
            return 0;
        }

        /// <summary>
        /// 控制台输出
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("控制台输出")]
        public static Sevm.MemoryPtr Write(NativeFunctionArgs e) {
            Sevm.MemoryObject obj = e.Params[0].GetObject(e.Memory);
            if (obj.ContainsKey("内容")) {
                System.Console.Write(obj.GetKeyValue("内容").GetString());
            } else {
                System.Console.Write(obj.Values.GetItemContent(0).GetString());
            }
            return 0;
        }

        /// <summary>
        /// 换行输出
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("控制台换行输出")]
        public static Sevm.MemoryPtr WriteLine(NativeFunctionArgs e) {
            if (e.Params.Count == 0) {
                System.Console.WriteLine();
                return 0;
            }
            Sevm.MemoryObject obj = e.Params[0].GetObject(e.Memory);
            if (obj.ContainsKey("内容")) {
                System.Console.WriteLine(obj.GetKeyValue("内容").GetString());
            } else {
                System.Console.WriteLine(obj.Values.GetItemContent(0).GetString());
            }
            return 0;
        }

        /// <summary>
        /// 读取数字
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("控制台读取数字")]
        public static Sevm.MemoryPtr ReadNumber(NativeFunctionArgs e) {
            return e.Memory.CreateDouble(double.Parse(System.Console.ReadLine()));
        }

    }
}
