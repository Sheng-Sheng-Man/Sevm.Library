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
        public static Sevm.Engine.Memory.Value Say(Params args) {
            Sevm.Engine.Memory.Object obj = (Sevm.Engine.Memory.Object)args[0];
            System.Console.WriteLine(obj.ValueList[0].ToString());
            return 0;
        }

        /// <summary>
        /// 控制台输出
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("控制台输出")]
        public static Sevm.Engine.Memory.Value Write(Params args) {
            Sevm.Engine.Memory.Object obj = (Sevm.Engine.Memory.Object)args[0];
            //for (int i = 0; i < obj.KeyList.Count; i++) {
            //    Console.WriteLine($"{obj.KeyList[i].ToString()}={obj.ValueList[i].ToString()}");
            //}
            if (obj.ContainsKey("内容")) {
                System.Console.Write(obj["内容"].ToString());
            } else {
                System.Console.Write(obj.ValueList[0].ToString());
            }
            return 0;
        }

        /// <summary>
        /// 换行输出
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("控制台换行输出")]
        public static Sevm.Engine.Memory.Value WriteLine(Params args) {
            if (args.Count == 0) {
                System.Console.WriteLine();
                return 0;
            }
            Sevm.Engine.Memory.Object obj = (Sevm.Engine.Memory.Object)args[0];
            if (obj.ContainsKey("内容")) {
                System.Console.WriteLine(obj["内容"].ToString());
            } else {
                System.Console.WriteLine(obj.ValueList[0].ToString());
            }
            return 0;
        }

        /// <summary>
        /// 读取数字
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [Script("控制台读取数字")]
        public static Sevm.Engine.Memory.Value ReadNumber(Params args) {
            return double.Parse(System.Console.ReadLine());
        }

    }
}
